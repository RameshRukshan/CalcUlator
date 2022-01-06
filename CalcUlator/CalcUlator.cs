using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcUlator
{
    public partial class CalcUlator : Form
    {
        public CalcUlator()
        {
            InitializeComponent();
        }

        public double number = 0, tmp = 0;
        public string Opr = "none";

        public void displayS()
        {
            lbl_Display.Text = number.ToString();
        }

        public void displaySNumT()
        {
            if (number > 0)
            {
                tmp = number;
                number = 0;
            }
            else if (number == 0 && tmp > 0)
            {

            }
            else
            {

            }

            lbl_tempValue.Visible = true;
            lbl_tempValue.Text = tmp.ToString();
            displayS();
        }

        private void CalcUlator_Load(object sender, EventArgs e)
        {
            displayS();
            lbl_operatorS.Visible = false;
            lbl_tempValue.Visible = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            number = 0;
            tmp = 0;
            displayS();
            lbl_operatorS.Visible = false;
            lbl_tempValue.Visible = false;
            Opr = "none";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            number = number * 10;
            displayS();
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            number = number * 100;
            displayS();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 1;
            displayS();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 2;
            displayS();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 3;
            displayS();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 4;
            displayS();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 5;
            displayS();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 6;
            displayS();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 7;
            displayS();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 8;
            displayS();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            number = (number * 10) + 9;
            displayS();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            displaySNumT();
            lbl_operatorS.Text = "X";
            lbl_operatorS.Visible = true;
            Opr = "mul";
            
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            displaySNumT();
            lbl_operatorS.Text = "/";
            lbl_operatorS.Visible = true;
            Opr = "div";
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            displaySNumT();
            lbl_operatorS.Text = "%";
            lbl_operatorS.Visible = true;
            Opr = "mod";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            displaySNumT();
            lbl_operatorS.Text = "-";
            lbl_operatorS.Visible = true;
            Opr = "min";
            
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            operations eq = new operations();
            eq.getValues(tmp, number, Opr);
            eq.calculateVal();
            number = eq.returnAns();
            displayS();
            lbl_operatorS.Visible = false;
            lbl_tempValue.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            displaySNumT();
            lbl_operatorS.Text = "+";
            lbl_operatorS.Visible = true;
            Opr = "add";
        }
    }
}
