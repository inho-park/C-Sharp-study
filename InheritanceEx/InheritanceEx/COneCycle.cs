using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace InheritanceEx
{
    // 상속하기
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1; // 바퀴
        public Rectangle _rtSquare1; // 몸통

        public COneCycle(string sName)
        {
            strName = sName;
            pen = new Pen(Color.WhiteSmoke, 3);

            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);
        }
    }
}
