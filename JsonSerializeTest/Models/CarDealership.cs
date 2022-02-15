using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeTest.Models
{
   public class CarDealership
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }
        public List<Employee> Employees { get; set; }

        public CarDealership()
        {
            if (Cars == null)
            {
                Cars = new List<Car>();
            }
            if (Employees == null)
            {
                Employees = new List<Employee>();
            }
        }
    }
}
