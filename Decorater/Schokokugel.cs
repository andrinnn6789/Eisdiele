using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eisdiele.Decoratees;

namespace Eisdiele.Decorater
{
    public class Schokokugel : ZutatenDecorater
    {
        private Eis _eis;

        public Schokokugel(Eis eis)
        {
            _eis = eis;
        }

        public override double BerechnePreis()
        {
            return 0.3 + _eis.BerechnePreis();
        }

        public override string GetBeschreibung()
        {
            return _eis.GetBeschreibung() + ", Schokokugel";
        }
    }
}
