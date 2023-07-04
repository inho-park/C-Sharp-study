using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{
    public class Cat
    {
        public static int cnt = 1;
        public string Name { get; set; } = "길고양이";
        public int Age { get; set; } = 1;

        

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public Cat(Cat mom)
        {
            this.Name = mom.Name + " " + cnt + "세";
        }
    }
}
