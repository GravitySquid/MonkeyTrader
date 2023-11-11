using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cAlgo.API;
using System.Resources;
using System.Xml;
using System.Runtime.CompilerServices;

namespace cAlgo
{
    public partial class Form1 : Form
    {
        private readonly cAlgo.Robots.MonkeyTrader _robot;
        private string _liveOrBacktesting = "";
        private readonly string[] _trailValues = new string[] { "No Trail", "Regular Trail", "Candle Bars Trail", "Parabolic SAR Trail", "EMA 13 Trail", "EMA 20 Trail", "EMA 50 Trail", "EMA 100 Trail", "EMA 200 Trail" };
        private bool _displayingPreview = false;
        private TradeType _previewTradeType;

        public Form1(cAlgo.Robots.MonkeyTrader robot)
        {
            InitializeComponent();

            _robot = robot;

            //Set Default values
            richTextBoxAboutInfo.Text = this.Text + "\r\nCopyright (c) 2023 Justin Bannerman\r\n" + _robot.BotVersion + " (Expires " + cAlgo.Robots.MonkeyTrader.Expirydate + ")";
            richTextBoxAboutInfo.Text += "\r\n\r\nYou are responsible for testing this tool using Backtesting and/or a Demo account to see if it is suitable for your needs or if it has any flaws or limitations that may impact you, BEFORE using it on a Live trading acount.";
            richTextBoxAboutInfo.Text += "\r\n\r\nEULA - End User License Agreement\r\nBEFORE USING OUR SOFTWARE PRODUCTS, WE STRONGLY ADVISE AND ASK YOU TO READ CAREFULLY THIS END-USER LICENSE AGREEMENT. \r\nThis End-User License Agreement (hereinafter referred to as \"EULA\") is a legal agreement between either an individual or a legal entity (hereinafter referred to as “you” or “user” or \"customer\"), and Justin Bannerman (“We”, “Our”, or “Us”) for the software, components, source code, documentation, demos, or other materials related to the Monkey Trader product line, in the form of software, add-ins, documentation and other materials (hereinafter referred to as \"SOFTWARE PRODUCT\") contained in this distribution.\r\n\r\nBy purchasing the license, installing, copying, or otherwise using the SOFTWARE PRODUCT, you agree: (a) that you have read this EULA; (b) that you understand all its terms and provisions; (c) that you agree to be bound by the terms of this EULA. If you do not agree to any part of the terms of this EULA, DO NOT INSTALL, COPY, USE, EVALUATE, OR REPLICATE IN ANY MANNER, ANY PART, FILE OR PORTION OF THE SOFTWARE PRODUCT.\r\nTHE SOFTWARE PRODUCT IS LICENSED, NOT SOLD.\r\n\r\n\r\n1. GRANT OF LICENSE\r\nSubject to your continued compliance with this EULA and payment of the applicable license fees, Justin Bannerman grants you a non-exclusive, non-sublicensed, non-transferable and limited license to install and use the SOFTWARE PRODUCT: (a) during the term of such license, (b) within the scope of the License Type described in Section 2, (c) on the permitted number of computers, (d) in a manner specified in the terms of this EULA.\r\n \r\n2. LICENSE TYPES\r\n2.1 Full license (Perpetual license)\r\n\r\nAny SOFTWARE PRODUCT is available on a “per-user” basis. You may install, activate, operate, and use the SOFTWARE PRODUCT on TWO (2) computers per license purchased by you. While making an order in frames of the current EULA, you can purchase the number of licenses you require.\r\n\r\nThe term \"perpetual license\" refers only to certain products where this is applicable, therefore not to the products and services for which it is necessary to renew a time subscription or for products and services for which we give an expiry date. We guarantee that Our products purchased with a perpetual license can be used for an indefinite time, but it does not guarantee that for these products updates or error corrections will be issued for an indefinite time.\r\nEven for Our products whose license is defined as perpetual, it may still be necessary to subscribe to specific and expiring plans to receive updates, bug fixes and technical support.\r\n\r\n2.2 Evaluation (trial) use of license\r\n\r\nIf you received this product for free or for evaluation purposes only, you may install and use ONE copy of the SOFTWARE PRODUCT for a period from up to 14 calendar days from the date of installation (hereinafter referred to as \"Evaluation Period”). The Evaluation Period may be extended by a written agreement between you and Us.\r\n\r\nUpon expiration of the Evaluation Period, you have the following options:\r\n\r\n(a) Purchase a LICENSE to continue using the SOFTWARE PRODUCT.\r\n\r\n(b) Uninstall the SOFTWARE PRODUCT from your computer and delete all its copies.\r\n\r\nYou have the right to use the SOFTWARE PRODUCT for purposes related to your commercial activities during the Evaluation Period.\r\n\r\n2.3 Free license\r\n\r\nIf you download the SOFTWARE PRODUCT that is distributed free of charge, you may install and use the SOFTWARE PRODUCT on an unlimited number of computers.\r\nYou have the right to use the SOFTWARE PRODUCT for purposes related to your commercial activities while using the free version of the SOFTWARE PRODUCT.\r\n\r\nYou may redistribute the free version of the SOFTWARE PRODUCT only in the form of the original distribution package.\r\n\r\nProducts provided in the freeware version may be subjected to specific limitations, related to the number of available features, the number of usage hours, or limited by an expiry date.\r\n\r\n3. UPDATES & DEFECTS\r\n\r\nThe Licensor grants you a licence of the Software in its current version only. New features are added at the sole discretion of the Licensor. While minor updates may be made available free of charge, nothing in this licence agreement guarantees such updates the Licensor reserves the right to charge for major updates. \r\n\r\nNothing in this agreement constitutes a promise about future features or versions of the Software.\r\n\r\nYou are responsible for checking that the Software will run on your operating system or trading platform and that any software that you use on that operating system or trading platform will not affect the functionality of the Software.\r\n\r\nYou are responsible for testing this tool using back-testing and/or a demo trading account to see if it is suitable for your needs or if it has any flaws or limitations that may impact you, BEFORE using it on a live trading account.\r\n\r\n4. DELIVERY AND PAYMENT TERMS\r\n\r\nAny SOFTWARE PRODUCT is to be delivered to you via electronic delivery. The license is deemed to be provided by us at the moment when the SOFTWARE PRODUCT is made available for download by us.\r\n\r\nIf you intend to use the SOFTWARE PRODUCT, you may be obliged to pay a license fee. \r\n\r\nYou acknowledge and agree that we may change the license fees at any time and without prior notice.\r\n \r\n5. TECHNICAL SUPPORT\r\n\r\nWhile using the SOFTWARE PRODUCT, you may request from Justin Bannerman technical assistance with the SOFTWARE PRODUCT and consultation regarding technical and other issues over a support forum or other available channels. Technical assistance may include problem determination and reasonable problem resolution. We shall use Our reasonable endeavours to provide you with high-quality and timely support but We  do not guarantee that your queries or problems will be fixed or solved. \r\nIf the SOFTWARE PRODUCT was received for free, we may, at Our sole discretion, choose whether or not to provide technical assistance.\r\n\r\n6. COPYRIGHT AND INTELLECTUAL PROPERTY OWNERSHIP\r\n\r\nAll titles and copyrights for and to the SOFTWARE PRODUCT, including but not limited to any copywritten images, demos, source code, intermediate files, packages, animations, video, audio and text incorporated into the SOFTWARE PRODUCT, the accompanying printed materials, and any copies of the SOFTWARE PRODUCT are the intellectual property of and are owned by Justin Bannerman.\r\n\r\nALL RIGHTS, INCLUDING, BUT NOT LIMITED TO, INTELLECTUAL PROPERTY RIGHTS FOR THE SOFTWARE PRODUCT YOU ARE NOT EXPRESSLY GRANTED HEREIN, ARE RESERVED BY Justin Bannerman.\r\n\r\nThe structure, organization, and source code of the SOFTWARE PRODUCT are valuable trade secrets and confidential information of Justin Bannerman and you must keep it strictly confidential and not disclose it to any third party.\r\n\r\nThe SOFTWARE PRODUCT is protected by the applicable and international laws, including but not limited to international copyright treaties.\r\n\r\nYou are entitled to use the SOFTWARE PRODUCT only in the manner stipulated in this EULA, in compliance with all applicable laws of the jurisdiction where you use the SOFTWARE PRODUCT and International Treaties, including, but not limited to, restrictions concerning privacy, copyright, and other intellectual property rights.\r\n\r\nYou shall make best endeavours to protect the intellectual property rights for the SOFTWARE PRODUCT that is not to be less as stipulated in the provisions of the applicable law and International Treaties whichever operates to best protect the interests of Justin Bannerman.\r\n\r\n\r\n6.1 LIMITATIONS ON REVERSE ENGINEERING, DECOMPILATION, AND DISASSEMBLATION\r\n\r\nYou must neither reverse engineer, adapt, modify, translate, decompile, create derivative works, disassemble, decrypt nor commit other illegal actions to the source code, basic ideas, algorithms, or file formats of the SOFTWARE PRODUCT. You must not remove any proprietary notices, labels, trademarks or other identifying marks on the SOFTWARE PRODUCT.\r\n\r\nFor every individual breach of Our intellectual property rights and discloser of confidential information, including, but not limited to, the attempt to adapt, modify, translate, decompile, create derivative works, disassemble, decrypt or attempt to commit other illegal actions to the source code, basic ideas, algorithms, file formats of the SOFTWARE PRODUCT or the attempt to remove any proprietary notices, labels, trademarks or other identifying marks on the SOFTWARE PRODUCT, you must indemnify damages and compensate all direct and indirect damages to Us.\r\n\r\nIf you purchase the SOFTWARE PRODUCT with the intent to reverse engineer, decompile, create derivative works, or the exploit and unauthorized transfer of any intellectual property and trade secrets, including any exposed methods or source code where provided, no licensed right of use shall exist and any products created as a result shall be judged illegal by definition. Any sale or resale of the intellectual property or created derivatives so obtained will be prosecuted to the fullest extent of all local and international laws.\r\n\r\n\r\n7. REDISTRIBUTION\r\n\r\nYou are NOT entitled to resell or redistribute in any way the SOFTWARE PRODUCT unless you are explicitly authorized by Us as a reseller.\r\n\r\nAuthorized resellers may redistribute the SOFTWARE PRODUCT only in the form of the original distribution package unless otherwise agreed with Us.\r\n\r\n\r\n8. PROHIBITION TO TRANSFER THE SOFTWARE PRODUCT\r\n\r\nYou are not entitled to sell and/or resell, lease, lend, transmit or provide access to the SOFTWARE PRODUCT to any third party, or otherwise transfer permanently or temporarily the SOFTWARE PRODUCT and/or an additional copy of the SOFTWARE PRODUCT. You are also not entitled to transfer permanently or temporarily ANY rights obtained under this EULA to any individual or legal entity without prior written permission from Us. Moreover, you warrant that you make your best endeavours to avoid unauthorized third parties' use of the SOFTWARE PRODUCT.\r\n\r\n\r\n9. RIGHT TO DISCONTINUE\r\n\r\nWe reserve the right to discontinue the SOFTWARE PRODUCT, its related services or its specific features, whether offered as a standalone product, a service or solely as a component, at any time and at our sole discretion. However, We will make our best endeavours to provide support for a period of 3 months after the date of discontinuance.\r\n\r\n\r\n10. DISCLAIMER OF WARRANTY\r\n\r\nJustin Bannerman EXPRESSLY DISCLAIMS ANY WARRANTY FOR SOFTWARE PRODUCTS. THE SOFTWARE PRODUCT AND ANY RELATED DOCUMENTATION ARE PROVIDED \"AS IS\" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING, WITHOUT LIMITATION, THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, OR NONINFRINGEMENT. WE DO NOT GUARANTEE THAT THE SOFTWARE PRODUCT WILL MEET YOUR EXPECTATIONS OR REQUIREMENTS. WE DO NOT GUARANTEE THAT THE SOFTWARE PRODUCT IS ERROR-FREE. WE DO NOT WARRANT, GUARANTEE, OR MAKE ANY REPRESENTATIONS REGARDING THE USE, OR THE RESULTS OF THE USE, OF THE SOFTWARE PRODUCT IN TERMS OF CORRECTNESS, ACCURACY, RELIABILITY, OR OTHERWISE. THE ENTIRE RISK ARISING OUT OF THE USE OR PERFORMANCE OF THE SOFTWARE PRODUCT REMAINS WITH YOU. NO ORAL OR WRITTEN INFORMATION OR ADVICE GIVEN BY US SHALL CREATE A WARRANTY OR IN ANY WAY INCREASE THE SCOPE OF THIS WARRANTY.\r\n\r\n11. LIMITATION OF LIABILITY\r\n\r\nIn no event shall Justin Bannerman and its partners, resellers, agents and distributors be liable for any consequential, indirect, special, punitive or incidental damages arising from or related to the EULA, including but not limited, to (a) any loss of profits, business, contracts, anticipated savings, goodwill, or revenue; or (b) any loss, or corruption, of software or data; or (c) any loss of use of hardware, software or data.\r\n\r\n\r\n12. TERMINATION\r\n\r\nWithout prejudice to any other rights or remedies, Justin Bannerman will terminate this EULA upon your failure to comply with the terms and conditions of this EULA. In such events, you must delete all copies of the SOFTWARE PRODUCT and all of its component parts including any related documentation and must remove ANY and ALL use of Our intellectual property from any applications distributed by you, whether in native, altered or compiled states.\r\n\r\nAnyway, if EULA is terminated, all fees you paid for the SOFTWARE PRODUCT shall not be refunded.\r\n\r\n\r\n13. CHANGES\r\n\r\nFrom time to time, We may change the terms and provisions of the EULA. When these changes are made, We will make a new copy of the EULA available on our websites or provided with our product updates.\r\n\r\nYou understand and agree that if you use the SOFTWARE PRODUCT after the date on which the EULA has been changed, We will treat your use as acceptance of the updated EULA.\r\n\r\n\r\n\r\n14. GENERAL PROVISIONS\r\n\r\n14.1. Governing law\r\n\r\nThis EULA shall be interpreted in accordance with the laws of the country of purchase of the SOFTWARE PRODUCT and with New South Wales, Australian and International Laws, whichever operates to best protect the interests of Us.\r\n\r\n14.2. Severability\r\n\r\nIf any provision or part of any provision in this EULA is found to be illegal, invalid or unenforceable for any reason then this EULA will be anyway effective entirely, without the mentioned provision only.\r\n\r\n14.3. Dispute resolution\r\n\r\nAny dispute arising out of or relating to this EULA shall be resolved through negotiations. If the matter is not resolved by negotiations within 30 days, the dispute may be submitted to the corresponding court of the applicable law.\r\n\r\n\r\n15. PRIVACY POLICY\r\n\r\n15.1. Type of data that may be collected, processed, and used during your use of the SOFTWARE PRODUCT.\r\n\r\nWe do not collect any information of your activity or use of the SOFTWARE PRODUCT.\r\n\r\nFor the proper conduction of the transaction when purchasing a license, the Personal data of an individual can be collected by resellers or payment systems. We do not obtain or otherwise acquire the Personal data of the individual. \r\n\r\n\r\n\r\n16. THIRD-PARTY PROGRAMS\r\n\r\nThe SOFTWARE PRODUCT may contain third-party software programs (\"Third Party Programs\") that are available under open source or free software licenses and distributed, embedded or bundled with the SOFTWARE PRODUCT or recommended in connection with its installation and use. This License Agreement does not alter any rights or obligations you may have under those open-source or free software licenses. Notwithstanding anything to the contrary contained in such licenses, the disclaimer of warranties and the limitation of liability provisions in this License Agreement shall apply to such Third Party Programs.\r\n\r\n\r\n17. REFUND POLICY\r\n\r\nWe make available to all users free versions and trial versions complete with all the features of our products and encourage users to try them before making a purchase. In the event that the trial period was not sufficient to evaluate the products, We may grant an additional trial period upon the explicit request of the user. If the customer decides to request a refund, this can be done based on the following requirements: The refund can be requested up to a maximum of 14 days after the date of the order.\r\n\r\n18. LIMITATION OF LIABILITY.\r\n\r\nUnder no circumstances shall We be held liable for the malfunctioning of the products if this is caused by overloads or interruptions to telephone lines, the power supply, or national or international grids.\r\nThe services related to data transfer are subject to temporary disruptions. Under no circumstances shall We be held liable for service interruptions during data transfer activities.\r\nNo compensation may be claimed against Us for any direct and/or indirect damages caused by the use or non-use of the service.\r\n\r\n\r\n19. FORCE MAJEURE, CATASTROPHIC EVENTS AND ACTS OF GOD\r\n\r\nNeither party shall be held liable for faults attributable to causes related to fire, explosion, earthquake, volcanic eruptions, landslides, cyclones, storms, floods, hurricanes, avalanches, war, insurrection, riots, strikes, or any other unpredictable and exceptional causes which prevent the provision of the service.\r\n\r\n";

            if (_robot.IsBacktesting)
                _liveOrBacktesting = " - BACKTEST";
            this.Text += " - " + _robot.Symbol.Name + _liveOrBacktesting;
            txtBotLabel.Text = "MT-" + _robot.Symbol.Name + "-001";
            nudMaxRisk.Value = 1.0M;
            this.cboxTrailMethod.Text = _trailValues[0];
            checkBoxManageAllPos.Checked = _robot.ManageAllPos;
            checkBoxMustPreview.Checked = _robot.MustPreview;
            checkBoxShowDollars.Checked = _robot.ShowDollars;
            checkBoxAutoBreakEven.Checked = _robot.AutoBE;
            nudMaxRisk.Value = (decimal)_robot.MaxRisk;

            // adjust min & max when not trading currencies
            if ((decimal)_robot.Symbol.VolumeInUnitsMin < 1000)
            {
                nudMaxUnits.Minimum = (decimal)_robot.Symbol.VolumeInUnitsMin;
                nudMaxUnits.Increment = (decimal)_robot.Symbol.VolumeInUnitsMin;
            }

            nudNumPositions.Value = _robot.NumPositions;

            nudSL.Value = Math.Max(nudSL.Minimum, (decimal)Math.Ceiling(Math.Abs(_robot.Chart.Bars.HighPrices.Maximum(10) - _robot.Chart.Bars.LowPrices.Minimum(10)) / _robot.Symbol.PipSize));
            nudTPStep.Value = nudSL.Value;
            nubBEAfter.Value = Math.Max(nubBEAfter.Minimum, (decimal)Math.Round(nudSL.Value / 2, 1));
            double spreadPips = _robot.Symbol.Spread / _robot.Symbol.PipSize;
            if (spreadPips > 1)
                nudPipsPadding.Value = (decimal)Math.Ceiling(spreadPips * 1.25);
            else
                nudPipsPadding.Value = (decimal)_robot.BEPadding;
            nudTrailPaddingPips.Value = (decimal)_robot.TrailPadding;
            nudCloseOnGainPerc.Value = (decimal)_robot.GainClosePerc;

            // Maximum Units
            if (_robot.MaxVolume < _robot.Symbol.VolumeInUnitsMin || _robot.MaxVolume > _robot.Symbol.VolumeInUnitsMax)
                nudMaxUnits.Value = (decimal)CalculatePositionSize(1, (double)nudSL.Value, (double)nudMaxRisk.Value * 2, _robot.Symbol.VolumeInUnitsMin * 50);
            else
                nudMaxUnits.Value = (decimal)_robot.Symbol.NormalizeVolumeInUnits(_robot.MaxVolume);

            RefreshPositionUnits();
            this.ActiveControl = nudMaxRisk;
            RefreshTrail();
            FormClosed += MainForm_FormClosed;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.Stop(); });
        }

        private void btnStopBot_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.Stop(); });
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                if (!checkBoxMustPreview.Checked || _robot.Chart.FindObject("PreviewOrderEntry") != null)
                    ExecuteOrder(TradeType.Sell);
            });
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                if (!checkBoxMustPreview.Checked || _robot.Chart.FindObject("PreviewOrderEntry") != null)
                    ExecuteOrder(TradeType.Buy);
            });
        }
        private void ExecuteOrder(TradeType tradeType)
        {
            double numTargets = (double)nudNumPositions.Value;
            double stopLossPips = (double)nudSL.Value;
            double takeProfitPips = (double)nudTPStep.Value;
            double risk = (double)nudMaxRisk.Value;
            double maxUnits = (double)nudMaxUnits.Value;

            double volume = CalculatePositionSize((int)numTargets, stopLossPips, risk, maxUnits);
            for (int i = 1; i <= numTargets; i++)
            {
                double tp = (takeProfitPips * i);
                _robot.Print(string.Format("Open position with: Size: {0}, StopLossPipsParameter: {1}, TakeProfitPipsParameter: {2}", volume, stopLossPips, tp));
                _robot.ExecuteMarketOrderAsync(tradeType, _robot.Symbol.Name, volume, txtBotLabel.Text, stopLossPips, tp);
            }
            RefreshTrail();
            RemovePreview();
        }

        private double CalculatePositionSize(int numTargets, double stopLossPips, double riskPerc, double maxUnits)
        {
            // Need latest cTrader.Automate dependency updates

            double positionSizeForRisk = _robot.Symbol.VolumeForProportionalRisk(ProportionalAmountType.Balance, riskPerc, stopLossPips);

            // split by number of positions if taking multiple positions at with different targets
            double singlePosSize = positionSizeForRisk / numTargets;
            // round to volume units accepted for currency pair
            double volume = _robot.Symbol.NormalizeVolumeInUnits(singlePosSize, RoundingMode.Down);
            // same for the users chosen maximum units to trade
            double maxUnitsSinglePos = _robot.Symbol.NormalizeVolumeInUnits((maxUnits / numTargets), RoundingMode.Down);
            if (volume > maxUnitsSinglePos)
                volume = maxUnitsSinglePos;
            return volume;
        }

        private void BtnBreakEven_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.MoveAllBreakEven(); });
        }

        private void BtnSyncSL_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.SyncSL(); });
        }

        private void btnCloseSells_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {

                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || checkBoxManageAllPos.Checked) && position.TradeType == TradeType.Sell)
                        _robot.ClosePositionAsync(position);
                };
            });
        }

        private void btnCloseBuys_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {

                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || checkBoxManageAllPos.Checked) && position.TradeType == TradeType.Buy)
                        _robot.ClosePositionAsync(position);
                };
            });

        }

        private void BtnCloseAll_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || checkBoxManageAllPos.Checked))
                        _robot.ClosePositionAsync(position);
                };
            });
        }

        private void previewSell_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                if (_displayingPreview) RemovePreview();
                else PreviewOrder(TradeType.Sell);
            });
        }

        private void previewBuy_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                if (_displayingPreview) RemovePreview();
                else PreviewOrder(TradeType.Buy);
            });
        }


        private void RemovePreview()
        {
            double numTargets = (double)nudNumPositions.Value;

            if (_robot.Chart.FindObject("PreviewOrderEntry") != null)
            {
                _robot.Chart.RemoveObject("PreviewOrderEntryRect");
                _robot.Chart.RemoveObject("PreviewOrderTPRect");
                _robot.Chart.RemoveObject("PreviewOrderEntry");
                _robot.Chart.RemoveObject("PreviewOrderSL");
                for (int i = 1; i <= numTargets + 10; i++)
                {
                    _robot.Chart.RemoveObject("PreviewOrderTP" + i.ToString());
                }
                txtBoxVolumeInUnits.Text = "";
                _displayingPreview = false;
            }
        }
        private void PreviewOrder(TradeType tradeType)
        {
            double numTargets = (double)nudNumPositions.Value;
            double stopLossPips = (double)nudSL.Value;
            double takeProfitPips = (double)nudTPStep.Value;
            double risk = (double)nudMaxRisk.Value;
            double maxUnits = (double)nudMaxUnits.Value;
            double volume = CalculatePositionSize((int)numTargets, stopLossPips, risk, maxUnits);

            RemovePreview();

            //double positionSizeForRisk = (_robot.Account.Balance * risk / 100) / (stopLossPips * _robot.Symbol.PipValue);
            //double singlePosSize = positionSizeForRisk / numTargets;
            //double maxUnitsSinglePos = _robot.Symbol.NormalizeVolumeInUnits((maxUnits / numTargets), RoundingMode.Down);
            int barIndexStart = _robot.Chart.Bars.Count - 15;
            int barIndexEnd = _robot.Chart.Bars.Count;
            double currentPrice = 0;
            double currentSL = 0;
            double currentTP = 0;
            if (tradeType == TradeType.Sell)
            {
                currentPrice = _robot.Chart.Symbol.Bid;
                currentSL = currentPrice + (stopLossPips * _robot.Symbol.PipSize);
                currentTP = currentPrice - ((takeProfitPips * numTargets) * _robot.Symbol.PipSize);
            }
            else
            {
                currentPrice = _robot.Chart.Symbol.Ask;
                currentSL = currentPrice - (stopLossPips * _robot.Symbol.PipSize);
                currentTP = currentPrice + ((takeProfitPips * numTargets) * _robot.Symbol.PipSize);
            }

            _robot.Chart.DrawRectangle("PreviewOrderEntryRect", barIndexStart, currentPrice, barIndexEnd, currentSL, API.Color.FromArgb(80, 255, 0, 0), 1).IsFilled = true;
            _robot.Chart.DrawRectangle("PreviewOrderTPRect", barIndexStart, currentPrice, barIndexEnd, currentTP, API.Color.FromArgb(80, 0, 200, 50), 1).IsFilled = true;
            _robot.Chart.DrawTrendLine("PreviewOrderEntry", barIndexStart, currentPrice, barIndexEnd, currentPrice, "Gold", 2);
            _robot.Chart.DrawTrendLine("PreviewOrderSL", barIndexStart, currentSL, barIndexEnd, currentSL, "Red", 2);

            for (int i = 1; i <= numTargets; i++)
            {
                double tp = (takeProfitPips * i);
                if (tradeType == TradeType.Sell)
                    currentTP = currentPrice - (tp * _robot.Symbol.PipSize);
                else
                    currentTP = currentPrice + (tp * _robot.Symbol.PipSize);
                _robot.Chart.DrawTrendLine("PreviewOrderTP" + i.ToString(), barIndexStart, currentTP, barIndexEnd, currentTP, "Lime", 2);
            }
            _displayingPreview = true;
            _previewTradeType = tradeType;
            txtBoxVolumeInUnits.Text = volume.ToString();
        }

        private void btnResetSL_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                double stopLossPips = (double)nudSL.Value;
                double takeProfitPips = (double)nudTPStep.Value;
                double newSL;

                RefreshTrail();

                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || checkBoxManageAllPos.Checked))
                    {
                        if (position.TradeType == TradeType.Sell)
                        {
                            newSL = position.EntryPrice + (stopLossPips * _robot.Symbol.PipSize);
                        }
                        else
                        {
                            newSL = position.EntryPrice - (stopLossPips * _robot.Symbol.PipSize);
                        }
                        _robot.ModifyPositionAsync(position, newSL, position.TakeProfit);
                    }
                };
            });
        }

        private void refreshBreakEven()
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.SetBreakEvenMode(checkBoxAutoBreakEven.Checked); });
        }

        private void RefreshTrail()
        {
            int candlestoTrail = 0;
            cAlgo.Robots.MonkeyTrader.TrailType trailType = Robots.MonkeyTrader.TrailType.None;
            switch (cboxTrailMethod.SelectedIndex)
            {
                case 0:  //"No Trail":
                    trailType = Robots.MonkeyTrader.TrailType.None;
                    break;
                case 1: // "Regular Trail":
                    trailType = Robots.MonkeyTrader.TrailType.Regular;
                    break;
                case 2: // "Candle Bars":
                    trailType = Robots.MonkeyTrader.TrailType.Candle;
                    candlestoTrail = (int)nudCandleTrail.Value;
                    break;
                case 3: // "Parabolic SAR":
                    trailType = Robots.MonkeyTrader.TrailType.SAR;
                    break;
                case 4: // "Target Step Trail":
                    trailType = Robots.MonkeyTrader.TrailType.TargetStep;
                    break;
                case 5: // "EMA 13":
                    trailType = Robots.MonkeyTrader.TrailType.EMA13;
                    break;
                case 6: // "EMA 20":
                    trailType = Robots.MonkeyTrader.TrailType.EMA20;
                    break;
                case 7: // "EMA 50":
                    trailType = Robots.MonkeyTrader.TrailType.EMA50;
                    break;
                case 8: // "EMA 100":
                    trailType = Robots.MonkeyTrader.TrailType.EMA100;
                    break;
                case 9: // "EMA 200":
                    trailType = Robots.MonkeyTrader.TrailType.EMA200;
                    break;
            }
            bool trailAfterBE = checkBoxTrailAfterBreakEven.Checked;
            _robot.BeginInvokeOnMainThread(() => { _robot.SetTrail(trailType, candlestoTrail, trailAfterBE); });
            refreshBreakEven();
        }

        private void RefreshPositionUnits()
        {
            double numTargets = (double)nudNumPositions.Value;
            double stopLossPips = (double)nudSL.Value;
            double takeProfitPips = (double)nudTPStep.Value;
            double risk = (double)nudMaxRisk.Value;
            double maxUnits = (double)nudMaxUnits.Value;
            double volume = CalculatePositionSize((int)numTargets, stopLossPips, risk, maxUnits);
            txtBoxVolumeInUnits.Text = volume.ToString();
        }
        private void nubBEAfter_ValueChanged(object sender, EventArgs e)
        {
            refreshBreakEven();
        }

        private void cboxTrailMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTrail();
        }

        private void nudCandleTrail_ValueChanged(object sender, EventArgs e)
        {
            RefreshTrail();
        }

        private void nudNumPositions_ValueChanged(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                if (_displayingPreview) PreviewOrder(_previewTradeType);
                RefreshPositionUnits();
            });
        }

        private void nudSL_ValueChanged(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                if (_displayingPreview) PreviewOrder(_previewTradeType);
                RefreshPositionUnits();
            });
        }

        private void nudTPStep_ValueChanged(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                if (_displayingPreview) PreviewOrder(_previewTradeType);
            });
        }

        private void nudMaxUnits_ValueChanged(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                RefreshPositionUnits();
            });
        }

        private void nudMaxRisk_ValueChanged(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                RefreshPositionUnits();
            });
        }

        private void checkBoxTrailAfterBreakEven_CheckedChanged_1(object sender, EventArgs e)
        {
            RefreshTrail();
        }

        private void checkBoxAutoBreakEven_CheckedChanged(object sender, EventArgs e)
        {
            refreshBreakEven();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnResetTP_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                double stopLossPips = (double)nudSL.Value;
                double takeProfitPips = (double)nudTPStep.Value;
                double newTP;

                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || checkBoxManageAllPos.Checked))
                    {
                        if (position.TradeType == TradeType.Sell)
                        {
                            newTP = position.EntryPrice - (takeProfitPips * _robot.Symbol.PipSize);
                        }
                        else
                        {
                            newTP = position.EntryPrice + (takeProfitPips * _robot.Symbol.PipSize);
                        }
                        _robot.ModifyPositionAsync(position, position.StopLoss, newTP);
                    }
                };
            });
        }

        private void btnSyncTP_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.SyncTP(); });
        }

        private void btnHedge_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.HedgeAll(); });
        }

    }
}