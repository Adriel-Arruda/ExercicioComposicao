using ExercicioComposicao.Entities.Enums;
using ExercicioComposicao.Entities;
using System.Collections.Generic;

namespace ExercicioComposicao.Entities
{
    internal class Worker
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int mounth)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.date.Year == year && contract.date.Month == mounth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
