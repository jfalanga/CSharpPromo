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
            string whereIssue="The Text to engrave, or the Logo...";
            try
            {
                LogoOrderItem loi = new LogoOrderItem();
                loi.Text = TxtText.Text;
                loi.HasLogo = ChkLogo.Checked;
                whereIssue = "Order Number or the Item type";
                loi.ItemID = Int32.Parse(TxtOrdNum.Text);
                if (RadMug.Checked)
                {
                    loi.ItemType = "muG";   //Hee hee! I mean mug- that's how it'll work!
                }
                else if (RadUSB.Checked)
                {
                    loi.ItemType = "USB drive";
                }
                else if (RadPen.Checked)
                {
                    loi.ItemType = "pEN";
                }
                whereIssue = "The Textbox with the number of colors.";
                loi.NumColors = Int32.Parse(TxtNumColor.Text);
                whereIssue = "textbox for the number of items:";
                loi.NumItems = Int32.Parse(TxtINum.Text);
                TxtSummery.Text = loi.GetOrderSummary();
            } catch (Exception exc)
            {
                TxtSummery.Text = exc.Message+" with (or around) "+whereIssue;
            }
            
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

        private void ChkLogo_CheckedChanged(object sender, EventArgs e)
        {
            TxtNumColor_TextChanged(sender, e);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtINum.Text = "0";
            TxtNumColor.Text = "0";
            TxtOrdNum.Text = "0";
            TxtSummery.Text = "";
            TxtText.Text = "";
            ChkLogo.Checked = false;
        }
    }
}
