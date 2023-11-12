namespace cAlgo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtBoxVolumeInUnits = new TextBox();
            label8 = new Label();
            nudNumPositions = new NumericUpDown();
            label6 = new Label();
            nudTPStep = new NumericUpDown();
            nudMaxUnits = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            nudSL = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            nudMaxRisk = new NumericUpDown();
            groupBox2 = new GroupBox();
            checkBoxTrailAfterBreakEven = new CheckBox();
            nudTrailPaddingPips = new NumericUpDown();
            label9 = new Label();
            nudCandleTrail = new NumericUpDown();
            label10 = new Label();
            nubBEAfter = new NumericUpDown();
            checkBoxAutoBreakEven = new CheckBox();
            nudPipsPadding = new NumericUpDown();
            cboxTrailMethod = new ComboBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            nudCloseOnGainPerc = new NumericUpDown();
            btnHedge = new Button();
            btnSyncTP = new Button();
            btnResetTP = new Button();
            btnCloseAll = new Button();
            btnSyncSL = new Button();
            btnSell = new Button();
            btnResetSL = new Button();
            previewSell = new Button();
            btnBreakEven = new Button();
            previewBuy = new Button();
            btnBuy = new Button();
            checkBoxManageAllPos = new CheckBox();
            label7 = new Label();
            txtBotLabel = new TextBox();
            groupBox5 = new GroupBox();
            txtStatus = new TextBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            checkBoxShowDollars = new CheckBox();
            checkBoxMustPreview = new CheckBox();
            tabPage3 = new TabPage();
            groupBox7 = new GroupBox();
            richTextBoxAboutInfo = new RichTextBox();
            groupBox6 = new GroupBox();
            txtMargin = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTPStep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxRisk).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTrailPaddingPips).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCandleTrail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nubBEAfter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPipsPadding).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCloseOnGainPerc).BeginInit();
            groupBox5.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txtBoxVolumeInUnits);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(nudNumPositions);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nudTPStep);
            groupBox1.Controls.Add(nudMaxUnits);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudSL);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nudMaxRisk);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(6, 5);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(366, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Position";
            // 
            // txtBoxVolumeInUnits
            // 
            txtBoxVolumeInUnits.BackColor = SystemColors.Info;
            txtBoxVolumeInUnits.CausesValidation = false;
            txtBoxVolumeInUnits.Location = new Point(277, 79);
            txtBoxVolumeInUnits.Name = "txtBoxVolumeInUnits";
            txtBoxVolumeInUnits.ReadOnly = true;
            txtBoxVolumeInUnits.Size = new Size(76, 25);
            txtBoxVolumeInUnits.TabIndex = 4;
            txtBoxVolumeInUnits.TabStop = false;
            txtBoxVolumeInUnits.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(187, 79);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 6;
            label8.Text = "Pos Units";
            // 
            // nudNumPositions
            // 
            nudNumPositions.Location = new Point(96, 79);
            nudNumPositions.Margin = new Padding(3, 2, 3, 2);
            nudNumPositions.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumPositions.Name = "nudNumPositions";
            nudNumPositions.Size = new Size(76, 25);
            nudNumPositions.TabIndex = 5;
            nudNumPositions.TextAlign = HorizontalAlignment.Right;
            nudNumPositions.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumPositions.ValueChanged += nudNumPositions_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 81);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 4;
            label6.Text = "Positions #";
            // 
            // nudTPStep
            // 
            nudTPStep.DecimalPlaces = 1;
            nudTPStep.Location = new Point(277, 48);
            nudTPStep.Margin = new Padding(3, 2, 3, 2);
            nudTPStep.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudTPStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTPStep.Name = "nudTPStep";
            nudTPStep.Size = new Size(76, 25);
            nudTPStep.TabIndex = 4;
            nudTPStep.TextAlign = HorizontalAlignment.Right;
            nudTPStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudTPStep.ValueChanged += nudTPStep_ValueChanged;
            // 
            // nudMaxUnits
            // 
            nudMaxUnits.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMaxUnits.Location = new Point(277, 18);
            nudMaxUnits.Margin = new Padding(3, 2, 3, 2);
            nudMaxUnits.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMaxUnits.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMaxUnits.Name = "nudMaxUnits";
            nudMaxUnits.Size = new Size(76, 25);
            nudMaxUnits.TabIndex = 2;
            nudMaxUnits.TextAlign = HorizontalAlignment.Right;
            nudMaxUnits.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMaxUnits.ValueChanged += nudMaxUnits_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 50);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 2;
            label4.Text = "Target Step";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 20);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 2;
            label2.Text = "Max Volume";
            // 
            // nudSL
            // 
            nudSL.DecimalPlaces = 1;
            nudSL.Location = new Point(96, 48);
            nudSL.Margin = new Padding(3, 2, 3, 2);
            nudSL.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSL.Name = "nudSL";
            nudSL.Size = new Size(76, 25);
            nudSL.TabIndex = 3;
            nudSL.TextAlign = HorizontalAlignment.Right;
            nudSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudSL.ValueChanged += nudSL_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 1;
            label1.Text = "Max Risk %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 0;
            label3.Text = "Stop Loss";
            // 
            // nudMaxRisk
            // 
            nudMaxRisk.DecimalPlaces = 2;
            nudMaxRisk.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMaxRisk.Location = new Point(96, 18);
            nudMaxRisk.Margin = new Padding(3, 2, 3, 2);
            nudMaxRisk.Name = "nudMaxRisk";
            nudMaxRisk.Size = new Size(76, 25);
            nudMaxRisk.TabIndex = 1;
            nudMaxRisk.TextAlign = HorizontalAlignment.Right;
            nudMaxRisk.ValueChanged += nudMaxRisk_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxTrailAfterBreakEven);
            groupBox2.Controls.Add(nudTrailPaddingPips);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(nudCandleTrail);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(nubBEAfter);
            groupBox2.Controls.Add(checkBoxAutoBreakEven);
            groupBox2.Controls.Add(nudPipsPadding);
            groupBox2.Controls.Add(cboxTrailMethod);
            groupBox2.Controls.Add(label5);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Location = new Point(6, 121);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(366, 115);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Break Even + Trail";
            // 
            // checkBoxTrailAfterBreakEven
            // 
            checkBoxTrailAfterBreakEven.Checked = true;
            checkBoxTrailAfterBreakEven.CheckState = CheckState.Checked;
            checkBoxTrailAfterBreakEven.Location = new Point(9, 83);
            checkBoxTrailAfterBreakEven.Name = "checkBoxTrailAfterBreakEven";
            checkBoxTrailAfterBreakEven.Size = new Size(154, 20);
            checkBoxTrailAfterBreakEven.TabIndex = 11;
            checkBoxTrailAfterBreakEven.Text = "Only Trail after BE";
            checkBoxTrailAfterBreakEven.CheckedChanged += checkBoxTrailAfterBreakEven_CheckedChanged_1;
            // 
            // nudTrailPaddingPips
            // 
            nudTrailPaddingPips.DecimalPlaces = 1;
            nudTrailPaddingPips.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudTrailPaddingPips.Location = new Point(277, 53);
            nudTrailPaddingPips.Margin = new Padding(3, 2, 3, 2);
            nudTrailPaddingPips.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudTrailPaddingPips.Name = "nudTrailPaddingPips";
            nudTrailPaddingPips.Size = new Size(76, 25);
            nudTrailPaddingPips.TabIndex = 10;
            nudTrailPaddingPips.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(187, 84);
            label9.Name = "label9";
            label9.Size = new Size(105, 17);
            label9.TabIndex = 0;
            label9.Text = "Candle Bars Trail";
            label9.Click += label9_Click;
            // 
            // nudCandleTrail
            // 
            nudCandleTrail.Location = new Point(309, 82);
            nudCandleTrail.Margin = new Padding(3, 2, 3, 2);
            nudCandleTrail.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCandleTrail.Name = "nudCandleTrail";
            nudCandleTrail.Size = new Size(44, 25);
            nudCandleTrail.TabIndex = 12;
            nudCandleTrail.TextAlign = HorizontalAlignment.Right;
            nudCandleTrail.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nudCandleTrail.ValueChanged += nudCandleTrail_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(187, 55);
            label10.Name = "label10";
            label10.Size = new Size(84, 17);
            label10.TabIndex = 15;
            label10.Text = "Trail Padding";
            // 
            // nubBEAfter
            // 
            nubBEAfter.DecimalPlaces = 1;
            nubBEAfter.Location = new Point(106, 22);
            nubBEAfter.Margin = new Padding(3, 2, 3, 2);
            nubBEAfter.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nubBEAfter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nubBEAfter.Name = "nubBEAfter";
            nubBEAfter.Size = new Size(66, 25);
            nubBEAfter.TabIndex = 7;
            nubBEAfter.TextAlign = HorizontalAlignment.Right;
            nubBEAfter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nubBEAfter.ValueChanged += nubBEAfter_ValueChanged;
            // 
            // checkBoxAutoBreakEven
            // 
            checkBoxAutoBreakEven.AutoSize = true;
            checkBoxAutoBreakEven.Checked = true;
            checkBoxAutoBreakEven.CheckState = CheckState.Checked;
            checkBoxAutoBreakEven.Location = new Point(9, 23);
            checkBoxAutoBreakEven.Name = "checkBoxAutoBreakEven";
            checkBoxAutoBreakEven.Size = new Size(101, 21);
            checkBoxAutoBreakEven.TabIndex = 6;
            checkBoxAutoBreakEven.Text = "Auto BE past";
            checkBoxAutoBreakEven.UseVisualStyleBackColor = true;
            checkBoxAutoBreakEven.CheckedChanged += checkBoxAutoBreakEven_CheckedChanged;
            // 
            // nudPipsPadding
            // 
            nudPipsPadding.DecimalPlaces = 1;
            nudPipsPadding.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudPipsPadding.Location = new Point(277, 22);
            nudPipsPadding.Margin = new Padding(3, 2, 3, 2);
            nudPipsPadding.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPipsPadding.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            nudPipsPadding.Name = "nudPipsPadding";
            nudPipsPadding.Size = new Size(76, 25);
            nudPipsPadding.TabIndex = 8;
            nudPipsPadding.TextAlign = HorizontalAlignment.Right;
            nudPipsPadding.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // cboxTrailMethod
            // 
            cboxTrailMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTrailMethod.FormattingEnabled = true;
            cboxTrailMethod.Items.AddRange(new object[] { "No Trail", "Regular Trail", "Candle Bars Trail", "Parabolic SAR Trail", "Target Step Trail", "EMA 13 Trail", "EMA 50 Trail", "EMA 100 Trail", "EMA 200 Trail" });
            cboxTrailMethod.Location = new Point(8, 52);
            cboxTrailMethod.Name = "cboxTrailMethod";
            cboxTrailMethod.Size = new Size(164, 25);
            cboxTrailMethod.TabIndex = 9;
            cboxTrailMethod.SelectedIndexChanged += cboxTrailMethod_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 24);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 4;
            label5.Text = "BE Padding";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(nudCloseOnGainPerc);
            groupBox3.Controls.Add(btnHedge);
            groupBox3.Controls.Add(btnSyncTP);
            groupBox3.Controls.Add(btnResetTP);
            groupBox3.Controls.Add(btnCloseAll);
            groupBox3.Controls.Add(btnSyncSL);
            groupBox3.Controls.Add(btnSell);
            groupBox3.Controls.Add(btnResetSL);
            groupBox3.Controls.Add(previewSell);
            groupBox3.Controls.Add(btnBreakEven);
            groupBox3.Controls.Add(previewBuy);
            groupBox3.Controls.Add(btnBuy);
            groupBox3.FlatStyle = FlatStyle.System;
            groupBox3.Location = new Point(6, 240);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(366, 202);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trade Management";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(187, 172);
            label11.Name = "label11";
            label11.Size = new Size(85, 17);
            label11.TabIndex = 7;
            label11.Text = "Gain % Close";
            // 
            // nudCloseOnGainPerc
            // 
            nudCloseOnGainPerc.DecimalPlaces = 2;
            nudCloseOnGainPerc.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudCloseOnGainPerc.Location = new Point(277, 170);
            nudCloseOnGainPerc.Margin = new Padding(3, 2, 3, 2);
            nudCloseOnGainPerc.Name = "nudCloseOnGainPerc";
            nudCloseOnGainPerc.Size = new Size(67, 25);
            nudCloseOnGainPerc.TabIndex = 24;
            nudCloseOnGainPerc.TextAlign = HorizontalAlignment.Right;
            // 
            // btnHedge
            // 
            btnHedge.BackColor = Color.Gold;
            btnHedge.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHedge.Location = new Point(9, 168);
            btnHedge.Margin = new Padding(3, 2, 3, 2);
            btnHedge.Name = "btnHedge";
            btnHedge.Size = new Size(163, 26);
            btnHedge.TabIndex = 23;
            btnHedge.Text = "Hedge";
            btnHedge.UseVisualStyleBackColor = false;
            btnHedge.Click += btnHedge_Click;
            // 
            // btnSyncTP
            // 
            btnSyncTP.BackColor = Color.Aqua;
            btnSyncTP.Location = new Point(96, 126);
            btnSyncTP.Margin = new Padding(3, 2, 3, 2);
            btnSyncTP.Name = "btnSyncTP";
            btnSyncTP.Size = new Size(76, 26);
            btnSyncTP.TabIndex = 21;
            btnSyncTP.Text = "Sync TP";
            btnSyncTP.UseVisualStyleBackColor = false;
            btnSyncTP.Click += btnSyncTP_Click;
            // 
            // btnResetTP
            // 
            btnResetTP.BackColor = Color.Aqua;
            btnResetTP.Location = new Point(96, 96);
            btnResetTP.Margin = new Padding(3, 2, 3, 2);
            btnResetTP.Name = "btnResetTP";
            btnResetTP.Size = new Size(76, 26);
            btnResetTP.TabIndex = 19;
            btnResetTP.Text = "Reset TP";
            btnResetTP.UseVisualStyleBackColor = false;
            btnResetTP.Click += btnResetTP_Click;
            // 
            // btnCloseAll
            // 
            btnCloseAll.BackColor = Color.Red;
            btnCloseAll.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseAll.Location = new Point(187, 22);
            btnCloseAll.Margin = new Padding(3, 2, 3, 2);
            btnCloseAll.Name = "btnCloseAll";
            btnCloseAll.Size = new Size(166, 56);
            btnCloseAll.TabIndex = 17;
            btnCloseAll.Text = "CLOSE ALL";
            btnCloseAll.UseVisualStyleBackColor = false;
            btnCloseAll.Click += BtnCloseAll_Click;
            // 
            // btnSyncSL
            // 
            btnSyncSL.BackColor = Color.Aqua;
            btnSyncSL.Location = new Point(9, 126);
            btnSyncSL.Margin = new Padding(3, 2, 3, 2);
            btnSyncSL.Name = "btnSyncSL";
            btnSyncSL.Size = new Size(81, 26);
            btnSyncSL.TabIndex = 20;
            btnSyncSL.Text = "Sync SL";
            btnSyncSL.UseVisualStyleBackColor = false;
            btnSyncSL.Click += BtnSyncSL_Click;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.OrangeRed;
            btnSell.Location = new Point(96, 52);
            btnSell.Margin = new Padding(3, 2, 3, 2);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(76, 26);
            btnSell.TabIndex = 16;
            btnSell.Text = "SELL";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += BtnSell_Click;
            // 
            // btnResetSL
            // 
            btnResetSL.BackColor = Color.Aqua;
            btnResetSL.Location = new Point(9, 96);
            btnResetSL.Margin = new Padding(3, 2, 3, 2);
            btnResetSL.Name = "btnResetSL";
            btnResetSL.Size = new Size(81, 26);
            btnResetSL.TabIndex = 18;
            btnResetSL.Text = "Reset SL";
            btnResetSL.UseVisualStyleBackColor = false;
            btnResetSL.Click += btnResetSL_Click;
            // 
            // previewSell
            // 
            previewSell.BackColor = Color.OrangeRed;
            previewSell.Location = new Point(7, 52);
            previewSell.Margin = new Padding(3, 2, 3, 2);
            previewSell.Name = "previewSell";
            previewSell.Size = new Size(83, 26);
            previewSell.TabIndex = 15;
            previewSell.Text = "Preview";
            previewSell.UseVisualStyleBackColor = false;
            previewSell.Click += previewSell_Click;
            // 
            // btnBreakEven
            // 
            btnBreakEven.BackColor = Color.Aqua;
            btnBreakEven.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBreakEven.Location = new Point(187, 96);
            btnBreakEven.Margin = new Padding(3, 2, 3, 2);
            btnBreakEven.Name = "btnBreakEven";
            btnBreakEven.Size = new Size(166, 56);
            btnBreakEven.TabIndex = 22;
            btnBreakEven.Text = "Break Even";
            btnBreakEven.UseVisualStyleBackColor = false;
            btnBreakEven.Click += BtnBreakEven_Click;
            // 
            // previewBuy
            // 
            previewBuy.BackColor = Color.Lime;
            previewBuy.Location = new Point(6, 22);
            previewBuy.Margin = new Padding(3, 2, 3, 2);
            previewBuy.Name = "previewBuy";
            previewBuy.Size = new Size(84, 26);
            previewBuy.TabIndex = 13;
            previewBuy.Text = "Preview";
            previewBuy.UseVisualStyleBackColor = false;
            previewBuy.Click += previewBuy_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Lime;
            btnBuy.Location = new Point(96, 22);
            btnBuy.Margin = new Padding(3, 2, 3, 2);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(76, 26);
            btnBuy.TabIndex = 14;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += BtnBuy_Click;
            // 
            // checkBoxManageAllPos
            // 
            checkBoxManageAllPos.Checked = true;
            checkBoxManageAllPos.CheckState = CheckState.Checked;
            checkBoxManageAllPos.Location = new Point(6, 61);
            checkBoxManageAllPos.Name = "checkBoxManageAllPos";
            checkBoxManageAllPos.Size = new Size(234, 20);
            checkBoxManageAllPos.TabIndex = 6;
            checkBoxManageAllPos.Text = "Manage All Positions";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 4;
            label7.Text = "Bot Label";
            // 
            // txtBotLabel
            // 
            txtBotLabel.Location = new Point(83, 28);
            txtBotLabel.Margin = new Padding(3, 2, 3, 2);
            txtBotLabel.Name = "txtBotLabel";
            txtBotLabel.Size = new Size(117, 25);
            txtBotLabel.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Window;
            groupBox5.Controls.Add(txtStatus);
            groupBox5.FlatStyle = FlatStyle.System;
            groupBox5.Location = new Point(109, 486);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(284, 52);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Gain";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = SystemColors.Window;
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(6, 20);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(274, 20);
            txtStatus.TabIndex = 0;
            txtStatus.TextAlign = HorizontalAlignment.Right;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(3, 8);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(390, 476);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(382, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(382, 448);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBoxShowDollars);
            groupBox4.Controls.Add(checkBoxMustPreview);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtBotLabel);
            groupBox4.Controls.Add(checkBoxManageAllPos);
            groupBox4.Location = new Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(360, 149);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bot General";
            // 
            // checkBoxShowDollars
            // 
            checkBoxShowDollars.Location = new Point(6, 113);
            checkBoxShowDollars.Name = "checkBoxShowDollars";
            checkBoxShowDollars.Size = new Size(234, 20);
            checkBoxShowDollars.TabIndex = 8;
            checkBoxShowDollars.Text = "Show Dollars in Status";
            // 
            // checkBoxMustPreview
            // 
            checkBoxMustPreview.Location = new Point(6, 87);
            checkBoxMustPreview.Name = "checkBoxMustPreview";
            checkBoxMustPreview.Size = new Size(234, 20);
            checkBoxMustPreview.TabIndex = 7;
            checkBoxMustPreview.Text = "Must Preview Before Trade";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(382, 448);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "About";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(richTextBoxAboutInfo);
            groupBox7.Location = new Point(3, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(366, 322);
            groupBox7.TabIndex = 12;
            groupBox7.TabStop = false;
            groupBox7.Text = "About";
            // 
            // richTextBoxAboutInfo
            // 
            richTextBoxAboutInfo.BackColor = SystemColors.Info;
            richTextBoxAboutInfo.Location = new Point(6, 24);
            richTextBoxAboutInfo.Name = "richTextBoxAboutInfo";
            richTextBoxAboutInfo.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxAboutInfo.Size = new Size(354, 292);
            richTextBoxAboutInfo.TabIndex = 11;
            richTextBoxAboutInfo.Text = "";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Window;
            groupBox6.Controls.Add(txtMargin);
            groupBox6.FlatStyle = FlatStyle.System;
            groupBox6.Location = new Point(3, 486);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(100, 52);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Margin";
            // 
            // txtMargin
            // 
            txtMargin.BackColor = SystemColors.Window;
            txtMargin.BorderStyle = BorderStyle.None;
            txtMargin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMargin.Location = new Point(10, 20);
            txtMargin.Name = "txtMargin";
            txtMargin.ReadOnly = true;
            txtMargin.Size = new Size(84, 20);
            txtMargin.TabIndex = 0;
            txtMargin.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(396, 542);
            Controls.Add(groupBox6);
            Controls.Add(tabControl);
            Controls.Add(groupBox5);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "MONKEY TRADER";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTPStep).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxRisk).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTrailPaddingPips).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCandleTrail).EndInit();
            ((System.ComponentModel.ISupportInitialize)nubBEAfter).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPipsPadding).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCloseOnGainPerc).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private NumericUpDown nudMaxUnits;
        private Label label2;
        private Label label1;
        private NumericUpDown nudMaxRisk;
        private GroupBox groupBox2;
        private NumericUpDown nudTPStep;
        private Label label4;
        private NumericUpDown nudSL;
        private Label label3;
        private NumericUpDown nudPipsPadding;
        private Label label5;
        private NumericUpDown nudNumPositions;
        private Label label6;
        private GroupBox groupBox3;
        private Button btnCloseAll;
        private Button btnBreakEven;
        private Button btnSell;
        private Button btnBuy;
        private Label label7;
        private TextBox txtBotLabel;
        private Button btnSyncSL;
        private GroupBox groupBox5;
        private TextBox txtStatus;
        private CheckBox checkBoxManageAllPos;
        private Button previewBuy;
        private Button previewSell;
        private TextBox txtBoxVolumeInUnits;
        private Label label8;
        private Button btnResetSL;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private NumericUpDown nubBEAfter;
        private ComboBox cboxTrailMethod;
        private CheckBox checkBoxMustPreview;
        private Label label9;
        private NumericUpDown nudCandleTrail;
        private CheckBox checkBoxTrailAfterBreakEven;
        private CheckBox checkBoxAutoBreakEven;
        private TabPage tabPage3;
        private GroupBox groupBox7;
        private RichTextBox richTextBoxAboutInfo;
        private CheckBox checkBoxShowDollars;
        private NumericUpDown nudTrailPaddingPips;
        private Label label10;
        private Button btnSyncTP;
        private Button btnResetTP;
        private Button btnHedge;
        private Label label11;
        private NumericUpDown nudCloseOnGainPerc;
        private GroupBox groupBox6;
        private TextBox txtMargin;
    }
}