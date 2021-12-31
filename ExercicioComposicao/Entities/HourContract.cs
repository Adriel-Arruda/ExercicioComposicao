using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComposicao.Entities
{
    internal class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public double hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, double hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double TotalValue()
        {
            return hours * valuePerHour;
        }
    }
}
