using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace HotelRoomBookingSystem
{
    public partial class Form1 : Form
    {
        bool bookingApproved = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bookingApproved = false;

            string name = txtGuestName.Text.Trim();
            int age, nights, guests;

            if (name == "")
            {
                MessageBox.Show("Enter guest name");
                return;
            }

            if (!int.TryParse(txtGuestAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Enter valid numbers");
                return;
            }

            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6");
                return;
            }

            if (!rbStandard.Checked &&
                !rbNormal.Checked &&
                !rbHight.Checked)
            {
                MessageBox.Show("Select room type");
                return;
            }

            string roomType;
            decimal rate;
            int maxGuests;

            if (rbStandard.Checked)
            {
                roomType = "Standard";
            }
            else if (rbNormal.Checked)
            {
                roomType = "Normal";
            }
            else
            {
                roomType = "Hight";
            }

            switch (roomType)
            {
                case "Standard":
                    rate = 50m;
                    maxGuests = 2;
                    break;

                case "Normal":
                    rate = 80m;
                    maxGuests = 4;
                    break;

                case "Hight":
                    rate = 130m;
                    maxGuests = 6;
                    break;

                default:
                    MessageBox.Show("Invalid room type");
                    return;
            }

            if (guests > maxGuests)
            {
                MessageBox.Show("Room allows maximum " + maxGuests + " guests");
                return;
            }

            bookingApproved = true;

            decimal roomCost = rate * nights;
            decimal breakfast = 0m;

            if (chkBreakfast.Checked)
            {
                breakfast = 10m * guests * nights;
            }

            decimal subtotal = roomCost + breakfast;
            decimal nightDiscount = 0m;

            if (nights >= 10)
            {
                nightDiscount = subtotal * 0.12m;
            }
            else if (nights >= 5)
            {
                nightDiscount = subtotal * 0.05m;
            }

            decimal remaining = subtotal - nightDiscount;
            decimal seniorDiscount = 0m;

            if (age >= 60)
            {
                seniorDiscount = remaining * 0.05m;
            }

            remaining -= seniorDiscount;

            decimal serviceCharge = 0m;

            if (guests > 4)
            {
                serviceCharge = remaining * 0.05m;
            }

            decimal total = remaining + serviceCharge;

            txtBookingDetails.Text =
                "BOOKING APPROVED\r\n" +
                "Guest Name: " + name + "\r\n" +
                "Guest Age: " + age + "\r\n" +
                "Nights: " + nights + "\r\n" +
                "Guests: " + guests + "\r\n" +
                "Room Type: " + roomType + "\r\n" +
                "Rate Per Night: $" + rate.ToString("F2") + "\r\n" +
                "Room Cost: $" + roomCost.ToString("F2") + "\r\n" +
                "Breakfast: $" + breakfast.ToString("F2") + "\r\n" +
                "Subtotal: $" + subtotal.ToString("F2") + "\r\n" +
                "Night Discount: $" + nightDiscount.ToString("F2") + "\r\n" +
                "Senior Discount: $" + seniorDiscount.ToString("F2") + "\r\n" +
                "Service Charge: $" + serviceCharge.ToString("F2") + "\r\n" +
                "TOTAL COST: $" + total.ToString("F2");

            MessageBox.Show("Booking approved successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bookingApproved = false;

            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();
            txtBookingDetails.Items.Clear();

            rbStandard.Checked = false;
            rbNormal.Checked = false;
            rbHight.Checked = false;
            chkBreakfast.Checked = false;

            txtGuestName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
