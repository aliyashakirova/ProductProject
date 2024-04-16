using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    public class Batch : ProductGeneral
    {
        public int Amount { get; set; }
        public Batch(string name, double price, int am, DateTime prodDate, DateTime ExpDate)
        {
            Name = name;
            Price = price;
            ProductionDate = prodDate;
            ExpireDate = ExpDate;
            Amount = am;
        }

        public override void ProductInfo(ProductGeneral prodgen)
        {
            Console.WriteLine($"The batch name is {Name}");
            Console.WriteLine($"The batch price is {Price}");
            Console.WriteLine($"The batch production date is {ProductionDate}");
            Console.WriteLine($"The batch expire date is {ExpireDate}");
            Console.WriteLine($"The amount of batch is {Amount}");
            IsExpired(prodgen);
        }

        //public void BatchOfProducts(Batch batch)
        //{
        //        IsExpired(batch);
        //}

    }
}
