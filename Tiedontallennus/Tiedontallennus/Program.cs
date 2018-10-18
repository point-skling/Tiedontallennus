using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tiedontallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\Temp\Lämpötila.txt";

            //luetaan tiedostosta aiemmin asetettu lämpötila.
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on: "+ aiempiArvo + " astetta.");
            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen

            
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila on asetettu.");

            Console.ReadLine();
        }
    }
}
