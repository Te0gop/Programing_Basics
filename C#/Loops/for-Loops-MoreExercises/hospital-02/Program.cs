using System;

namespace hospital_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOne = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int unTreatedPatients = 0;
            int doctors = 7;
         


            for (int i = 1; i <= dayOne; i++)
            {
                int numOfPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && unTreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if (numOfPatients <= doctors)
                {
                    treatedPatients += numOfPatients;
                }
                else 
                {
                    unTreatedPatients += numOfPatients - doctors;
                    treatedPatients += doctors;
                }
            
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPatients}.");
        }
    }
}
