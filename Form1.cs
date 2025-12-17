using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        byte Total_Price = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

            MakeChangesSizeLabel(rbSmall,20,label1);
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesSizeLabel(rbMedium,30, label1);
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesSizeLabel(rbLarg,40, label1);
        }

        private void chkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesToppingsLabel(chkBox1);
        }

        private void chkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesToppingsLabel(chkBox2);
        }

        private void chkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesToppingsLabel(chkBox3);
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesToppingsLabel(chkOnion);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesToppingsLabel(chkOlives);
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesToppingsLabel(chkGreenPappers);           
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesSizeLabel(rdThin, 0, label3);

        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesSizeLabel(rdThick,10, label3);
        }

        private void rdIn_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesSizeLabel(rdIn, 0, label4);
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            MakeChangesSizeLabel(rdTakeOut, 0, label4);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grBoxSize.Enabled = true;
            grBoxToppings.Enabled = true;
            grBoxCrust.Enabled = true;
            grEatPlace.Enabled = true;
            btnOrder.Enabled = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                    grBoxSize.Enabled = false;
                    grBoxToppings.Enabled = false;
                    grBoxCrust.Enabled = false;
                    grEatPlace.Enabled = false;
                    btnOrder.Enabled = false;              
                
            } else
            {
                MessageBox.Show("Update Your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void MakeChangesToppingsLabel(CheckBox Currentchk)
        {
            byte CurrentPrice = 5;
            if (Currentchk.Checked)
            {
                Total_Price += CurrentPrice;
                label2.Text = label2.Text.Replace("No Toppings", "");
                label5.Text = ("$" + Convert.ToString(Total_Price));

                if (label2.Text == string.Empty)
                    label2.Text += Currentchk.Text;
                else
                    label2.Text += (", " + Currentchk.Text);

            }
            else
            {

                label2.Text = label2.Text.Replace(", " + Currentchk.Text, "");
                label2.Text = label2.Text.Replace(Currentchk.Text, "");

                Total_Price -= CurrentPrice;
                label5.Text = ("$" + Convert.ToString(Total_Price));

                if (label2.Text == string.Empty)
                    label2.Text = "No Toppings";

            }
        }

        private void MakeChangesSizeLabel(RadioButton rbSize,byte CurrentPrice, Label Label)
        {
            if (rbSize.Checked == true)
            {
                Total_Price += CurrentPrice;
                label5.Text = ("$" + Convert.ToString(Total_Price));
                Label.Text = rbSize.Text;

            }
            else
            {
                Total_Price -= CurrentPrice;
                label5.Text = ("$" + Convert.ToString(Total_Price));

            }
        }
    }
    
}
