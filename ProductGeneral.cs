using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    public class ProductGeneral
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public virtual void ProductInfo(ProductGeneral prodgen)
        {
            Console.WriteLine($"The name is {prodgen.Name}");
            Console.WriteLine($"The price is {prodgen.Price}");
            Console.WriteLine($"The production date is {prodgen.ProductionDate}");
            Console.WriteLine($"The expiration date is {prodgen.ExpireDate}");
            IsExpired(prodgen);
        }

        public virtual bool IsExpired(ProductGeneral prodgen)
        {
            bool exp = false;
            if (prodgen.ExpireDate < DateTime.Now)
            {
                Console.WriteLine("It's expired");
                exp = true;
            }
            return exp;
        }
    }
}
