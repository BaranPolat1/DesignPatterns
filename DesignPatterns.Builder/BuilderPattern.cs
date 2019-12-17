using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class BuilderPattern
    {
        static void Main(string[] args)
        {
            ProductDirector productDirector = new ProductDirector();
            var builder = new ExpensiveCar();

            productDirector.Generate(builder);

            var model = builder.Product();

            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.Price);

            Console.WriteLine("-------------");

            var builder2 = new CheapCar();
            productDirector.Generate(builder2);

            var model2 = builder2.Product();

            Console.WriteLine(model2.CategoryName);
            Console.WriteLine(model2.Color);
            Console.WriteLine(model2.ProductName);

            Console.ReadKey();



            

            
            
        }

        
      //öncelikle oluşturacağım nesneme özelliklerini veriyorum
     public class Product
        {
            public int ID { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public string Color { get; set; }
            public decimal Price { get; set; }

        }

        abstract class ProductBuilder
        {
            public abstract void GetProductData();
            public abstract Product Product();

        }

        class ExpensiveCar : ProductBuilder
        {
            //pahalı araba sınıfımdan üreteceğim nesneme özelliklerini kazandırıyorum
            Product product1 = new Product();

           

            public override void GetProductData()
            {
                product1.ID = 1;
                product1.CategoryName = "Sprots Car";
                product1.ProductName = "Mercedes";
                product1.Color = "Red";
                product1.Price = (decimal)455.000;
            }

            public override Product Product()
            {
                return product1;
            }
        }

        class CheapCar : ProductBuilder
        {
            //ucuz araba sınıfından üreteceğim nesneme özellik kazandırıyorum
            Product product = new Product();

           

            public override void GetProductData()
            {
                product.ID = 2;
                product.CategoryName = "Sports Car";
                product.ProductName = "Fiat";
                product.Color = "White";
                product.Price = (decimal)75.000;
            }

            public override Product Product()
            {
                return product;
            }
        }

        //nesnemi yaratma işlemine başlıyorum
        class ProductDirector
        {
            
            public void Generate(ProductBuilder productBuilder)
            {

                productBuilder.GetProductData();
               
            }
            

        }
    }
}
