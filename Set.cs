using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    public class Set : Product
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


        public override void ProductInfo(Product prod)
        {
            Console.WriteLine($"The Set name is {Name}");
            Console.WriteLine($"The Set price is {Price}");
            int i = 0;
            bool exp = true;
            foreach (Product product in ProductArray)
            {
                exp = IsExpired(product);
                if (!exp)
                {
                    Console.WriteLine("There are expired products in the batch.");
                    break;
                }
                Console.WriteLine($"The product{i}'s name from the Set is {product.Name}");
                Console.WriteLine($"The product{i}'s price from the Set is {product.Price}");
                Console.WriteLine($"The product{i}'s Production Date from the Set is {product.ProductionDate}");
                Console.WriteLine($"The product{i}'s Expire Date from the Set is {product.ExpireDate}");
                i++;
            }
            if ( exp ) 
            Console.WriteLine("All the products in the Set are OK.");
        }


    }
}
