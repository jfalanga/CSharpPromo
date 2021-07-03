using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string TxtIsNum(ref TextBox txt)
        {
            int ix;
            string bean = txt.Text;
            if (Int32.TryParse(bean,out ix))
            {
                return bean;
            } else
            {
                return "";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TxtPens.Text = TxtIsNum(ref TxtPens);
        }

        private void TxtUSB_TextChanged(object sender, EventArgs e)
        {
            TxtUSB.Text = TxtIsNum(ref TxtUSB);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtCoffee_TextChanged(object sender, EventArgs e)
        {
            TxtCoffee.Text = TxtIsNum(ref TxtCoffee);
        }

        private void ChkChanged(object sender, EventArgs e)
        {
            TxtCoffee.Enabled = ChkCoffee.Checked;
            TxtPens.Enabled = ChkPens.Checked;
            TxtUSB.Enabled = ChkUSB.Checked;
        }

        private void ChkCanged(object sender, EventArgs e)
        {

        }
    }
}
