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

        //SImple way of making sure that a Textbox's Text is 
        //an Int.
        private string TextIsNum(ref TextBox txt)
        {
            int ix;
            string bean = txt.Text;
            if (Int32.TryParse(bean,out ix))
            {
                return bean;
            } else
            {
                return "";      //This both makes writing texts easier, &
                                //provides an occation for the error handler in Button1
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Again, easy way to get to the code.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TxtOrdNum.Text = TextIsNum(ref TxtOrdNum);  //This works, astonishingly!
        }

        private void TxtINum_TextChanged_1(object sender, EventArgs e)
        {
            TxtINum.Text = TextIsNum(ref TxtINum);
        }


        private string Labelling(string iType)
        {
            return "Text to put on the " + iType + ":"; //FAIRLY non-repeating way of doing this!
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
            TxtNumColor.Text = TextIsNum(ref TxtNumColor);

            int ix;
            if (TxtNumColor.Text != "")
            {
                ix = Int32.Parse(TxtNumColor.Text);
            } else
            {
                ix = 0;
            }
            //All this is to make it that there is at least 1 color 
            //for the logo, & 0 if there is no logo
            LogoOrderItem temp = new LogoOrderItem();  //for error handlers in LogoOrderItem
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
