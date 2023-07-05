using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Test
{
    interface iCommon
    {
        string strfrmName { get; set; } // Form Name

        /// <summary>
        /// 초기화 시 호출 한 From Name
        /// </summary>
        void fInit();

        /// <summary>
        /// 선택 색상을 기준으로 테마 변경
        /// </summary>
        /// <param name="color">변경할 색상</param>
        void fColorChange(Color color);
    

    }
}
