using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Zadania
    {
        static void Main(string[] args)
        {

            // Zad1
            using (var sw = new StreamWriter("zad1.txt", append: true)) 
            {
                sw.WriteLine("24141");
            }

            // Zad2
            Console.WriteLine("Zadanie 2");
            using (var sr = new StreamReader("zad1.txt"))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }

            // Zad3
            Console.WriteLine("\n Zadanie 3");
            using(var sr = new StreamReader("pesels.txt"))
            {
                int licznik_M = 0;
                int licznik_K = 0;
                string pesel = sr.ReadLine();
                while(pesel != null)
                {
                    int number = pesel[9] - 48;

                    if (number % 2 == 0)
                    {
                        licznik_K++;
                    }
                    else
                        licznik_M++;

                    pesel = sr.ReadLine(); 
                }

                Console.WriteLine("Kobiety: " + licznik_K + " Mezczyzni: " + licznik_M);
            }
        }
    }
}


