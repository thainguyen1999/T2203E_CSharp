using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.ss1
{
    internal class Human
    {
        public string name;
        public int age;

        private int id;

        public static int x;
        public Human()
        {

        }
        public Human(string s)
        {
            this.name = s;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Email { get; set; }

        public void run()
        {
            Console.WriteLine("Running....");
            this.name = "Hoang Bich Thuy";
        }
        public static void run(string s)
        {

        }
        public static void ScreenShort()
        {

        }
        public  void eat()
        {

        }

    }
}
