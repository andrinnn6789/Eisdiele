using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eisdiele.Decoratees;

namespace Eisdiele.Decorater
{
    public class Vanillekugel : ZutatenDecorater
    {
        private Eis _eis;

        public Vanillekugel(Eis eis)
        {
            _eis = eis;
        }

        public override double BerechnePreis()
        {
            return .6 + _eis.BerechnePreis();
        }

        public override string GetBeschreibung()
        {
            return _eis.GetBeschreibung() + ", Vanillekugel";
        }
    }
}
