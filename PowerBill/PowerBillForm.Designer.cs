namespace PowerBill
{
    partial class ChargeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKwh = new System.Windows.Forms.Label();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.calcCharge = new System.Windows.Forms.Button();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbResidential = new System.Windows.Forms.RadioButton();
            this.rbCommercial = new System.Windows.Forms.RadioButton();
            this.rbIndustrial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeakKwh = new System.Windows.Forms.TextBox();
            this.lblPeakKwh = new System.Windows.Forms.Label();
            this.txtNonPeakKwh = new System.Windows.Forms.TextBox();
            this.lblNonPeakKwh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.txtNumCust = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSumCharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIcharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCcharge = new System.Windows.Forms.TextBox();
            this.txtRcharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKwh
            // 
            this.lblKwh.AutoSize = true;
            this.lblKwh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblKwh.Location = new System.Drawing.Point(98, 353);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(32, 15);
            this.lblKwh.TabIndex = 0;
            this.lblKwh.Text = "kWh";
            // 
            // txtKwh
            // 
            this.txtKwh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKwh.Location = new System.Drawing.Point(188, 345);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(100, 25);
            this.txtKwh.TabIndex = 1;
            // 
            // calcCharge
            // 
            this.calcCharge.BackColor = System.Drawing.Color.MidnightBlue;
            this.calcCharge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.calcCharge.ForeColor = System.Drawing.Color.White;
            this.calcCharge.Location = new System.Drawing.Point(149, 427);
            this.calcCharge.Name = "calcCharge";
            this.calcCharge.Size = new System.Drawing.Size(142, 45);
            this.calcCharge.TabIndex = 2;
            this.calcCharge.Text = "Calculate";
            this.calcCharge.UseVisualStyleBackColor = false;
            this.calcCharge.Click += new System.EventHandler(this.calcCharge_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(306, 345);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 29);
            this.txtCharge.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(314, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Charge";
            // 
            // rbResidential
            // 
            this.rbResidential.AutoSize = true;
            this.rbResidential.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.rbResidential.Location = new System.Drawing.Point(27, 36);
            this.rbResidential.Name = "rbResidential";
            this.rbResidential.Size = new System.Drawing.Size(96, 23);
            this.rbResidential.TabIndex = 6;
            this.rbResidential.TabStop = true;
            this.rbResidential.Text = "Residential";
            this.rbResidential.UseVisualStyleBackColor = true;
            this.rbResidential.CheckedChanged += new System.EventHandler(this.rbResidential_CheckedChanged);
            // 
            // rbCommercial
            // 
            this.rbCommercial.AutoSize = true;
            this.rbCommercial.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.rbCommercial.Location = new System.Drawing.Point(141, 36);
            this.rbCommercial.Name = "rbCommercial";
            this.rbCommercial.Size = new System.Drawing.Size(102, 23);
            this.rbCommercial.TabIndex = 7;
            this.rbCommercial.TabStop = true;
            this.rbCommercial.Text = "Commercial";
            this.rbCommercial.UseVisualStyleBackColor = true;
            this.rbCommercial.CheckedChanged += new System.EventHandler(this.rbCommercial_CheckedChanged);
            // 
            // rbIndustrial
            // 
            this.rbIndustrial.AutoSize = true;
            this.rbIndustrial.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.rbIndustrial.Location = new System.Drawing.Point(259, 36);
            this.rbIndustrial.Name = "rbIndustrial";
            this.rbIndustrial.Size = new System.Drawing.Size(86, 23);
            this.rbIndustrial.TabIndex = 8;
            this.rbIndustrial.TabStop = true;
            this.rbIndustrial.Text = "Industrial";
            this.rbIndustrial.UseVisualStyleBackColor = true;
            this.rbIndustrial.CheckedChanged += new System.EventHandler(this.rbIndustrial_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbResidential);
            this.groupBox1.Controls.Add(this.rbIndustrial);
            this.groupBox1.Controls.Add(this.rbCommercial);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(45, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type";
            // 
            // txtPeakKwh
            // 
            this.txtPeakKwh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakKwh.Location = new System.Drawing.Point(188, 330);
            this.txtPeakKwh.Name = "txtPeakKwh";
            this.txtPeakKwh.Size = new System.Drawing.Size(100, 25);
            this.txtPeakKwh.TabIndex = 10;
            // 
            // lblPeakKwh
            // 
            this.lblPeakKwh.AutoSize = true;
            this.lblPeakKwh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeakKwh.Location = new System.Drawing.Point(70, 338);
            this.lblPeakKwh.Name = "lblPeakKwh";
            this.lblPeakKwh.Size = new System.Drawing.Size(60, 15);
            this.lblPeakKwh.TabIndex = 11;
            this.lblPeakKwh.Text = "Peak kWh";
            // 
            // txtNonPeakKwh
            // 
            this.txtNonPeakKwh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonPeakKwh.Location = new System.Drawing.Point(188, 369);
            this.txtNonPeakKwh.Name = "txtNonPeakKwh";
            this.txtNonPeakKwh.Size = new System.Drawing.Size(100, 25);
            this.txtNonPeakKwh.TabIndex = 10;
            // 
            // lblNonPeakKwh
            // 
            this.lblNonPeakKwh.AutoSize = true;
            this.lblNonPeakKwh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNonPeakKwh.Location = new System.Drawing.Point(42, 365);
            this.lblNonPeakKwh.Name = "lblNonPeakKwh";
            this.lblNonPeakKwh.Size = new System.Drawing.Size(88, 15);
            this.lblNonPeakKwh.TabIndex = 11;
            this.lblNonPeakKwh.Text = "Non-Peak kWh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Moss Power Inc.";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SlateGray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(36, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(754, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(-3, 199);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(397, 147);
            this.lstCustomers.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(59, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Number:";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(188, 245);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(191, 25);
            this.txtCustName.TabIndex = 1;
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNum.Location = new System.Drawing.Point(188, 279);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(191, 25);
            this.txtAcctNum.TabIndex = 1;
            // 
            // txtNumCust
            // 
            this.txtNumCust.Enabled = false;
            this.txtNumCust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCust.Location = new System.Drawing.Point(312, 9);
            this.txtNumCust.Name = "txtNumCust";
            this.txtNumCust.Size = new System.Drawing.Size(58, 25);
            this.txtNumCust.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(156, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of Customers:";
            // 
            // txtSumCharge
            // 
            this.txtSumCharge.Enabled = false;
            this.txtSumCharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumCharge.Location = new System.Drawing.Point(176, 78);
            this.txtSumCharge.Name = "txtSumCharge";
            this.txtSumCharge.Size = new System.Drawing.Size(150, 25);
            this.txtSumCharge.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sum of Charges:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(306, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 42);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(275, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Industrial:";
            // 
            // txtIcharge
            // 
            this.txtIcharge.Enabled = false;
            this.txtIcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIcharge.Location = new System.Drawing.Point(279, 161);
            this.txtIcharge.Name = "txtIcharge";
            this.txtIcharge.Size = new System.Drawing.Size(83, 25);
            this.txtIcharge.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(156, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Commercial:";
            // 
            // txtCcharge
            // 
            this.txtCcharge.Enabled = false;
            this.txtCcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCcharge.Location = new System.Drawing.Point(160, 161);
            this.txtCcharge.Name = "txtCcharge";
            this.txtCcharge.Size = new System.Drawing.Size(83, 25);
            this.txtCcharge.TabIndex = 1;
            // 
            // txtRcharge
            // 
            this.txtRcharge.Enabled = false;
            this.txtRcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRcharge.Location = new System.Drawing.Point(50, 161);
            this.txtRcharge.Name = "txtRcharge";
            this.txtRcharge.Size = new System.Drawing.Size(83, 25);
            this.txtRcharge.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Residential:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 108);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lstCustomers);
            this.panel2.Controls.Add(this.txtSumCharge);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtRcharge);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtIcharge);
            this.panel2.Controls.Add(this.txtCcharge);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(476, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 387);
            this.panel2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(131, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Database Info";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNumCust);
            this.panel3.Location = new System.Drawing.Point(0, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 44);
            this.panel3.TabIndex = 17;
            // 
            // ChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNonPeakKwh);
            this.Controls.Add(this.lblPeakKwh);
            this.Controls.Add(this.txtNonPeakKwh);
            this.Controls.Add(this.txtPeakKwh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtAcctNum);
            this.Controls.Add(this.calcCharge);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtKwh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKwh);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChargeForm";
            this.Text = "Power Company";
            this.Load += new System.EventHandler(this.ChargeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKwh;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.Button calcCharge;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbResidential;
        private System.Windows.Forms.RadioButton rbCommercial;
        private System.Windows.Forms.RadioButton rbIndustrial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPeakKwh;
        private System.Windows.Forms.Label lblPeakKwh;
        private System.Windows.Forms.TextBox txtNonPeakKwh;
        private System.Windows.Forms.Label lblNonPeakKwh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.TextBox txtNumCust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSumCharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIcharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCcharge;
        private System.Windows.Forms.TextBox txtRcharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
    }
}

