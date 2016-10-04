using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisraad
{
    class Broodbakmachine:Goed
    {
        public Broodbakmachine(string naam, int jaar, double prijs, string merk, int vierkantheid)
        {
            base.naam = naam;
            base.jaarOud = jaar;
            base.inkoopPrijs = prijs;
            base.merk = merk;
            base.materiaal = materiaal;
        }

        public override double VerkoopPrijs(int jaren, double prijs)
        {
            return 0.0;
        }

        public override int getJaarOud()
        {
            return jaarOud;
        }

        public void setJaarOud(int jaren)
        {
            jaarOud = jaren;
        }

        public override string getmerk()
        {
            return merk;
        }
        public override string getnaam()
        {
            return naam;
        }
    }
}
