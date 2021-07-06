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
        

        private void Form1_Load(object sender, EventArgs e)
        {
            LogoOrderItem l = new LogoOrderItem();
            Text = l.GetOrderSummary();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TxtOrdNum.Text = TxtIsNum(ref TxtOrdNum);
        }

        private void TxtINum_TextChanged_1(object sender, EventArgs e)
        {
            TxtINum.Text = TxtIsNum(ref TxtINum);
        }


        private string Labelling(string iType)
        {
            return "Text to put on the " + iType + ":";
        }
        private void RadMug_CheckedChanged(object sender, EventArgs e)
        {
            LblText.Text = Labelling("Mugs");
        }

        private void RadPen_CheckedChanged(object sender, EventArgs e)
        {
            LblText.Text = Labelling("Pens");
        }

        private void RadUSB_CheckedChanged(object sender, EventArgs e)
        {
            LblText.Text = Labelling("USB Devices");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogoOrderItem loi = new LogoOrderItem();
            loi.Text = TxtText.Text;
            loi.HasLogo = ChkLogo.Checked;
            loi.ItemID = Int32.Parse(TxtOrdNum.Text);

        }

        private void TxtNumColor_TextChanged(object sender, EventArgs e)
        {
            TxtNumColor.Text = TxtIsNum(ref TxtNumColor);

            int ix;
            if (TxtNumColor.Text != "")
            {
                ix = Int32.Parse(TxtNumColor.Text);
            } else
            {
                ix = 0;
            }
            LogoOrderItem temp = new LogoOrderItem();
            temp.HasLogo = ChkLogo.Checked;
            temp.NumColors = ix;
            if (ix!=temp.NumColors)
            {
                TxtNumColor.Text = temp.NumColors.ToString();
            }
        }
    }
}
