using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeTest.Models
{
   public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }

        public override string ToString()
        {
            return $"Brand: - {Brand} - Model: {Model} - Color: {Color} - Mileage: {Mileage}";
        }
    }
}
