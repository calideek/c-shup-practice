using System;
using System.Windows.Forms;

namespace HOME_work_airline
{
    public partial class Form1 : Form
    {
        private bool bookingApproved = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bookingApproved = false;

            int age, tickets;
            double baggage;

            if (txtPassengerName.Text.Trim() == "")
            {
                MessageBox.Show("Enter passenger name");
                return;
            }

            if (!int.TryParse(txtPassengerAge.Text, out age) ||
                !int.TryParse(txtNumberOfTickets.Text, out tickets) ||
                !double.TryParse(txtBaggageWeight.Text, out baggage))
            {
                MessageBox.Show("Enter valid numbers");
                return;
            }

            if (age < 1 || age > 100 ||
                tickets < 1 || tickets > 5 ||
                baggage < 0 || baggage > 50)
            {
                MessageBox.Show("Check age, tickets and baggage");
                return;
            }

            if (!rbFirstClass.Checked &&
                !rbNormalClass.Checked &&
                !rbBusinessClass.Checked)
            {
                MessageBox.Show("Select travel class");
                return;
            }

            if (age < 12 && rbFirstClass.Checked)
            {
                MessageBox.Show("Under 12 cannot book First Class");
                return;
            }

            double price = 0;
            string travelClass = "";

            if (rbFirstClass.Checked)
            {
                price = 300;
                travelClass = "First Class";
            }
            else if (rbNormalClass.Checked)
            {
                price = 200;
                travelClass = "Normal Class";
            }
            else if (rbBusinessClass.Checked)
            {
                price = 400;
                travelClass = "Business Class";
            }

            double basicCost = price * tickets;
            double total = basicCost;
            double discount = 0;

            if (tickets >= 3 && tickets <= 4)
                discount = total * 0.05;
            else if (tickets == 5)
                discount = total * 0.10;

            total -= discount;

            if (age < 12)
            {
                double childDiscount = total * 0.20;
                discount += childDiscount;
                total -= childDiscount;
            }
            else if (age >= 60)
            {
                double seniorDiscount = total * 0.10;
                discount += seniorDiscount;
                total -= seniorDiscount;
            }

            double insurance = 0;

            if (chkInsurance.Checked)
            {
                insurance = 25 * tickets;
                total += insurance;
            }

            bookingApproved = true;

            lstBookingDetails.Items.Clear();

            lstBookingDetails.Items.Add("AIRLINE BOOKING DETAILS");
            lstBookingDetails.Items.Add("------------------------------");
            lstBookingDetails.Items.Add(
                "Passenger: " + txtPassengerName.Text.Trim());
            lstBookingDetails.Items.Add("Age: " + age);
            lstBookingDetails.Items.Add("Class: " + travelClass);
            lstBookingDetails.Items.Add("Tickets: " + tickets);
            lstBookingDetails.Items.Add("Baggage: " + baggage + " kg");
            lstBookingDetails.Items.Add(
                "Basic Cost: $" + basicCost.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Discount: $" + discount.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Insurance: $" + insurance.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Final Total: $" + total.ToString("0.00"));
            lstBookingDetails.Items.Add(
                "Booking Approved: " + bookingApproved);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            rbFirstClass.Checked = false;
            rbNormalClass.Checked = false;
            rbBusinessClass.Checked = false;
            chkInsurance.Checked = false;

            lstBookingDetails.Items.Clear();

            bookingApproved = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            rbFirstClass.Checked = false;
            rbNormalClass.Checked = false;
            rbBusinessClass.Checked = false;

            chkInsurance.Checked = false;

            lstBookingDetails.Items.Clear();

            bookingApproved = false;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}