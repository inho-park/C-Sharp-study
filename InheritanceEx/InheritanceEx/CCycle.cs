﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace InheritanceEx
{
    class CCycle : CBase
    {
        public Rectangle _rtCircle1; // 바퀴
        public Rectangle _rtCircle2; // 바퀴 2
        public Rectangle _rtSquare1; // 몸통

        public CCycle(string sName)
        {
            strName = sName;
            pen = new Pen(Color.Black, 3);

            _rtCircle1 = new Rectangle(30, 150, 120, 120);
            _rtCircle2 = new Rectangle(210, 150, 120, 120);
            _rtSquare1 = new Rectangle(60, 90, 240, 60);
        }
    }
}
