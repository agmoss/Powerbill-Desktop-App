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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKwh
            // 
            this.lblKwh.AutoSize = true;
            this.lblKwh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKwh.Location = new System.Drawing.Point(114, 371);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(42, 21);
            this.lblKwh.TabIndex = 0;
            this.lblKwh.Text = "kWh";
            // 
            // txtKwh
            // 
            this.txtKwh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKwh.Location = new System.Drawing.Point(162, 371);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(100, 25);
            this.txtKwh.TabIndex = 1;
            // 
            // calcCharge
            // 
            this.calcCharge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.calcCharge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcCharge.Location = new System.Drawing.Point(329, 478);
            this.calcCharge.Name = "calcCharge";
            this.calcCharge.Size = new System.Drawing.Size(142, 41);
            this.calcCharge.TabIndex = 2;
            this.calcCharge.Text = "Calculate";
            this.calcCharge.UseVisualStyleBackColor = false;
            this.calcCharge.Click += new System.EventHandler(this.calcCharge_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(162, 484);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 29);
            this.txtCharge.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Charge";
            // 
            // rbResidential
            // 
            this.rbResidential.AutoSize = true;
            this.rbResidential.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResidential.Location = new System.Drawing.Point(18, 40);
            this.rbResidential.Name = "rbResidential";
            this.rbResidential.Size = new System.Drawing.Size(108, 25);
            this.rbResidential.TabIndex = 6;
            this.rbResidential.TabStop = true;
            this.rbResidential.Text = "Residential";
            this.rbResidential.UseVisualStyleBackColor = true;
            this.rbResidential.CheckedChanged += new System.EventHandler(this.rbResidential_CheckedChanged);
            // 
            // rbCommercial
            // 
            this.rbCommercial.AutoSize = true;
            this.rbCommercial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCommercial.Location = new System.Drawing.Point(18, 71);
            this.rbCommercial.Name = "rbCommercial";
            this.rbCommercial.Size = new System.Drawing.Size(115, 25);
            this.rbCommercial.TabIndex = 7;
            this.rbCommercial.TabStop = true;
            this.rbCommercial.Text = "Commercial";
            this.rbCommercial.UseVisualStyleBackColor = true;
            this.rbCommercial.CheckedChanged += new System.EventHandler(this.rbCommercial_CheckedChanged);
            // 
            // rbIndustrial
            // 
            this.rbIndustrial.AutoSize = true;
            this.rbIndustrial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIndustrial.Location = new System.Drawing.Point(18, 102);
            this.rbIndustrial.Name = "rbIndustrial";
            this.rbIndustrial.Size = new System.Drawing.Size(96, 25);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type";
            // 
            // txtPeakKwh
            // 
            this.txtPeakKwh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakKwh.Location = new System.Drawing.Point(162, 402);
            this.txtPeakKwh.Name = "txtPeakKwh";
            this.txtPeakKwh.Size = new System.Drawing.Size(100, 25);
            this.txtPeakKwh.TabIndex = 10;
            // 
            // lblPeakKwh
            // 
            this.lblPeakKwh.AutoSize = true;
            this.lblPeakKwh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakKwh.Location = new System.Drawing.Point(77, 402);
            this.lblPeakKwh.Name = "lblPeakKwh";
            this.lblPeakKwh.Size = new System.Drawing.Size(79, 21);
            this.lblPeakKwh.TabIndex = 11;
            this.lblPeakKwh.Text = "Peak kWh";
            // 
            // txtNonPeakKwh
            // 
            this.txtNonPeakKwh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonPeakKwh.Location = new System.Drawing.Point(162, 433);
            this.txtNonPeakKwh.Name = "txtNonPeakKwh";
            this.txtNonPeakKwh.Size = new System.Drawing.Size(100, 25);
            this.txtNonPeakKwh.TabIndex = 10;
            // 
            // lblNonPeakKwh
            // 
            this.lblNonPeakKwh.AutoSize = true;
            this.lblNonPeakKwh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonPeakKwh.Location = new System.Drawing.Point(40, 433);
            this.lblNonPeakKwh.Name = "lblNonPeakKwh";
            this.lblNonPeakKwh.Size = new System.Drawing.Size(116, 21);
            this.lblNonPeakKwh.TabIndex = 11;
            this.lblNonPeakKwh.Text = "Non-Peak kWh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Power Bill Calculator";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(484, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 41);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(484, 431);
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
            this.lstCustomers.Location = new System.Drawing.Point(279, 92);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(262, 147);
            this.lstCustomers.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Number:";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(162, 281);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 25);
            this.txtCustName.TabIndex = 1;
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNum.Location = new System.Drawing.Point(162, 324);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(100, 25);
            this.txtAcctNum.TabIndex = 1;
            // 
            // txtNumCust
            // 
            this.txtNumCust.Enabled = false;
            this.txtNumCust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCust.Location = new System.Drawing.Point(498, 245);
            this.txtNumCust.Name = "txtNumCust";
            this.txtNumCust.Size = new System.Drawing.Size(43, 25);
            this.txtNumCust.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of Customers:";
            // 
            // txtSumCharge
            // 
            this.txtSumCharge.Enabled = false;
            this.txtSumCharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumCharge.Location = new System.Drawing.Point(461, 371);
            this.txtSumCharge.Name = "txtSumCharge";
            this.txtSumCharge.Size = new System.Drawing.Size(83, 25);
            this.txtSumCharge.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sum of Charges:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Industrial:";
            // 
            // txtIcharge
            // 
            this.txtIcharge.Enabled = false;
            this.txtIcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIcharge.Location = new System.Drawing.Point(351, 372);
            this.txtIcharge.Name = "txtIcharge";
            this.txtIcharge.Size = new System.Drawing.Size(83, 25);
            this.txtIcharge.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Commercial:";
            // 
            // txtCcharge
            // 
            this.txtCcharge.Enabled = false;
            this.txtCcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCcharge.Location = new System.Drawing.Point(351, 340);
            this.txtCcharge.Name = "txtCcharge";
            this.txtCcharge.Size = new System.Drawing.Size(83, 25);
            this.txtCcharge.TabIndex = 1;
            // 
            // txtRcharge
            // 
            this.txtRcharge.Enabled = false;
            this.txtRcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRcharge.Location = new System.Drawing.Point(351, 309);
            this.txtRcharge.Name = "txtRcharge";
            this.txtRcharge.Size = new System.Drawing.Size(83, 25);
            this.txtRcharge.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Residential:";
            // 
            // ChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 555);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNonPeakKwh);
            this.Controls.Add(this.lblPeakKwh);
            this.Controls.Add(this.txtNonPeakKwh);
            this.Controls.Add(this.txtPeakKwh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.calcCharge);
            this.Controls.Add(this.txtRcharge);
            this.Controls.Add(this.txtCcharge);
            this.Controls.Add(this.txtIcharge);
            this.Controls.Add(this.txtSumCharge);
            this.Controls.Add(this.txtNumCust);
            this.Controls.Add(this.txtAcctNum);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtKwh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKwh);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChargeForm";
            this.Text = "Power Company";
            this.Load += new System.EventHandler(this.ChargeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

