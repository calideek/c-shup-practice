namespace HOME_work_airline
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBaggage = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpclass = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBusinessClass = new System.Windows.Forms.RadioButton();
            this.rbNormalClass = new System.Windows.Forms.RadioButton();
            this.rbFirstClass = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.grpclass.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumberOfTickets);
            this.groupBox1.Controls.Add(this.txtBaggageWeight);
            this.groupBox1.Controls.Add(this.txtPassengerAge);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblBaggage);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.txtPassengerName);
            this.groupBox1.Controls.Add(this.lblTickets);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "persanal information";
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(194, 88);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(112, 22);
            this.txtNumberOfTickets.TabIndex = 7;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(194, 119);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(112, 22);
            this.txtBaggageWeight.TabIndex = 8;
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(194, 61);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(112, 22);
            this.txtPassengerAge.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "passenger name:";
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Location = new System.Drawing.Point(15, 125);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(149, 16);
            this.lblBaggage.TabIndex = 4;
            this.lblBaggage.Text = "baggage weight(kg):";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 61);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(117, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "passenger Age:";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(194, 29);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(112, 22);
            this.txtPassengerName.TabIndex = 6;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(15, 91);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(129, 16);
            this.lblTickets.TabIndex = 3;
            this.lblTickets.Text = "number of Ticktis:";
            // 
            // grpclass
            // 
            this.grpclass.Controls.Add(this.groupBox3);
            this.grpclass.Controls.Add(this.rbBusinessClass);
            this.grpclass.Controls.Add(this.rbNormalClass);
            this.grpclass.Controls.Add(this.rbFirstClass);
            this.grpclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpclass.Location = new System.Drawing.Point(12, 184);
            this.grpclass.Name = "grpclass";
            this.grpclass.Size = new System.Drawing.Size(349, 94);
            this.grpclass.TabIndex = 6;
            this.grpclass.TabStop = false;
            this.grpclass.Text = "Travel class";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 71);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rbBusinessClass
            // 
            this.rbBusinessClass.AutoSize = true;
            this.rbBusinessClass.Location = new System.Drawing.Point(225, 43);
            this.rbBusinessClass.Name = "rbBusinessClass";
            this.rbBusinessClass.Size = new System.Drawing.Size(120, 19);
            this.rbBusinessClass.TabIndex = 9;
            this.rbBusinessClass.TabStop = true;
            this.rbBusinessClass.Text = "Business class";
            this.rbBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rbNormalClass
            // 
            this.rbNormalClass.AutoSize = true;
            this.rbNormalClass.Location = new System.Drawing.Point(110, 43);
            this.rbNormalClass.Name = "rbNormalClass";
            this.rbNormalClass.Size = new System.Drawing.Size(109, 19);
            this.rbNormalClass.TabIndex = 8;
            this.rbNormalClass.TabStop = true;
            this.rbNormalClass.Text = "Normal class";
            this.rbNormalClass.UseVisualStyleBackColor = true;
            // 
            // rbFirstClass
            // 
            this.rbFirstClass.AutoSize = true;
            this.rbFirstClass.Location = new System.Drawing.Point(6, 43);
            this.rbFirstClass.Name = "rbFirstClass";
            this.rbFirstClass.Size = new System.Drawing.Size(86, 19);
            this.rbFirstClass.TabIndex = 7;
            this.rbFirstClass.TabStop = true;
            this.rbFirstClass.Text = "first class";
            this.rbFirstClass.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkInsurance);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additional options";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(38, 62);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(272, 20);
            this.chkInsurance.TabIndex = 0;
            this.chkInsurance.Text = "add travel insurance($25 per tichtis)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 401);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.Items.AddRange(new object[] {
            "Airline booking detalis"});
            this.lstBookingDetails.Location = new System.Drawing.Point(378, 22);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(350, 381);
            this.lstBookingDetails.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBookingDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpclass);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpclass.ResumeLayout(false);
            this.grpclass.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTickets;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.GroupBox grpclass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBusinessClass;
        private System.Windows.Forms.RadioButton rbNormalClass;
        private System.Windows.Forms.RadioButton rbFirstClass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBookingDetails;
    }
}

