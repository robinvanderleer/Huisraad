using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisraad
{
    class Tafel:Goed
    {
        public Tafel(string naam, int jaarOud, double inkoopPrijs, string merk, string materiaal)
        {
            base.naam = naam;
            base.jaarOud = jaarOud;
            base.inkoopPrijs = inkoopPrijs;
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
