using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6Teth2
{
    class CD
    {
        public string CDNimi { get; set; }
        public string CDArtisti { get; set; }
        public List<Songs> Songs;

    //methodi
    public CD()
    {
        Song = new List<Songs>();
    }
    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

        public override string ToString()
        {
           
           string.Format("Artisti:" + CDArtisti + "Biisin nimi" + CDNimi);
        }
        foreach (Songs p in Songs)
	    {

	    }
    }


}

