using cAlgo.API;
using System.Windows.Forms;

namespace cAlgo
{
    public partial class Form1 : Form
    {
        private readonly Robot _robot;

        public Form1(Robot robot)
        {
            InitializeComponent();

            _robot = robot;

            //Set Default values
            this.Text += " - " + _robot.Symbol.Name;
            txtBotLabel.Text = "MT-" + _robot.Symbol.Name + "-001";
            nudMaxRisk.Value = 1.0M;
            nudMaxUnits.Value = (decimal)_robot.Symbol.VolumeInUnitsMin * 20;
            nudNumPositions.Value = 2;
            nudSL.Value = 8;
            nudTPStep.Value = 8;
            nudPipsPadding.Value = 1;

            FormClosed += MainForm_FormClosed;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.Stop(); });
        }

        private void btnStopBot_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { _robot.Stop(); });
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { ExecuteOrder(TradeType.Sell); });
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { ExecuteOrder(TradeType.Buy); });
        }
        private void ExecuteOrder(TradeType tradeType)
        {
            double numTargets = (double)nudNumPositions.Value;
            double stopLossPips = (double)nudSL.Value;
            double takeProfitPips = (double)nudTPStep.Value;
            double risk = (double)nudMaxRisk.Value;
            double maxUnits = (double)nudMaxUnits.Value;

            double positionSizeForRisk = (_robot.Account.Balance * risk / 100) / (stopLossPips * _robot.Symbol.PipValue);
            double singlePosSize = positionSizeForRisk / numTargets;
            double volume = _robot.Symbol.NormalizeVolumeInUnits(singlePosSize, RoundingMode.Down);
            double maxUnitsSinglePos = _robot.Symbol.NormalizeVolumeInUnits((maxUnits / numTargets), RoundingMode.Down);

            if (volume > maxUnitsSinglePos)
                volume = maxUnitsSinglePos;
            for (int i = 1; i <= numTargets; i++)
            {
                double tp = (takeProfitPips * i) + (double)nudPipsPadding.Value;
                _robot.Print(string.Format("Open position with: Size: {0}, StopLossPipsParameter: {1}, TakeProfitPipsParameter: {2}", volume, stopLossPips, tp));
                _robot.ExecuteMarketOrderAsync(tradeType, _robot.Symbol.Name, volume, txtBotLabel.Text, stopLossPips, tp);
            }
        }

        private void btnBreakEven_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { BEAll(false); });
        }

        private void btnBESync_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() => { BEAll(true); });
        }

        private void BEAll(bool synchBE)
        {
            double bePrice = 0;
            double pipsBE = (double)nudPipsPadding.Value;

            if (synchBE)
            {
                // Find closest position to price
                Position closestPosition = _robot.Positions[1];
                double distance = 0.0;

                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && position.Label == txtBotLabel.Text)
                    {
                        if (position.Pips > 0 && (position.Pips < distance || distance == 0.0))
                        {
                            distance = position.Pips;
                            closestPosition = position;
                        }
                    }
                }
                if (distance > 0)                /* found something */
                {
                    if (closestPosition.TradeType.Equals(TradeType.Buy))
                    {
                        bePrice = closestPosition.EntryPrice + (pipsBE * _robot.Symbol.PipSize);
                        foreach (var position in _robot.Positions)
                        {
                            if (position.SymbolName == _robot.Symbol.Name && position.TradeType.Equals(TradeType.Buy) && (position.Label == txtBotLabel.Text || ManageAllPosCheckBox.Checked))
                            {
                                if (position.Pips > pipsBE)
                                    _robot.ModifyPositionAsync(position, bePrice, position.TakeProfit);
                            }
                        }
                    }
                    else
                    {
                        bePrice = closestPosition.EntryPrice - (pipsBE * _robot.Symbol.PipSize);
                        foreach (var position in _robot.Positions)
                        {
                            if (position.SymbolName == _robot.Symbol.Name && position.TradeType.Equals(TradeType.Sell) && (position.Label == txtBotLabel.Text || ManageAllPosCheckBox.Checked))
                            {
                                if (position.Pips > pipsBE)
                                    _robot.ModifyPositionAsync(position, bePrice, position.TakeProfit);
                            }
                        }

                    }
                }
            }
            else
            {
                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || ManageAllPosCheckBox.Checked))
                    {
                        bePrice = 0;
                        if (position.TradeType.Equals(TradeType.Buy))
                            bePrice = position.EntryPrice + (pipsBE * _robot.Symbol.PipSize);
                        else
                            bePrice = position.EntryPrice - (pipsBE * _robot.Symbol.PipSize);
                        _robot.ModifyPositionAsync(position, bePrice, position.TakeProfit);
                    }
                }
            }
        }

        private void btnTrail_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {
                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || ManageAllPosCheckBox.Checked))
                    {
                        _robot.ModifyPositionAsync(position, position.StopLoss, position.TakeProfit, !position.HasTrailingStop);
                    }
                };
            });
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            _robot.BeginInvokeOnMainThread(() =>
            {

                foreach (var position in _robot.Positions)
                {
                    if (position.SymbolName == _robot.Symbol.Name && (position.Label == txtBotLabel.Text || ManageAllPosCheckBox.Checked))
                        _robot.ClosePositionAsync(position);
                };
            });
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}