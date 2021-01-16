using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1= new Kurs();
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 16;
            kurs1.KursAdi = "c#";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.IzlenmeOrani = 24;
            kurs2.Egitmen = "berkay";

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "sinancan";
            kurs3.IzlenmeOrani = 8;
            kurs3.KursAdi = "asp";


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" :"+ kurs.IzlenmeOrani + " :" + kurs.Egitmen);
                
            }


            Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
        }
    }


    class Kurs
    {
        
        
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
