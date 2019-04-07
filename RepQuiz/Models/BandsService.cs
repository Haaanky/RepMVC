// Uppgift 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepQuiz.Models
{
    public class BandsService
    {
        private static int idCounter = 3;
        List<Band> bands = new List<Band>
        {
            new Band { ID=1, BandName="Björn Rosenström", Description="Bästa artisten i Sverige", ImagePath="/images/bjorn.jpg", YouTubeLink="https://www.youtube.com/embed/38BznkmdKMk", Albums={ "albumA", "albumB", "albumC"} },
            new Band { ID=2, BandName="Calvin Harris", Description="Scottish DJ/musicguru known for his beats", ImagePath="/images/calvin.jpg", YouTubeLink="https://www.youtube.com/embed/ozv4q2ov3Mk",  Albums={ "album katt", "album hund", "album häst"} },
            new Band { ID=3, BandName="Avicii", Description="RIP", ImagePath="/images/avicii.jpg", YouTubeLink="https://www.youtube.com/embed/IcrbM1l_BoI", Albums={ "album1", "album2", "album3"} }
        };

        public Band GetBandById(int id)
        {
            return bands.SingleOrDefault(b => b.ID == id);
        }

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }
        // Uppgift 2 nedan
        internal void AddBand(Band band)
        {
            band.ID = ++idCounter;
            bands.Add(band);
        }

        internal void EditBand(Band band)
        {
            var b = GetBandById(band.ID);
            b.BandName = band.BandName;
            b.Description = band.Description;
            b.ImagePath = band.ImagePath;
            b.YouTubeLink = band.YouTubeLink;
        }
        public void DeleteBand(Band band)
        {
            var bandToBeDeleted = GetBandById(band.ID);
            bands.Remove(bandToBeDeleted);
        }
    }
}
