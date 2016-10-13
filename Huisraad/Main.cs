using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisraad
{
    class main
    {
        static void Main(string[] args)
        {
            string wilvanRobin = "nogeenkeer";

            Goed g1 = new Tafel("de tafel", 2, 100.00, "Dinnermaster 2000", "Hout");
            Goed g2 = new Stoel("de eerste stoel", 3, 250.00, "Sitzaflex", "Textiel");
            Goed g3 = new Stoel("de eerste stoel", 5, 260.00, "Sitzaflex", "Karton");
            Goed g4 = new Broodbakmachine("Barry de broodbakmachine", 500, 16.99, "Barri-o-matic");
            Eigenaar hoofdbewoner = new Eigenaar("Robin van der Leer", "Bankstede 32");

            hoofdbewoner.voegGoedToe(g1);
            hoofdbewoner.voegGoedToe(g2);
            hoofdbewoner.voegGoedToe(g3);
            hoofdbewoner.voegGoedToe(g4);

            LinkedList<Goed> mijnlijst = hoofdbewoner.getMijnHuisraad();

            while (wilvanRobin == "nogeenkeer")
            {
                Console.WriteLine("Het aantal goederen in mijn huisraad: " + mijnlijst.Count);
                foreach (Goed item in mijnlijst)
                {
                    Console.WriteLine("Hoeveel jaar oud " + item.getnaam() + " is: " + item.getJaarOud());
                    Console.WriteLine("Van welk merk " + item.getnaam() + " is: " + item.getmerk());       
                }
                wilvanRobin = Console.ReadLine();
            }     
        }
    }
}
