using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class BuilderProjectExamples2
    {
        static void Main(string[] args)
        {
            HamburgerDirector hamburger = new HamburgerDirector();
            var whooper = new Whooper();

            hamburger.generateHamburger(whooper);

            var model = whooper.Hamburger();

            Console.WriteLine(model.CompanyName);
            Console.WriteLine(model.Name);
            Console.WriteLine(model.ProductContent);


            Console.ReadKey();




        }


    }
  

    public  class Hamburger
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ProductContent { get; set; }
        public string CompanyName { get; set; }
    }

    abstract class Builder
    {
        public abstract void GetHamburgerData();
        public abstract void GetBranch();
        public abstract Hamburger Hamburger();

   }
    class Whooper : Builder
    {
        Hamburger hamburger = new Hamburger();
        public override void GetBranch()
        {
            hamburger.CompanyName = "Burger King";

        }

        public override void GetHamburgerData()
        {
            hamburger.ID = 1;
            hamburger.Name = "Whooper";
            hamburger.Price = (decimal)23.30;
            hamburger.ProductContent = "meat, cheddar, tomato";
        }

        public override Hamburger Hamburger()
        {
            return hamburger;
        }
    }
        class McChicken:Builder
        {
            Hamburger hamburger = new Hamburger();

            public override void GetBranch()
            {
                hamburger.CompanyName = "MC Donalds";
            }

            public override void GetHamburgerData()
            {
                hamburger.ID = 2;
                hamburger.Name = "Whooper";
                hamburger.Price = (decimal)15.90;
                hamburger.ProductContent = "chicken, tomato, lettuce";
            }

            public override Hamburger Hamburger()
            {
                return hamburger;
            }
        }

        class HamburgerDirector
        {
            public void generateHamburger(Builder builder)
            {

                builder.GetHamburgerData();
                builder.GetBranch();

            }

        }
    
}
