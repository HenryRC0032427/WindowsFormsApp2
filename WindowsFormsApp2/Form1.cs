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
            Double R = Convert.ToDouble(textBox1.Text);

            Double T = R + R;
            label1.Text = "Total resistance = " + T;
            T = T + R;
            label2.Text = "Total resistance = " + T;
            T = T + R;
            label3.Text = "Total resistance = " + T;
            T = T + R;
            label4.Text = "Total resistance = " + T;


        }
    }
}
