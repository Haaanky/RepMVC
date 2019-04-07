using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepQuiz.Models
{
    public class BandsService
    {
        List<Band> bands = new List<Band>
        {
            new Band {BandID=1, BandName="Björn Rosenström", Description="Bästa artisten i Sverige", ImagePath="/images/bjorn.jpg", YouTubeLink="https://www.youtube.com/embed/38BznkmdKMk", Albums={ "albumA", "albumB", "albumC"} },
            new Band {BandID=2, BandName="Calvin Harris", Description="Scottish DJ/musicguru known for his beats", ImagePath="/images/calvin.jpg", YouTubeLink="https://www.youtube.com/embed/ozv4q2ov3Mk",  Albums={ "album katt", "album hund", "album häst"} },
            new Band {BandID=3, BandName="Avicii", Description="RIP", ImagePath="/images/avicii.jpg", YouTubeLink="https://www.youtube.com/embed/IcrbM1l_BoI", Albums={ "album1", "album2", "album3"} }
        };

        public Band GetBandById(int id)
        {
            return bands.SingleOrDefault(b => b.BandID == id);
        }

        public Band[] GetAllBands()
        {
            foreach (var item in bands)
                Console.WriteLine("hej");
            return bands.ToArray();
        }

        internal void AddBand()
        {
            throw new NotImplementedException();
        }
    }
}
