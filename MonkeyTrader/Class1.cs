//
// +----------------------------------------------------------+
// + Author: Justin Bannerman
// + Date: Jan 2022
// + Desc:
// +    Trading Panel for live & backtesting
// +    - Pos size risk based w/Max
// +    - Split Positions with step Targets, auto BE
// +    - Manual BE's, Trails etc.
// +    Work in progress
// +----------------------------------------------------------+
// Change History
// ------------------------------------------------------------
// 11/11/2023  JustinB  Change UI Layout, add features, simplify
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cAlgo.API;
using cAlgo.API.Collections;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;
using static cAlgo.Robots.MonkeyTrader;

namespace cAlgo.Robots
{
    [Robot(TimeZone = TimeZones.UTC)]
    public class MonkeyTrader : Robot
    {

        [Parameter("Manage All Positions", DefaultValue = true, Group ="General Settings")]
        public bool ManageAllPos { get; set; }

        [Parameter("Preview before Trade", DefaultValue = false, Group = "General Settings")]
        public bool MustPreview { get; set; }

        [Parameter("Show Dollars", DefaultValue = false, Group = "General Settings")]
        public bool ShowDollars { get; set; }

        [Parameter("Gain % Close", DefaultValue = 5.0, Group = "General Settings")]
        public double GainClosePerc { get; set; }

        [Parameter("Max Risk %", DefaultValue = 1.00, MinValue = 0.01, Group ="Positions")]
        public double MaxRisk { get; set; }

        [Parameter("Max Volume", DefaultValue = 1, MinValue = 1, Group = "Positions")]
        public int MaxVolume { get; set; }

        [Parameter("Number of Positions", DefaultValue = 1, MinValue = 1, Group = "Positions")]
        public int NumPositions { get; set; }

        [Parameter("Auto Break Even", DefaultValue = true, Group = "BE & Trail")]
        public bool AutoBE { get; set; }

        [Parameter("BE Padding", DefaultValue = 1.0, Group = "BE & Trail")]
        public double BEPadding { get; set; }

        [Parameter("Trail Padding", DefaultValue = 0.0, Group = "BE & Trail")]
        public double TrailPadding { get; set; }


        private Form1 _mainForm;
        private int _candlesToTrail = 3;
        private bool _trailOnlyAfterBE = false;
        private ParabolicSAR _sar;
        private double _minAF = 0.02, _maxAF = 0.2;
        private TrailType _trailType = TrailType.None;
        private bool _autoBreakEven = true;
        private string _liveOrBacktesting = "";
        private bool _debugMessagesOn = false;
        private Thread staThread;
        private ExponentialMovingAverage _EMA13, _EMA20, _EMA50, _EMA100, _EMA200;

        public string BotVersion = "";
        public const string Expirydate = "1/07/2024";

        public enum TrailType
        {
            None,
            Regular,
            Candle,
            SAR,
            TargetStep,
            EMA13,
            EMA20,
            EMA50,
            EMA100,
            EMA200
        }

        public enum BreakEvenMode
        {
            None,
            AutoBasic,
            AutoStep
        }
        protected override void OnStart()
        {
            //
            Version version = this.Application.Version;
            BotVersion = String.Format("Version: {0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            Print(BotVersion + " (Expires " + Expirydate + ")");

            //System.Diagnostics.Debugger.Launch();
            Timer.Start(2);

            // You can pass your indicator/cBot to form and start interacting with it via form controls
            _mainForm = new Form1(this);

            // You have to create a new thread to show the form, so it will not block the cBot main thread
            staThread = new Thread(() => _mainForm.ShowDialog());

            // The form must be executed on a STA thread
            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();

            _sar = Indicators.ParabolicSAR(_minAF, _maxAF);
            _EMA13 = Indicators.ExponentialMovingAverage(Bars.ClosePrices, 13);
            _EMA20 = Indicators.ExponentialMovingAverage(Bars.ClosePrices, 20);
            _EMA50 = Indicators.ExponentialMovingAverage(Bars.ClosePrices, 50);
            _EMA100 = Indicators.ExponentialMovingAverage(Bars.ClosePrices, 100);
            _EMA200 = Indicators.ExponentialMovingAverage(Bars.ClosePrices, 200);

            if (this.IsBacktesting) _liveOrBacktesting = " <BACKTESTING> ";

            if (DateTime.Now.Date > DateTime.Parse(Expirydate))
            {
                Print("This version of the bot has expired. Please update to the latest version.");
                Stop();
            }

        }

        protected override void OnTimer()
        {
            string tLabel = _mainForm.Controls.Find("txtBotLabel", true)[0].Text;
            double tpPips = (double)((NumericUpDown)_mainForm.Controls.Find("nudTPStep", true)[0]).Value;
            double paddingPipsBE = (double)((NumericUpDown)_mainForm.Controls.Find("nudPipsPadding", true)[0]).Value;
            double paddingPipsTrail = (double)((NumericUpDown)_mainForm.Controls.Find("nudTrailPaddingPips", true)[0]).Value;
            double breakEvenAfter = (double)((NumericUpDown)_mainForm.Controls.Find("nubBEAfter", true)[0]).Value;
            double closeOnGainPerc = (double)((NumericUpDown)_mainForm.Controls.Find("nudCloseOnGainPerc", true)[0]).Value;
            System.Windows.Forms.CheckBox check = (System.Windows.Forms.CheckBox)_mainForm.Controls.Find("checkBoxManageAllPos", true)[0];
            bool changeNonBotPos = check.Checked;
            check = (System.Windows.Forms.CheckBox)_mainForm.Controls.Find("checkBoxShowDollars", true)[0];
            bool showDollars = check.Checked;

            double gain = 0;
            double totPips = 0;
            int totPos = 0;

            if (staThread.ThreadState == ThreadState.Stopped && Chart.IsActive)
            {
                staThread = new Thread(() => _mainForm.ShowDialog());

                // The form must be executed on a STA thread
                staThread.SetApartmentState(ApartmentState.STA);
                staThread.Start();
            }


            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBotPos))
                {
                    gain += p.NetProfit;
                    totPips += p.Pips;
                    totPos += 1;
                    switch (_trailType)
                    {
                        case TrailType.None:
                            if (p.HasTrailingStop == true)
                                p.ModifyTrailingStop(false);
                            break;
                        case TrailType.Regular:
                            if (p.HasTrailingStop == false)
                                if ((!_trailOnlyAfterBE) || p.Pips > breakEvenAfter)
                                    p.ModifyTrailingStop(true);
                            break;
                        case TrailType.SAR:
                            UpdateTrail(p, _sar.Result.LastValue, _sar.Result.LastValue, paddingPipsTrail, true, breakEvenAfter);
                            break;
                        case TrailType.Candle:
                            UpdateTrail(p, Bars.LowPrices.Minimum(_candlesToTrail), Bars.HighPrices.Maximum(_candlesToTrail), paddingPipsTrail, true, breakEvenAfter);
                            break;
                        case TrailType.TargetStep:
                            if (p.HasTrailingStop == true)
                                p.ModifyTrailingStop(false);
                            if (p.Pips > 0)
                            {
                                int TPs = (int)Math.Truncate(p.Pips / tpPips);
                                if (TPs >= 1 && p.Pips > tpPips * TPs + breakEvenAfter)
                                {
                                    double newSL = ((TPs - 1) * tpPips) + paddingPipsBE;
                                    // set stop loss to prev target plus padding
                                    double newSLPrice = 0;

                                    if (p.TradeType == TradeType.Buy)
                                    {
                                        newSLPrice = Math.Round((double)p.EntryPrice + (newSL * Symbol.PipSize) + Symbol.Spread, Symbol.Digits);
                                        if (newSLPrice > p.StopLoss)
                                            p.ModifyStopLossPrice(newSLPrice);
                                    }
                                    else
                                    {
                                        newSLPrice = Math.Round((double)p.EntryPrice - (newSL * Symbol.PipSize) - Symbol.Spread, Symbol.Digits);
                                        if (newSLPrice < p.StopLoss)
                                            p.ModifyStopLossPrice(newSLPrice);
                                    }
                                }
                            }
                            break;
                        case TrailType.EMA13:
                            UpdateTrail(p, _EMA13.Result.LastValue, _EMA13.Result.LastValue, paddingPipsTrail, true, breakEvenAfter);
                            break;
                        case TrailType.EMA20:
                            UpdateTrail(p, _EMA20.Result.LastValue, _EMA20.Result.LastValue, paddingPipsTrail, true, breakEvenAfter);
                            break;
                        case TrailType.EMA50:
                            UpdateTrail(p, _EMA50.Result.LastValue, _EMA50.Result.LastValue, paddingPipsTrail, true, breakEvenAfter);
                            break;
                        case TrailType.EMA100:
                            UpdateTrail(p, _EMA100.Result.LastValue, _EMA100.Result.LastValue, paddingPipsTrail, true, breakEvenAfter);
                            break;
                        case TrailType.EMA200:
                            UpdateTrail(p, _EMA200.Result.LastValue, _EMA200.Result.LastValue, paddingPipsTrail, true, breakEvenAfter);
                            break;
                    }
                    // Check if past BE
                    if (_autoBreakEven && p.Pips > breakEvenAfter)
                    {
                        double newSLPrice = 0;
                        if (p.TradeType == TradeType.Buy)
                        {
                            newSLPrice = Math.Round((double)p.EntryPrice + (paddingPipsBE * Symbol.PipSize) + Symbol.Spread, Symbol.Digits);
                            if (newSLPrice > p.StopLoss)
                                p.ModifyStopLossPrice(newSLPrice);
                        }
                        else
                        {
                            newSLPrice = Math.Round((double)p.EntryPrice - (paddingPipsBE * Symbol.PipSize) - Symbol.Spread, Symbol.Digits);
                            if (newSLPrice < p.StopLoss)
                                p.ModifyStopLossPrice(newSLPrice);
                        }
                    }

                }
            }
            // Update Status text & Colour
            if (totPos > 0)
            {
                double perc = gain / this.Account.Balance;
                if (closeOnGainPerc > 0 && (perc * 100)  > closeOnGainPerc)
                {
                    foreach (var p in Positions)
                    {
                        if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBotPos))
                            ClosePositionAsync(p);
                    };
                }
                string status = _liveOrBacktesting;
                if (showDollars)
                    status += gain.ToString("C") + " / ";
                status += perc.ToString("P2") + " / " + totPips.ToString("N1") + " PipSum ";
                _mainForm.Controls.Find("txtStatus", true)[0].Text = status;
                if (gain == 0)
                    _mainForm.Controls.Find("txtStatus", true)[0].BackColor = Form1.DefaultBackColor;
                if (gain > 0)
                    _mainForm.Controls.Find("txtStatus", true)[0].BackColor = System.Drawing.Color.Aquamarine;
                if (gain < 0)
                    _mainForm.Controls.Find("txtStatus", true)[0].BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                _mainForm.Controls.Find("txtStatus", true)[0].Text = _liveOrBacktesting + " No Positions ";
                _mainForm.Controls.Find("txtStatus", true)[0].BackColor = System.Drawing.Color.DarkGray;
            }
                        
        }

        private void UpdateTrail(Position pos, double lastValueBuy, double lastValueSell, double paddingPips, bool addSpread, double breakEvenAfter)
        {
            if (pos.HasTrailingStop == true)
                pos.ModifyTrailingStop(false);
            if ((!_trailOnlyAfterBE) || (_autoBreakEven && pos.Pips > breakEvenAfter))
            {
                if (pos.TradeType == TradeType.Buy)
                {
                    double newSLPrice = Math.Round(lastValueBuy - (paddingPips * Symbol.PipSize) - Symbol.Spread, Symbol.Digits);
                    if (newSLPrice > pos.StopLoss && newSLPrice < Symbol.Ask)
                        pos.ModifyStopLossPrice(newSLPrice);
                }
                else
                {
                    double newSLPrice = Math.Round(lastValueSell + (paddingPips * Symbol.PipSize) + Symbol.Spread, Symbol.Digits);
                    if (newSLPrice < pos.StopLoss && newSLPrice > Symbol.Bid)
                        pos.ModifyStopLossPrice(newSLPrice);
                }
            }
        }

        public void SetTrail(TrailType trailType, int candlesToTrail, bool trailAfterBE)
        {
            _trailType = trailType;
            _candlesToTrail = candlesToTrail;
            _trailOnlyAfterBE = trailAfterBE;
        }

        public void SetBreakEvenMode(bool autoBreakEven)
        {
            _autoBreakEven = autoBreakEven;
        }

        public void MoveAllBreakEven()
        {
            string tLabel = _mainForm.Controls.Find("txtBotLabel", true)[0].Text;
            double paddingPips = (double)((NumericUpDown)_mainForm.Controls.Find("nudPipsPadding", true)[0]).Value;
            System.Windows.Forms.CheckBox check = (System.Windows.Forms.CheckBox)_mainForm.Controls.Find("checkBoxManageAllPos", true)[0];
            bool changeNonBotSL = check.Checked;

            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBotSL))
                {
                    if (p.Pips > paddingPips)
                    {
                        double newSLPrice = 0;
                        if (p.TradeType == TradeType.Buy)
                        {
                            newSLPrice = Math.Round((double)p.EntryPrice + (paddingPips * Symbol.PipSize), Symbol.Digits);
                            if (newSLPrice > p.StopLoss)
                                p.ModifyStopLossPrice(newSLPrice);
                        }
                        else
                        {
                            newSLPrice = Math.Round((double)p.EntryPrice - (paddingPips * Symbol.PipSize), Symbol.Digits);
                            if (newSLPrice < p.StopLoss)
                                p.ModifyStopLossPrice(newSLPrice);
                        }
                    }
                }
            }
        }
        public void SyncSL()
        {
            string tLabel = _mainForm.Controls.Find("txtBotLabel", true)[0].Text;
            double paddingPips = (double)((NumericUpDown)_mainForm.Controls.Find("nudPipsPadding", true)[0]).Value;
            System.Windows.Forms.CheckBox check = (System.Windows.Forms.CheckBox)_mainForm.Controls.Find("checkBoxManageAllPos", true)[0];
            bool changeNonBotSL = check.Checked;

            double highestBuySL = double.MinValue;
            double lowestSellSL = double.MaxValue;

            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBotSL))
                {
                    if (p.TradeType == TradeType.Buy && p.StopLoss != null && p.StopLoss > highestBuySL) highestBuySL = (double)p.StopLoss;
                    if (p.TradeType == TradeType.Sell && p.StopLoss != null && p.StopLoss < lowestSellSL) lowestSellSL = (double)p.StopLoss;
                }
            }
            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBotSL))
                {
                    if (p.TradeType == TradeType.Buy)
                    {
                        if (highestBuySL > p.StopLoss)
                            p.ModifyStopLossPrice(highestBuySL);
                    }
                    else
                    {
                        if (lowestSellSL < p.StopLoss)
                            p.ModifyStopLossPrice(lowestSellSL);
                    }
                }
            }
        }

        public void SyncTP()
        {
            string tLabel = _mainForm.Controls.Find("txtBotLabel", true)[0].Text;
            System.Windows.Forms.CheckBox check = (System.Windows.Forms.CheckBox)_mainForm.Controls.Find("checkBoxManageAllPos", true)[0];
            bool changeNonBotTP = check.Checked;

            double lowestBuyTP = double.MaxValue;
            double highestSellTP = double.MinValue;

            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBotTP))
                {
                    if (p.TradeType == TradeType.Buy && p.TakeProfit != null && p.TakeProfit < lowestBuyTP) lowestBuyTP = (double)p.TakeProfit;
                    if (p.TradeType == TradeType.Sell && p.TakeProfit != null && p.TakeProfit > highestSellTP) highestSellTP = (double)p.TakeProfit;
                }
            }
            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBotTP))
                {
                    if (p.TradeType == TradeType.Buy)
                    {
                        if (lowestBuyTP < p.TakeProfit)
                            p.ModifyTakeProfitPrice(lowestBuyTP);
                    }
                    else
                    {
                        if (highestSellTP > p.TakeProfit)
                            p.ModifyTakeProfitPrice(highestSellTP);
                    }
                }
            }
        }

        public void HedgeAll()
        {
            string tLabel = _mainForm.Controls.Find("txtBotLabel", true)[0].Text;
            System.Windows.Forms.CheckBox check = (System.Windows.Forms.CheckBox)_mainForm.Controls.Find("checkBoxManageAllPos", true)[0];
            bool changeNonBot = check.Checked;

            double netUnits = 0;
            int numPos = 0;

            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBot))
                {
                    if (p.TradeType == TradeType.Buy) netUnits += p.VolumeInUnits;
                    if (p.TradeType == TradeType.Sell) netUnits -= p.VolumeInUnits;
                    numPos++;
                }
            }
            
            if (numPos == 0) 
            {
                Print("Nothing to Hedge - no positions.");
                return;
            }

            TradeType tradeType = TradeType.Sell;
            if (netUnits < 0)
            {
                tradeType = TradeType.Buy;
                netUnits = netUnits * -1;
            }
            
            Print(string.Format("Open Hedging position of Size {0}", netUnits));
            ExecuteMarketOrderAsync(tradeType, Symbol.Name, netUnits, tLabel);

            // remove any stops & targets from positions
            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || changeNonBot))
                {
                    if (p.HasTrailingStop) p.ModifyTrailingStop(false);
                    p.ModifyTakeProfitPips(0);
                    p.ModifyStopLossPips(0);
                }
            }

        }

        protected override void OnStop()
        {
            _mainForm.Close();
            _mainForm.Dispose();
        }

    }
}

