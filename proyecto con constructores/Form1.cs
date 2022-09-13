using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyecto_con_constructores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             CLSOP PP = new CLSOP();
            PP.N1 = double.Parse(textBox1.Text);
            PP.N2 = double.Parse(textBox2.Text);

            CLSOP OO = new CLSOP(double.Parse(textBox1.Text),
            double.Parse(textBox2.Text));  textBox3.Text = OO.DVSN().ToString();

        }
    }
}
