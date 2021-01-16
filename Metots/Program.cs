using System;

namespace Metots
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "televizyon";
            product1.price = 2500;
            product1.desciption = "tv;";

            Product product2 = new Product();
            product2.name = "telefon";
            product2.price = 3000;
            product2.desciption = "mobil";
            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.name);
                Console.WriteLine(product.desciption);
                Console.WriteLine(product.price);
                Console.WriteLine("-------");
            }

            Console.WriteLine( "----------metotlar-------");
            //doğru şekilbu
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            //gereksiz ekstra eklersen add2 ye tüm kod patlıyor
            sepetManager.Add2("armut", "yeşil armut", 12);
            sepetManager.Add2("elma", "yeşil elma", 5);
            sepetManager.Add2("karpuz", "diarbekir", 3);


        }
    }
}



//do not repeat yourself