﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPromo
{
    class LogoOrderItem
    {
        private bool _LogoOrNo;
        private string _ItemType;
        private int _ColorNumberOf;
        private int _ItemNumber;
        private string _Text;
        private decimal _tPrice;
        private bool isConstr;

        public LogoOrderItem(int iId, string iType, int nClr, int nItem, bool logo, string tText)
        {
            isConstr = true;        //There are issues if I run the Calc() before I set most of these things
            ItemID = iId; ItemType = iType; NumColors = nClr;
            NumItems = nItem; HasLogo = logo;

            isConstr = false; Text = tText; //There should be enough set for this to work, now!
        }


        public LogoOrderItem() : this(-1, "goof", 0, 0, false, "")      //"mug" is a default value, so this will still be "mug"
        {

        }


        public LogoOrderItem(bool LogoOrNo, string tText) : this()
        {
            HasLogo = LogoOrNo;
            Text = tText;
        }

        public decimal tPrice
        {
            private set
            {
                _tPrice = value;
            }
            get
            {
                return _tPrice;
            }
        }

        public bool HasLogo
        {
            get
            {
                return _LogoOrNo;
            }
            set
            {
                _LogoOrNo = value;
                Calc();
            }
        }

        public string ItemType
        {
            set
            {
                _ItemType = "mug";          //this way "mug" is genuinely the default value
                string tValue = value.ToLower();
                if (tValue == "pen" || tValue == "usb drive")
                {
                    _ItemType = value;
                }
                Calc();
            }
            get
            {
                return _ItemType;
            }
        }

        private void Calc()
        {
            if (isConstr)
            {
                return;
            }
            decimal indPrice = 0;
            //try 
            string tType = ItemType.ToUpper();
            switch (tType)
            {
                case "MUG":
                    indPrice = 3.5M;
                    break;
                case "USB DRIVE":
                    indPrice = 4M;
                    break;
                case "PEN":
                    indPrice = 1M;
                    break;

                default:
                    throw new Exception("There is an item type, other than mugs, pens, or usb drive- this prgram doesn't have the code for that!");
            }
            if (Text != "") { indPrice += .05M; }
            indPrice = indPrice + ((decimal)NumColors * .03M);
            if (HasLogo)
            {
                indPrice += .1M;
            }
            tPrice = indPrice * NumItems;
        }



        public int NumColors
        {
            get
            {

                return _ColorNumberOf;
            }
            set
            {
                _ColorNumberOf = value;
                //I don't want a NEGATIVE # of colors; & if there is
                //no Logo, we don't want ANY colors at all!
                //no Logo, we don't want ANY colors at all!
                if (value < 0 || !HasLogo)
                {
                    _ColorNumberOf = 0;
                }
                else if (value < 1 && HasLogo)
                {
                    _ColorNumberOf = 1;
                }
                Calc();
            }

        }


        public int NumItems
        {
            get
            {
                return _ItemNumber;
            }
            set
            {
                if (value > 0)
                {
                    _ItemNumber = value;
                }
                else
                {
                    _ItemNumber = 0;
                }
                Calc();
            }
        }

        public string Text
        {
            get
            {
                return _Text;
            }
            set
            {

                _Text = value;
                Calc();
            }
        }

        public int ItemID
        {
            get; set;
        }

        public string GetOrderSummary()
        {
            string maybe = "";
            if (HasLogo)
            {
                maybe = "a " + NumColors + " color logo, and ";
            }
            string tText = "no text on it";
            if (Text!="")
            {
                tText = "the following text: " + Text;
            }
            return String.Format("Order number {0}: {1} with {2}{3}. {4} of them, so the price is: ${5}", ItemID, ItemType, maybe, tText, NumItems, tPrice);
        }
    }
}
