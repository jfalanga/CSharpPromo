using System;
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
                _ItemType = "mug";
                string tValue = value.ToLower();
                if (tValue=="pen"||tValue=="usb drive")
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
            
            decimal indPrice = 0;
            string tType = ItemType.ToUpper();
            switch (ItemType)
            {
                case "MUGS":
                    indPrice = 3.5M;
                    break;
                case "USB DRIVE":
                    indPrice = 4M;
                    break;
                case "PENS":
                    indPrice = 1M;
                    break;

                default:
                    throw new Exception("There is an item type, other than mugs, pens, or usb drive- this prgram doesn't have the code for that!");
            }
            if (Text!="") { indPrice += .05M; }
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
                if (value<0||!HasLogo)
                {
                    _ColorNumberOf = 0;
                }
                Calc();
            }
            
        }


        public int NumItems
        {
            get
            {
                return _ItemNumber;
            } set
            {
                if (value > 0)
                {
                    _ItemNumber = value;
                } else
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
            } set
            {

                _Text = value;
                Calc();
            }
        }

        public int ItemID
        {
            get;set;
        }

    }
}
