using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_avanzada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            
            double numero1;
            double numero2;
            double res; ;

            numero1 = System.Convert.ToDouble(txtnum1.Text);
            numero2 = System.Convert.ToDouble(txtnum2.Text);

            res = numero1 + numero2;

            txtsum.Text = Convert.ToString(res);

            res = numero1 - numero2;

            txtres.Text = Convert.ToString(res);

            res = numero1 * numero2;

            txtpor.Text = Convert.ToString(res);

            res = numero1 / numero2;

            txtdiv.Text = Convert.ToString(res);




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
