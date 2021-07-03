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

        public bool HasLogo
        {
            get
            {
                return _LogoOrNo;
            }
            set
            {
                _LogoOrNo = value;
            }
        }

        public string ItemType
        {
            set
            {
                _ItemType = value;
            } 
            get
            {
                return _ItemType;
            }
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
                if (value<0)
                {
                    _ColorNumberOf = 0;
                }
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

            }
        }


    }
}
