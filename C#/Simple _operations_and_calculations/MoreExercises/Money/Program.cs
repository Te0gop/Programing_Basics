using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoins = int.Parse(Console.ReadLine());
            decimal uans = decimal.Parse(Console.ReadLine());
            decimal commission = decimal.Parse(Console.ReadLine()) / 100m;
            decimal bitLV = bitcoins * 1168;
            decimal uansUSD = uans * 0.15m;
            decimal uansLV = uansUSD * 1.76m;
            decimal money = bitLV + uansLV;
            decimal moneyEUR = money / 1.95m;
            decimal comm = moneyEUR - (commission * moneyEUR);
            Console.WriteLine(comm);



        }
    }
}
