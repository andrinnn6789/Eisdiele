using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele.Decoratees
{
    public class Waffel : Eis
    {
        public Waffel()
        {
            _beschreibung = "Waffel";
        }

        public override double BerechnePreis()
        {
            return 2.50;
        }
    }
}
