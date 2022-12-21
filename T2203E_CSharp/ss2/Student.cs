using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2203E_CSharp.ss1;

namespace T2203E_CSharp.ss2
{
    internal class Student : Human
    {
        public string[] telephone = new string[3];
        public Student()
        {

        }
        public Student(string s, int a) : base(s)
        {
            this.age= a;
        }

        public string this[int index]
        {
            get => telephone[index];
            set => telephone[index]= value;
         }
        public void Study()
        {
            base.run(); // chạy run của Human 
            this.run(); // chạy run ở dưới
        }
        public new void run()
        {

        }
    }
   
}
