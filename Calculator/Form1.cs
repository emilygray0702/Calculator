using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static int mem;
        public static int current_num;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            lbl.ResetText();
            mem = 0;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {

        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            mem = current_num;
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            current_num = mem;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl.Text += "3";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int.TryParse(lbl.Text, out current_num);
            lbl.Text += "+";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl.Text += "6";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int.TryParse(lbl.Text, out current_num);
            lbl.Text += "-";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {

        }

        private void btn_9_Click(object sender, EventArgs e)
        {

        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {

        }

        private void btn_equals_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {

        }

        private void btn_point_Click(object sender, EventArgs e)
        {

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {

        }
    }
}
