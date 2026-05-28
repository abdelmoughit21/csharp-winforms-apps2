using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {

            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);

        }

        float CalculateToppingsPrice()
        {

            float price = 0;

            if (chkExtraCheese.Checked)
            {

                price += Convert.ToSingle(chkExtraCheese.Tag);

            }

            if (chkMushrooms.Checked)
            {

                price += Convert.ToSingle(chkMushrooms.Tag);

            }

            if (chkOnion.Checked)
            {

                price += Convert.ToSingle(chkOnion.Tag);

            }

            if (chkOlives.Checked)
            {

                price += Convert.ToSingle(chkOlives.Tag);

            }

            if (chkTomatoes.Checked)
            {

                price += Convert.ToSingle(chkTomatoes.Tag);

            }

            if (chkGreenPeppers.Checked)
            {

                price += Convert.ToSingle(chkGreenPeppers.Tag);

            }

            return price;

        }

        float GetSelectedCrustTypePrice()
        {

            if (rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);

            else
                return Convert.ToSingle(rbThinCrust.Tag);

        }

        float CalculateTotalPrice()
        {

            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustTypePrice(); 

        }


        void UpdateTotalPrice()
        {

            lblTotalPriceResult.Text = "$" + CalculateTotalPrice().ToString();

        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {

                lblSizeResult.Text = rbSmall.Text;
                return;

            }

            if (rbMedium.Checked)
            {

                lblSizeResult.Text = rbMedium.Text;
                return;

            }

            if (rbLarge.Checked)
            {

                lblSizeResult.Text = rbLarge.Text;
                return;

            }

        }

        void UpdateCrustType()
        {

            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {

                lblCrustTypeResult.Text = rbThinCrust.Text;
                return;

            }

            if (rbThickCrust.Checked)
            {

                lblCrustTypeResult.Text = rbThickCrust.Text;
                return;

            }

        }

        void UpdateWhereToEat()
        {

            if (rbEatIn.Checked)
            {

                lblWhereToEatResult.Text = rbEatIn.Text;
                return;

            }

            if (rbTakeOut.Checked)
            {

                lblWhereToEatResult.Text = rbTakeOut.Text;
                return;

            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";

            if (chkExtraCheese.Checked)
            {

                Toppings = ", " + chkExtraCheese.Text;

            }

            if (chkMushrooms.Checked)
            {

                Toppings += ", " + chkMushrooms.Text;

            }

            if (chkGreenPeppers.Checked)
            {

                Toppings += ", " + chkGreenPeppers.Text;

            }

            if (chkOnion.Checked)
            {

                Toppings += ", " + chkOnion.Text;

            }

            if (chkOlives.Checked)
            {

                Toppings += ", " + chkOlives.Text;

            }

            if (chkTomatoes.Checked)
            {

                Toppings += ", " + chkTomatoes.Text;

            }

            if (Toppings.StartsWith(","))
            {

                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();

            }

            if(Toppings.Count() != 0)
            {

                lblToppingsResult.Text = Toppings;

            }
            else
            {

                lblToppingsResult.Text = "No Toppings";

            }
            
        }

        void ResetForm()
        {

            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            rbMedium.Checked = true;

            rbThinCrust.Checked = true;

            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkMushrooms.Checked = false;

            rbEatIn.Checked = true;

            btnOrderPizza.Enabled = true;

        }

        void UpdateOrderSummary()
        {

            UpdateSize();
            UpdateCrustType();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrustType();

        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrustType();

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {

            UpdateWhereToEat();

        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {

            UpdateWhereToEat();

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Confirm Order" , "Confirm" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question , MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                if(MessageBox.Show("Order Placed Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {

                    gbSize.Enabled = false;
                    gbCrustType.Enabled = false;
                    gbToppings.Enabled = false;
                    gbWhereToEat.Enabled = false;
                    btnOrderPizza.Enabled = false;

                }

            }

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            ResetForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
    }
}
