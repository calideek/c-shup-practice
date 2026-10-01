namespace Electrictiy_ball_assenment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from TextBoxes
                string customerName = txtCustomer.Text;

                double previousReading = double.Parse(txtPrivious.Text);
                double currentReading = double.Parse(txtCurrent.Text);
                double pricePerUnit = double.Parse(txtUnitPrice.Text);

                // Calculate electricity usage
                double usage = currentReading - previousReading;

                // Calculate electricity cost
                double electricityCost = usage * pricePerUnit;

                // Calculate tax (7%)
                double tax = electricityCost * 0.07;

                // Fixed charge
                double fixedCharge = 5.00;

                // Calculate total bill
                double totalBill = electricityCost + tax + fixedCharge;

                // Display results
                txtUsage.Text = usage.ToString("0");
                txtTax.Text = tax.ToString("$0.00");
                txtTotal.Text = totalBill.ToString("$0.00");

            }
            catch
            {
                MessageBox.Show("please enter valid number");
            }
        }

    }
}

