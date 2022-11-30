using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele.Decoratees
{
    public class Becher : Eis
    {
        public Becher()
        {
            _beschreibung = "Becher";
        }

        public override double BerechnePreis()
        {
            return 2.00;
        }
    }
}
