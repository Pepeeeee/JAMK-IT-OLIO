using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtäviä
{
    class Tyre
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public string Rengaskoko { get; set; }

        public override string ToString()
        {
            return "Nimi: " + Merkki + " Model:" + Malli + " TyreSize:" + Rengaskoko;
        }
    }
}