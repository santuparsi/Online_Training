using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnInterfaces
{
    interface ILoan
    {
        void DocumentsRequired();
        double ROT { get; }
        int Tenure { get; }
    }
    class SBI : ILoan
    {
        double rot;
        int t;
        public SBI(double rot,int t)
        {
            this.rot = rot;
            this.t = t;
        }
        public double ROT => rot;

        public int Tenure => t;

        public void DocumentsRequired()
        {
           //Display documents required to apply load
        }
    }
    class Axis : ILoan
    {
        public double ROT => 6.7;

        public int Tenure => 180;

        public void DocumentsRequired()
        {
            
        }

    }

    class Demo1
    {
        static void Main()
        {
            SBI obj = new SBI(7.6, 120);
            Console.WriteLine("SBI Loan Info");
            Console.WriteLine("ROI: " + obj.ROT);
            Console.WriteLine("Tenure: " + obj.Tenure);
        }
    }
}
