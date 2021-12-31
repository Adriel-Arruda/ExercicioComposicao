using ExercicioComposicao.Entities.Enums;
using ExercicioComposicao.Entities;
using System.Globalization;
namespace ExercicioComposicao
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Department's name: ");
            string deptName= Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            string level = null;
            while (level != "Junior" && level != "Pleno" && level != "Senior")
            {
                Console.Write("level (Junior/Pleno/Senior): ");
                level = Console.ReadLine();
                if (level != "Junior" && level != "Pleno" && level != "Senior")
                {
                    Console.WriteLine("Write a valid level!");
                }

            }
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(level);
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(deptName);
            Worker worker = new Worker(name, workerLevel, baseSalary, department);

            Console.WriteLine("How many contract to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(dateContract, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine("Enter with mounth and year to calculate income (MM/YYYY): ");
            string mounthAndYear = Console.ReadLine();
            string[] date = mounthAndYear.Split('/');
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departmant: " + worker.Department.name);
            Console.WriteLine("Icome for " + mounthAndYear + ":" 
                              + worker.Income(int.Parse(date[1]), 
                                              int.Parse(date[0])));

        }
    }
}
