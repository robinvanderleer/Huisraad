using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisraad
{
    public abstract class Goed
    {
        protected string naam;
        protected int jaarOud;
        protected double inkoopPrijs;
        protected string merk;
        protected string materiaal;
        protected int vierkantheid;

        public abstract double VerkoopPrijs(int jaren, double prijs);
        public abstract int getJaarOud();
        public abstract string getmerk();
        public abstract string getnaam();
    }
}
