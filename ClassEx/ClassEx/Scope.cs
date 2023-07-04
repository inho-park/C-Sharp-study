using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{
    class Scope
    {
        private int zoom = 1;

        public int getZoom(bool flag)
        {
            int zoom = 2;
            if (flag) return this.zoom;
            else return zoom;
        }
    }
}
