using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SinglePatterns
{
    class SingletonPattern
    {
        static void Main(string[] args)
        {
           
            
            
            var _singleton = new SingletonPattern();
            _singleton.Ekle();
            Console.WriteLine($"İşlem sonucu:{_singleton.Topla(1, 3)}");
            Console.ReadKey();

            
           
        }

        //Construcotr metodumuzu privet yaparak nesneye dışarıdan erişimi engelliyoruz.
        private SingletonPattern()
        {

        }

       
        private static SingletonPattern _singleton;
        //oluşturduğumuz fielda alttaki yazdığım property ile erişebiliyoruz.
        public static SingletonPattern CreateSingleton
        {
            get
            {
                //"return _singleton??" bize değer daha önce bu nesne oluşturulmuşsa onu döndürür, "_singleton = new SingletonPattern()" ise eğer oluşturmamışsa yeni oluşturur.
                return _singleton ?? (_singleton = new SingletonPattern());
            }

        }
        
        //Aşağıda ise sınıfa yetenek ve özellik tanımladım.
        public void Ekle()
        {
            Console.WriteLine("Eklendi!");
        }

        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }

       

        
    }
}
