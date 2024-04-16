using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    public class Product: ProductGeneral
    { 
        public Product(string n, double p, DateTime pd, DateTime ed)
            {
            Name = n;
            Price = p;
            ProductionDate = pd;
            ExpireDate = ed;
            }
        public override bool IsExpired(ProductGeneral prodgen)
        {
            bool exp = false;
            if (prodgen.ExpireDate < DateTime.Now)
            {
                Console.WriteLine("It's an expired product");
                exp = true;
            }
            return exp;
        }
    }
}
