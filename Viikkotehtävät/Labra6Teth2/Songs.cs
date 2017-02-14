using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6Teth2
{
    class Songs
    {
        public string BiisiNimi { get; set; }
        public int Pituus { get; set; }


        public override string ToString()
        {
            int min = Pituus / 60;
            int sec = Pituus % 60;
            string duration = min.ToString("00") + ":" + sec.ToString("00");
            return "- Nimi: " + BiisiNimi + " - " + duration;
        }
    }
}
