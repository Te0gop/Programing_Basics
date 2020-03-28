using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());
            double area = yards * 7.61;
            double discount = area * 0.18;
            double finalPrice = area - discount;
            Console.WriteLine("The final price is: {0:F2} lv.", finalPrice);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);

        }
    }
}
