using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    public class Set : ProductGeneral
    {
        public Product[] ProductArray { get; set; }
        public Set(string name, double price, Product[] prodArray)
            {
            Name = name;
            Price = price;
            ProductArray = prodArray;
            }
        public void SetOfProducts(Product[] prodArray)
        { 
        foreach (Product product in prodArray)
            {
                IsExpired(product);
            }
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

        public override void ProductInfo(ProductGeneral prodgen)
        {
            Console.WriteLine($"The Set name is {Name}");
            Console.WriteLine($"The Set price is {Price}");
            int i = 0;
            foreach (Product product in ProductArray)
            {
                Console.WriteLine($"The product{i}'s name from the Set is {product.Name}");
                Console.WriteLine($"The product{i}'s price from the Set is {product.Price}");
                Console.WriteLine($"The product{i}'s Production Date from the Set is {product.ProductionDate}");
                Console.WriteLine($"The product{i}'s Expire Date from the Set is {product.ExpireDate}");
                IsExpired(product);
                i++;
            }
        }


    }
}
