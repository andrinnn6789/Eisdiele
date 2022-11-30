using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele.Decoratees
{
    public abstract class Eis
    {
        protected string _beschreibung = "Unbekanntes Getränk";

        public virtual string GetBeschreibung()
        {
            return _beschreibung;
        }

        public abstract double BerechnePreis();

    }
}
