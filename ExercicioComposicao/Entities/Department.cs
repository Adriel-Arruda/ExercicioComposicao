﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComposicao.Entities
{
    internal class Department
    {
        public string name { get; set; }
        public Department()
        {

        }
        public Department(string name)
        {
            this.name = name;
        }
    }
}
