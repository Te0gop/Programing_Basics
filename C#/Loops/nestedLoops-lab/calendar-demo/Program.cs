using System;

namespace calendar_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int months = 0; months <= 12; months++)
            {
                for (int days = 0; days <= 30; days++)
                {
                    Console.WriteLine($"{months}/{days}");
                }
            }
        }
    }
}
