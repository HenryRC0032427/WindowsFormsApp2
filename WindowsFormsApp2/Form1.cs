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
            Double R1 = Convert.ToDouble(textBox1.Text);
            Double R2 = Convert.ToDouble(textBox2.Text);
            Double R3 = Convert.ToDouble(textBox3.Text);
            Double R4 = Convert.ToDouble(textBox4.Text);

            Double T = (R1);
            label1.Text = "Total resistance = " + T;
            T = T + (R1 + R2);
            label2.Text = "Total resistance = " + T;
            T = T + (R1 + R2 + R3);
            label3.Text = "Total resistance = " + T;
            T = T + (R1 + R2 + R3 + R4);
            label4.Text = "Total resistance = " + T;


        }

        private void Series_Load(object sender, EventArgs e)
        {

        }
    }
}
