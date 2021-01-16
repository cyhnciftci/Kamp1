using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"yazılım geliştirici kampı",
                "başlangıç için temel kurs", "java", "phyton", "C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("footer");
        }
    }
}
