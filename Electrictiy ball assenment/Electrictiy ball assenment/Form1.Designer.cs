namespace Electrictiy_ball_assenment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCustomer = new TextBox();
            txtPrivious = new TextBox();
            txtCurrent = new TextBox();
            txtUnitPrice = new TextBox();
            txtTax = new TextBox();
            txtUsage = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(249, 35);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter comtomar Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(249, 72);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 1;
            label2.Text = "Entyer Previous Reading";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(249, 113);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 2;
            label3.Text = "Enter Current Reading";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(249, 160);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 3;
            label4.Text = "Enter Price Per Unit($)";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(436, 35);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(100, 23);
            txtCustomer.TabIndex = 4;
            // 
            // txtPrivious
            // 
            txtPrivious.Location = new Point(434, 72);
            txtPrivious.Name = "txtPrivious";
            txtPrivious.Size = new Size(100, 23);
            txtPrivious.TabIndex = 5;
            // 
            // txtCurrent
            // 
            txtCurrent.Location = new Point(434, 111);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(100, 23);
            txtCurrent.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(434, 162);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(500, 311);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 8;
            // 
            // txtUsage
            // 
            txtUsage.Location = new Point(500, 277);
            txtUsage.Name = "txtUsage";
            txtUsage.Size = new Size(100, 23);
            txtUsage.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(500, 345);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(404, 229);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(114, 23);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "calculate Ball";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(249, 277);
            label5.Name = "label5";
            label5.Size = new Size(190, 25);
            label5.TabIndex = 12;
            label5.Text = "Electricty Usage(unit)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(249, 306);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 13;
            label6.Text = "Tax Amount(7%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(240, 345);
            label7.Name = "label7";
            label7.Size = new Size(236, 25);
            label7.TabIndex = 14;
            label7.Text = "Tatal bil(inlding $5 charge)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtUsage);
            Controls.Add(txtTax);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCurrent);
            Controls.Add(txtPrivious);
            Controls.Add(txtCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCustomer;
        private TextBox txtPrivious;
        private TextBox txtCurrent;
        private TextBox txtUnitPrice;
        private TextBox txtTax;
        private TextBox txtUsage;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
