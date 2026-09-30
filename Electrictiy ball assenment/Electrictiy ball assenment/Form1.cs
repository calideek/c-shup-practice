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
            string customerName = txtCustomer.Text;

            double previousReading = double.Parse(txtPrivious.Text);
            double currentReading = double.Parse(txtCurrent.Text);
            double pricePerUnit = double.Parse(txtUnitPrice.Text);

            double usage = currentReading - previousReading;

            double electricityCost = usage * pricePerUnit;

            double tax = electricityCost * 0.07;

            double fixedCharge = 5.00;

            double totalBill = electricityCost + tax + fixedCharge;

            txtUsage.Text = usage.ToString("0");
            txtTax.Text = tax.ToString("$0.00");
            txtTotal.Text = totalBill.ToString("$0.00");
        }
    }
    }

