using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public virtual void ProductInfo(Product product)
        {
            Console.WriteLine($"The product name is {product.Name}");
            Console.WriteLine($"The price is {product.Price}");
            Console.WriteLine($"The production date is {product.ProductionDate}");
            Console.WriteLine($"The expiration date is {product.ExpireDate}");
            if (IsExpired(product))
                Console.WriteLine("The product is expired.");
            else
                Console.WriteLine("The product is ok");
        }

        public virtual bool IsExpired(Product product)
        {
            bool exp = false;
            if (product.ExpireDate < DateTime.Now)
            {
                //Console.WriteLine("It's expired");
                exp = true;
            }
            return exp;
        }
        public Product(string name, double price, DateTime pd, DateTime ed)
            {
            Name = name;
            Price = price;
            ProductionDate = pd;
            ExpireDate = ed;
            }
        public Product()
        {

        }


        //public override bool IsExpired(Product product)
        //{
        //    bool exp = false;
        //    if (product.ExpireDate < DateTime.Now)
        //    {
        //        Console.WriteLine("It's an expired product");
        //        exp = true;
        //    }
        //    return exp;
        //}
    }
}
