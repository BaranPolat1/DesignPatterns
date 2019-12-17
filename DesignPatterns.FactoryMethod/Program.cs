using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GunFactory gunFactory = new GunFactory(new FactoryA());
            gunFactory.Produced();
            Console.ReadKey();

        }


       public interface IGuns
        {
            void createProduct();

        }


        class DesertEagle : IGuns
        {
            public void createProduct()
            {
                Console.WriteLine("Deser Eagle üretildi");
            }
        }

        public class Ak47 : IGuns
        {
            public void createProduct()
            {
                Console.WriteLine("Ak47 üretildi");
            }


        }

        public class M4 : IGuns
        {
            public void createProduct()
            {
                Console.WriteLine("M4 üretildi");
            }
        }
       public interface IGunsFactory
        {
            IGuns Created();
        }

        public class FactoryA : IGunsFactory
        {
            public IGuns Created()
            {
                return new M4();
            }
        }
        public class FactoryB : IGunsFactory
        {
            public IGuns Created()
            {
                return new Ak47();
            }
        }

        public class FactoryC : IGunsFactory
        {
            public IGuns Created()
            {
                return new DesertEagle();
            }
        }

        public class GunFactory
        {
            private IGunsFactory _igunsfactory;
           
            public GunFactory(IGunsFactory gunsFactory)
            {
                _igunsfactory = gunsFactory;
            }

            public void Produced()
            {
                Console.WriteLine("Produced");
                

            }
        }
         
    }
}
