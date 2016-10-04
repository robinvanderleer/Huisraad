using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisraad
{
    class Eigenaar
    {
        private string naam;
        private string adres;
        private LinkedList<Goed> mijnHuisraad = new LinkedList<Goed>();

        public Eigenaar(string nm, string adr)
        {
            naam = nm;
            adres = adr;
        }

        public void voegGoedToe(Goed g)
        {
            mijnHuisraad.AddLast(g);
        }

        public LinkedList<Goed> getMijnHuisraad()
        {
            return mijnHuisraad;
        }

        public string getNaam()
        {
            return naam;
        }

        public void setNaam(string nwnm)
        {
            naam = nwnm;
        }

        public string getAdres()
        {
            return adres;
        }

        public void setAdres(string nwadr)
        {
            adres = nwadr;
        }


    }
}
