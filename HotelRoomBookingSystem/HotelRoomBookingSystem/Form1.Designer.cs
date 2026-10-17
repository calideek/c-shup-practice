namespace HotelRoomBookingSystem
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
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblGuestAge = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.lblRoomType = new System.Windows.Forms.GroupBox();
            this.rbHight = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.lblOptions = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBookingDetails = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.lblRoomType.SuspendLayout();
            this.lblOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGuests);
            this.groupBox1.Controls.Add(this.txtNights);
            this.groupBox1.Controls.Add(this.txtGuestAge);
            this.groupBox1.Controls.Add(this.lblGuests);
            this.groupBox1.Controls.Add(this.lblNights);
            this.groupBox1.Controls.Add(this.lblGuestAge);
            this.groupBox1.Controls.Add(this.lblGuestName);
            this.groupBox1.Controls.Add(this.txtGuestName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personal informatoin";
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(142, 118);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(100, 21);
            this.txtGuests.TabIndex = 11;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(142, 86);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(100, 21);
            this.txtNights.TabIndex = 10;
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(142, 59);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(100, 21);
            this.txtGuestAge.TabIndex = 9;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(6, 118);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(115, 15);
            this.lblGuests.TabIndex = 8;
            this.lblGuests.Text = "number of guest:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(6, 90);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(119, 15);
            this.lblNights.TabIndex = 7;
            this.lblNights.Text = "number of nights:";
            // 
            // lblGuestAge
            // 
            this.lblGuestAge.AutoSize = true;
            this.lblGuestAge.Location = new System.Drawing.Point(6, 59);
            this.lblGuestAge.Name = "lblGuestAge";
            this.lblGuestAge.Size = new System.Drawing.Size(74, 15);
            this.lblGuestAge.TabIndex = 6;
            this.lblGuestAge.Text = "guest age:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(6, 32);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(86, 15);
            this.lblGuestName.TabIndex = 5;
            this.lblGuestName.Text = "guest name:";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(142, 26);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(100, 21);
            this.txtGuestName.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 436);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(6, 38);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(179, 19);
            this.chkBreakfast.TabIndex = 2;
            this.chkBreakfast.Text = "breakfast (10 pernights)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            this.chkBreakfast.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(6, 38);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(73, 19);
            this.rbStandard.TabIndex = 3;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "stander";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Controls.Add(this.rbHight);
            this.lblRoomType.Controls.Add(this.rbNormal);
            this.lblRoomType.Controls.Add(this.rbStandard);
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(21, 193);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(340, 100);
            this.lblRoomType.TabIndex = 5;
            this.lblRoomType.TabStop = false;
            this.lblRoomType.Text = "Room type";
            // 
            // rbHight
            // 
            this.rbHight.AutoSize = true;
            this.rbHight.Location = new System.Drawing.Point(227, 41);
            this.rbHight.Name = "rbHight";
            this.rbHight.Size = new System.Drawing.Size(57, 19);
            this.rbHight.TabIndex = 5;
            this.rbHight.TabStop = true;
            this.rbHight.Text = "hight";
            this.rbHight.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(117, 41);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(70, 19);
            this.rbNormal.TabIndex = 4;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            this.lblOptions.Controls.Add(this.chkBreakfast);
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(21, 299);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(340, 100);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.TabStop = false;
            this.lblOptions.Text = "additoinal opratoin";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(107, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(214, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtBookingDetails
            // 
            this.txtBookingDetails.FormattingEnabled = true;
            this.txtBookingDetails.Items.AddRange(new object[] {
            "Booking Details"});
            this.txtBookingDetails.Location = new System.Drawing.Point(367, 22);
            this.txtBookingDetails.Name = "txtBookingDetails";
            this.txtBookingDetails.Size = new System.Drawing.Size(351, 381);
            this.txtBookingDetails.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.txtBookingDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblRoomType.ResumeLayout(false);
            this.lblRoomType.PerformLayout();
            this.lblOptions.ResumeLayout(false);
            this.lblOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblGuestAge;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.GroupBox lblRoomType;
        private System.Windows.Forms.RadioButton rbHight;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.GroupBox lblOptions;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox txtBookingDetails;
    }
}

