using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace InheritanceEx
{
    class CBase
    {
        public string strName;
        protected Pen pen;
        public CBase()
        {
            pen = new Pen(Color.Aqua);
        }

        public Pen fPenInfo()
        {
            return pen;
        }
    }
}
