using System;

namespace ProjectSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int numProjects = projects * 3;
            Console.WriteLine("The architect {0} will need {2} hours to complete {1} project/s.", name, projects, numProjects);
        }
    }
}
