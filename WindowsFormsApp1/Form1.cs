using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.operatorLable.Text = "÷";

            if (this.label1.Text != "")
            {
                this.firstLable.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.operatorLable.Text = "X";

            if (this.label1.Text != "")
            {
                this.firstLable.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.operatorLable.Text = "+";

            if (this.label1.Text != "")
            {
                this.firstLable.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.operatorLable.Text = "-";

            if (this.label1.Text != "")
            {
                this.firstLable.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double fn, ln, r = 0;

            double.TryParse(this.firstLable.Text, out fn);
            double.TryParse(this.label1.Text, out ln);



            if (this.operatorLable.Text == "+") { r = fn + ln; }

            if (this.operatorLable.Text == "-") { r = fn - ln; }

            if (this.operatorLable.Text == "X") { r = fn * ln; }

            if (this.operatorLable.Text == "÷") { r = fn / ln; }

            this.label1.Text = r.ToString();
            this.operatorLable.Text = "";
            this.firstLable.Text = "";
        }



    }
}      