using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma2
{
    class Program
    {
       public class Rectangle
        {
            private double width;
            public double length;

            public void Deger()
            {
                Console.WriteLine("Width değerini girin.");
                width = Convert.ToInt32(Console.ReadLine());
            }
            public double getArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length:{0}", length);
                Console.WriteLine("Width : {0}", width);
                Console.WriteLine("Area:{0}", getArea());
            }
           
        }
        
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();//sınıfımızın nesnesini oluşturduk.
            r.Deger();
            r.length = 2.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
