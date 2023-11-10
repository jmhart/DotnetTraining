using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class ExampleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CalculateSum(int a, int b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("Arguments cannot be null.");
            }
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Arguments must be non-negative.");
            }

            return a + b;
        }
    }
}