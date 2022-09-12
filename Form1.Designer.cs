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
            this.btnStopBot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudNumPositions = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMaxUnits = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxRisk = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudPipsPadding = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTPStep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBESync = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.btnTrail = new System.Windows.Forms.Button();
            this.btnBreakEven = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBotLabel = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.ManageAllPosCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRisk)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPipsPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTPStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStopBot
            // 
            this.btnStopBot.BackColor = System.Drawing.Color.Orange;
            this.btnStopBot.Location = new System.Drawing.Point(7, 15);
            this.btnStopBot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopBot.Name = "btnStopBot";
            this.btnStopBot.Size = new System.Drawing.Size(167, 26);
            this.btnStopBot.TabIndex = 0;
            this.btnStopBot.Text = "STOP BOT";
            this.btnStopBot.UseVisualStyleBackColor = false;
            this.btnStopBot.Click += new System.EventHandler(this.btnStopBot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudNumPositions);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudMaxUnits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudMaxRisk);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(178, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position Size";
            // 
            // nudNumPositions
            // 
            this.nudNumPositions.Location = new System.Drawing.Point(96, 91);
            this.nudNumPositions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNumPositions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumPositions.Name = "nudNumPositions";
            this.nudNumPositions.Size = new System.Drawing.Size(76, 25);
            this.nudNumPositions.TabIndex = 5;
            this.nudNumPositions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumPositions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "# Positions";
            // 
            // nudMaxUnits
            // 
            this.nudMaxUnits.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxUnits.Location = new System.Drawing.Point(96, 59);
            this.nudMaxUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMaxUnits.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaxUnits.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxUnits.Name = "nudMaxUnits";
            this.nudMaxUnits.Size = new System.Drawing.Size(76, 25);
            this.nudMaxUnits.TabIndex = 3;
            this.nudMaxUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxUnits.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Risk %";
            // 
            // nudMaxRisk
            // 
            this.nudMaxRisk.DecimalPlaces = 1;
            this.nudMaxRisk.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaxRisk.Location = new System.Drawing.Point(96, 25);
            this.nudMaxRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMaxRisk.Name = "nudMaxRisk";
            this.nudMaxRisk.Size = new System.Drawing.Size(76, 25);
            this.nudMaxRisk.TabIndex = 0;
            this.nudMaxRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudPipsPadding);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudTPStep);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudSL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(11, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(178, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stops n Targets";
            // 
            // nudPipsPadding
            // 
            this.nudPipsPadding.DecimalPlaces = 1;
            this.nudPipsPadding.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPipsPadding.Location = new System.Drawing.Point(96, 91);
            this.nudPipsPadding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPipsPadding.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPipsPadding.Name = "nudPipsPadding";
            this.nudPipsPadding.Size = new System.Drawing.Size(76, 25);
            this.nudPipsPadding.TabIndex = 5;
            this.nudPipsPadding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPipsPadding.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pips padding";
            // 
            // nudTPStep
            // 
            this.nudTPStep.DecimalPlaces = 1;
            this.nudTPStep.Location = new System.Drawing.Point(96, 59);
            this.nudTPStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTPStep.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTPStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTPStep.Name = "nudTPStep";
            this.nudTPStep.Size = new System.Drawing.Size(76, 25);
            this.nudTPStep.TabIndex = 3;
            this.nudTPStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTPStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Target Step";
            // 
            // nudSL
            // 
            this.nudSL.DecimalPlaces = 1;
            this.nudSL.Location = new System.Drawing.Point(96, 25);
            this.nudSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSL.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(76, 25);
            this.nudSL.TabIndex = 1;
            this.nudSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stop Loss";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManageAllPosCheckBox);
            this.groupBox3.Controls.Add(this.btnBESync);
            this.groupBox3.Controls.Add(this.btnCloseAll);
            this.groupBox3.Controls.Add(this.btnTrail);
            this.groupBox3.Controls.Add(this.btnBreakEven);
            this.groupBox3.Controls.Add(this.btnSell);
            this.groupBox3.Controls.Add(this.btnBuy);
            this.groupBox3.Location = new System.Drawing.Point(197, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(179, 174);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trade Management";
            // 
            // btnBESync
            // 
            this.btnBESync.BackColor = System.Drawing.Color.Aqua;
            this.btnBESync.Location = new System.Drawing.Point(99, 58);
            this.btnBESync.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBESync.Name = "btnBESync";
            this.btnBESync.Size = new System.Drawing.Size(74, 26);
            this.btnBESync.TabIndex = 5;
            this.btnBESync.Text = "B.E. Sync";
            this.btnBESync.UseVisualStyleBackColor = false;
            this.btnBESync.Click += new System.EventHandler(this.btnBESync_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.BackColor = System.Drawing.Color.Red;
            this.btnCloseAll.Location = new System.Drawing.Point(6, 127);
            this.btnCloseAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(168, 26);
            this.btnCloseAll.TabIndex = 4;
            this.btnCloseAll.Text = "CLOSE ALL";
            this.btnCloseAll.UseVisualStyleBackColor = false;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // btnTrail
            // 
            this.btnTrail.BackColor = System.Drawing.Color.Aqua;
            this.btnTrail.Location = new System.Drawing.Point(7, 94);
            this.btnTrail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrail.Name = "btnTrail";
            this.btnTrail.Size = new System.Drawing.Size(74, 26);
            this.btnTrail.TabIndex = 3;
            this.btnTrail.Text = "TRAIL";
            this.btnTrail.UseVisualStyleBackColor = false;
            this.btnTrail.Click += new System.EventHandler(this.btnTrail_Click);
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.Aqua;
            this.btnBreakEven.Location = new System.Drawing.Point(6, 58);
            this.btnBreakEven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBreakEven.Name = "btnBreakEven";
            this.btnBreakEven.Size = new System.Drawing.Size(74, 26);
            this.btnBreakEven.TabIndex = 2;
            this.btnBreakEven.Text = "B.E.";
            this.btnBreakEven.UseVisualStyleBackColor = false;
            this.btnBreakEven.Click += new System.EventHandler(this.btnBreakEven_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSell.Location = new System.Drawing.Point(99, 25);
            this.btnSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(74, 26);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Lime;
            this.btnBuy.Location = new System.Drawing.Point(6, 25);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 26);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bot Label";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBotLabel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnStopBot);
            this.groupBox4.Location = new System.Drawing.Point(197, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(179, 84);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bot";
            // 
            // txtBotLabel
            // 
            this.txtBotLabel.Location = new System.Drawing.Point(67, 48);
            this.txtBotLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBotLabel.Name = "txtBotLabel";
            this.txtBotLabel.Size = new System.Drawing.Size(106, 25);
            this.txtBotLabel.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStatus);
            this.groupBox5.Location = new System.Drawing.Point(12, 285);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(363, 56);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(9, 21);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(348, 20);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // ManageAllPosCheckBox
            // 
            this.ManageAllPosCheckBox.Location = new System.Drawing.Point(100, 97);
            this.ManageAllPosCheckBox.Name = "ManageAllPosCheckBox";
            this.ManageAllPosCheckBox.Size = new System.Drawing.Size(60, 20);
            this.ManageAllPosCheckBox.TabIndex = 6;
            this.ManageAllPosCheckBox.Values.Text = "All Pos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(386, 352);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MONKEY TRADER";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRisk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPipsPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTPStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStopBot;
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
        private Button btnTrail;
        private Button btnBreakEven;
        private Button btnSell;
        private Button btnBuy;
        private Label label7;
        private GroupBox groupBox4;
        private TextBox txtBotLabel;
        private Button btnBESync;
        private GroupBox groupBox5;
        private TextBox txtStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ManageAllPosCheckBox;
    }
}