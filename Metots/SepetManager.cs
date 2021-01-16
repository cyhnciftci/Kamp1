using System;
using System.Collections.Generic;
using System.Text;

namespace Metots
{
    class SepetManager
    {
        //naming convention
        public void Add(Product product)
        {

            Console.WriteLine("sepete eklendi ;" + product.name);

        }
        public void Add2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("sepete eklendi ;" + urunAdi);
        }
    }
}
