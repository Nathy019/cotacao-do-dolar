using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cotacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtDolar.Text =="")
            {
                MessageBox.Show("Informe um valor!", "Aviso!", MessageBoxButtons.OK);
                txtDolar.Focus();
                return;
            }
            txtReal.Text = (Convert.ToDouble(txtDolar.Text)*4.94).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDolar.Clear();
            txtReal.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
