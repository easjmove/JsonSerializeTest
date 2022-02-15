﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeTest.Models
{
   public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int MonthsEmployed { get; set; }
        public List<string> JobAreas { get; set; }
    }
}
