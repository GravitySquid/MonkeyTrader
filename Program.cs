//
// +----------------------------------------------------------+
// + Author: J Bannerman aka GravitySquid aka ExcitableMonkey
// + Date: Jan 2022
// + Desc:
// +    Trading Panel for my personal use
// +    - Pos size risk based w/Max
// +    - Split Positions with step Targets, auto BE
// +    - Manual BE's, Trails etc.
// +    Work in progress
// +----------------------------------------------------------+
//

using cAlgo.API;
using System.Threading;

namespace cAlgo.Robots
{
    [Robot(TimeZone = TimeZones.UTC, AccessRights = AccessRights.FullAccess)]
    public class MonkeyTrader : Robot
    {
        private Form1 _mainForm;

        protected override void OnStart()
        {
            //System.Diagnostics.Debugger.Launch();
            Timer.Start(5);

            // You can pass your indicator/cBot to form and start interacting with it via form controls
            _mainForm = new Form1(this);

            // You have to create a new thread to show the form, so it will not block the cBot main thread
            var staThread = new Thread(() => _mainForm.ShowDialog());

            // The form must be executed on a STA thread
            staThread.SetApartmentState(ApartmentState.STA);

            staThread.Start();
        }

        protected override void OnTick()
        {
            string tLabel = _mainForm.Controls.Find("txtBotLabel", true)[0].Text;
            double gain = 0;
            foreach (Position p in Positions)
            {
                //if (p.SymbolName == Symbol.Name && p.Label == tLabel)
                if (p.SymbolName == Symbol.Name)
                    gain += p.NetProfit;
            }
            // Update Status text & Colour
            double perc = Math.Round(gain / this.Account.Balance, 4);
            _mainForm.Controls.Find("txtStatus", true)[0].Text = gain.ToString("C") + " / " + perc.ToString("P");
            _mainForm.Controls.Find("txtStatus", true)[0].BackColor = Form1.DefaultBackColor;
            if (gain > 0)
                _mainForm.Controls.Find("txtStatus", true)[0].BackColor = System.Drawing.Color.Aquamarine;
            if (gain < 0)
                _mainForm.Controls.Find("txtStatus", true)[0].BackColor = System.Drawing.Color.OrangeRed;
        }

        protected override void OnTimer()
        {
            string tLabel = _mainForm.Controls.Find("txtBotLabel", true)[0].Text;
            double tpPips = (double) ((NumericUpDown)_mainForm.Controls.Find("nudTPStep", true)[0]).Value;
            double paddingPips = (double)((NumericUpDown)_mainForm.Controls.Find("nudPipsPadding", true)[0]).Value;
            //Print("Timer - got robot label as {0} tpPips as {1} paddingPips {2}",tLabel, tpPips, paddingPips);

            bool changeNonBotSL = false;
            double gain = 0;
            foreach (Position p in Positions)
            {
                if (p.SymbolName == Symbol.Name && p.Label == tLabel)
                {
                    gain += p.NetProfit;
                }
                if (p.SymbolName == Symbol.Name && (p.Label == tLabel || (p.Label.Length == 0 && changeNonBotSL)))
                {
                    if (p.Pips > 0)
                    {
                        int TPs = (int)Math.Truncate(p.Pips / tpPips);

                        if (TPs >= 1)
                        {
                            double newSL = ((TPs - 1) * tpPips) + paddingPips;
                            // set stop loss to prev target plus padding
                            double newSLPrice = 0;

                            if (p.TradeType == TradeType.Buy)
                            {
                                newSLPrice = Math.Round((double)p.EntryPrice + (newSL * Symbol.PipSize), Symbol.Digits);
                                if (newSLPrice > p.StopLoss)
                                    p.ModifyStopLossPrice(newSLPrice);
                            }
                            else
                            {
                                newSLPrice = Math.Round((double)p.EntryPrice - (newSL * Symbol.PipSize), Symbol.Digits);
                                if (newSLPrice < p.StopLoss)
                                    p.ModifyStopLossPrice(newSLPrice);
                            }
                        }
                    }
                }
            }
            // Update Status text & Colour
            double perc = Math.Round(gain / this.Account.Balance,2);
            _mainForm.Controls.Find("txtStatus", true)[0].Text = gain.ToString("C") + " / " + perc.ToString("P");
            _mainForm.Controls.Find("txtStatus", true)[0].BackColor = Form1.DefaultBackColor;
            if (gain > 0)
            _mainForm.Controls.Find("txtStatus", true)[0].BackColor = System.Drawing.Color.Aquamarine;
            if (gain < 0)
                _mainForm.Controls.Find("txtStatus", true)[0].BackColor = System.Drawing.Color.OrangeRed;

        }


        protected override void OnStop()
        {
            _mainForm.Close();
            _mainForm.Dispose();
        }

    }
}
