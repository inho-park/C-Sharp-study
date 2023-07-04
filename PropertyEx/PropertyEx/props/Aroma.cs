using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEx.props
{
    class Aroma
    {
        private double drop;

        /// <summary>
        /// itteki 가 setter 로 사용될 때 => drop 값 반환
        /// itteki 가 getter 로 사용될 때 => value = getter 를 통해 초기화하는 값을 의미
        /// </summary>
        public double Itteki
        {
            get
            {
                return drop;
            }
            set
            {
                drop = value;
            }
        }

        private int[] arr = new int[2];

        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }
}
