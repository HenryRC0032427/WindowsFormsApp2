using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5;

            try
            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }

            try
            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }

            try
            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }

            try
            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            } 

            try
            {
                R5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R5 = 0;
            }


            Double T = R1 + R2;
            label15.Text = "Total resistance = " + T;
            T =  R1 + R2+ R3;
            label16.Text = "Total resistance = " + T;
            T = R1 + R2 + R3 + R4;
            label17.Text = "Total resistance = " + T;
            T = R1 + R2 + R3 + R4 + R5;
            label18.Text = "Total resistance = " + T;



        }



        private void button2_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5;

            try
            {
                R1 = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                R1 = Double.PositiveInfinity;
            }

            try
            {
                R2 = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                R2 = Double.PositiveInfinity;
            }

            try
            {
                R3 = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                R3 = Double.PositiveInfinity;
            }

            try
            {
                R4 = Convert.ToDouble(textBox9.Text);
            }
            catch
            {
                R4 = Double.PositiveInfinity;
            }

            try
            {
                R5 = Convert.ToDouble(textBox10.Text);
            }
            catch
            {
                R5 = Double.PositiveInfinity;
            }


            double T = 1/(1 / R1 + 1 / R2);
            label20.Text = "Total resistance = " + T;
            T = 1/(1 / R1 + 1 / R2 + 1 / R3);
            label22.Text = "Total resistance = " + T;
            T = 1/(1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
            label24.Text = "Total resistance = " + T;
            T = 1/(1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
            label26.Text = "Total resistance = " + T;

        }
    }
}
