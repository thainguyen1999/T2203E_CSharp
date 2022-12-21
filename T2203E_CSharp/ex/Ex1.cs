using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.ex
{
    internal class Ex1
    {
        public int TS { get; set; }
        public int MS { get; set; }

        // property cho phép lấy giá trị  thập phân của phân số
        public double Value
        {
            get { return (double)TS / MS;}
        }
        // hàm dựng không tham số
        public Ex1()
        {
            TS= 0;
            MS= 1;
        }
        // hàm dựng có tham số
        public Ex1(int numerator, int denominator)
        {
            TS = numerator;
            MS = denominator;
        }
        // phương thức in phân số
        public void Print()
        {
            Console.WriteLine("{0}/{1}",TS,MS);
        }
        //tìm ước chung lớn nhất của 2 số
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a= temp;
            }
            return a;
        }
        // phương thức rút gọn phân số
        public void Simplify()
        {
            int gcd= GCD(TS,MS);
            TS /= gcd;
            MS /= gcd;
        }
    }
}
