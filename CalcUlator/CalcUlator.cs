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

        public double number = 0;

        private void CalcUlator_Load(object sender, EventArgs e)
        {
            lbl_Display.Text = number.ToString();
        }
    }
}
