using SDAM_assignement_2.Class;
using System;
using System.Windows.Forms;

namespace SDAM_assignement_2.Forms
{
    public partial class Makepaymentform : Form
    {
        private const decimal AmountPerMonth = 2000;
        private Makepaymentcontroller controller;
        private decimal totalAmount;

        public Makepaymentform()
        {
            InitializeComponent();
            controller = new Makepaymentcontroller();
        }

        public string Username
        {
            get { return username.Text; }
            set { username.Text = value; }
        }

        public int Months
        {
            get
            {
                return int.TryParse(month.Text, out int months) && months >= 1 && months <= 12 ? months : 1;
            }
            set
            {
                month.Text = (value >= 1 && value <= 12) ? value.ToString() : "1";
            }
        }

        public decimal Amount
        {
            get
            {
                return decimal.TryParse(calculation.Text, out decimal amount) && amount >= 2000 ? amount : 2000m;
            }
            set
            {
                calculation.Text = (value >= 2000) ? value.ToString("0.00") : "2000.00";
            }
        }

        public string PaymentMethod
        {
            get
            {
                if (ontranfer.Checked)
                    return "Online transfer";
                if (card.Checked)
                    return "Card payment";

                return string.Empty; // No payment method selected
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(PaymentMethod))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // Call the controller to make the 
            bool isSucess = controller.MakePayment(Username, Months, totalAmount);
            if (isSucess)
            {
                MessageBox.Show("Payment processed successfully!");
            }
            else
            {
                MessageBox.Show("erorrrrrrrrrrrrrrrrrrrrr");
            }

        }

        private void month_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calculation_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                // Get the number of months from the NumericUpDown control
                int months = (int)month.Value;

                // Calculate the total amount to be paid
                totalAmount = months * AmountPerMonth;
                // Display the result in the RichTextBox
                calculation.Text = $"Number of Months: {months}\nTotal Amount to be Paid Rs: ${totalAmount:F2}";
            }
        }

        private void Makepaymentform_Load(object sender, EventArgs e)
        {

        }

        private void ontranfer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}