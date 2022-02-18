using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWinforms
{
    public partial class frm_calculator : Form
    {
        public frm_calculator()
        {
            InitializeComponent();
        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            if (txt_data.Text != "" && txt_data.Text != "0")
            {
                txt_data.Text += "0";
            }
            else
            {
                txt_data.Text = "0";
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "1";
            }
            else
            {
                txt_data.Text += "1";
            }
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "2";
            }
            else
            {
                txt_data.Text += "2";
            }

        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "3";
            }
            else
            {
                txt_data.Text += "3";
            }
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "4";
            }
            else
            {
                txt_data.Text += "4";
            }
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "5";
            }
            else
            {
                txt_data.Text += "5";
            }
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "6";
            }
            else
            {
                txt_data.Text += "6";
            }
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "7";
            }
            else
            {
                txt_data.Text += "7";
            }
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "8";
            }
            else
            {
                txt_data.Text += "8";
            }
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            if (txt_data.Text == "0")
            {
                txt_data.Text = "";
                txt_data.Text = "9";
            }
            else
            {
                txt_data.Text += "9";
            }
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            txt_data.Text += ".";
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            txt_data.Text = "0";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string removed = txt_data.Text.Remove(txt_data.Text.Length -1, 1);
                txt_data.Text = removed;
                if (txt_data.Text == "")
                {
                    txt_data.Text = "0";
                }
            }
            catch (Exception)
            {
                txt_data.Text = "0";
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            txt_data.Text += "+";
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            txt_data.Text += "-";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            txt_data.Text += "*";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            txt_data.Text += "/";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(txt_data.Text, null);
                txt_data.Text = Convert.ToString(result);
            }
            catch (Exception)
            {
                txt_data.Text = "Invalid Input";
            }
            
        }
    }
}
