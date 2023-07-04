using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace matrix
{
    enum CurrentStatus
    {
        상태1,
        상태2,
        상태3,
        상태4
    }

    enum CurrentSort 
    { 
        X행순서 = 1,
        Y행순서,
        X행지그재그,
        Y행지그재그,
        X와Y값
    }


    class Block
    {
        private int clickCount;
        private string status;
        public Block()
        {
            clickCount = 0;
            status = "";
        }

        public Block(string status)
        {
            clickCount = 0;
            this.status = status;
        }

        public int ClickCount
        {
            get { return clickCount; }
            set { clickCount++; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
