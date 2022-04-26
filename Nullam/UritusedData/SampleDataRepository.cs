using Nullam.Models;

namespace Nullam.Services
{
    public class SampleDataRepository : UritusDataService
    {
        List<UritusModel> Uritus = new List<UritusModel>();

        public List<UritusModel> GetAllUritused()
        {
            Uritus.Add(new UritusModel { UrituseNimi = "Näidend Kapsapea", ToimumisAeg = new DateTime(22, 6, 5), Koht = "Viljandi", Lisainfo = "Celiina Valdner" });
            Uritus.Add(new UritusModel { UrituseNimi = "Karl-Erik Taukari kontsert", ToimumisAeg = new DateTime(22, 5, 12), Koht = "Tartu", Lisainfo = "Soovin seisukohta" });
            Uritus.Add(new UritusModel { UrituseNimi = "Faust (C. Gounod' ooper)", ToimumisAeg = new DateTime(22, 7, 25), Koht = "Tallinn", Lisainfo = "+1 kaaslane" });
            Uritus.Add(new UritusModel { UrituseNimi = "Suvepäevad", ToimumisAeg = new DateTime(22, 8, 02), Koht = "Pärnu", Lisainfo = "Võib sadada vihma" });
            Uritus.Add(new UritusModel { UrituseNimi = "Talvepäevad", ToimumisAeg = new DateTime(22, 12, 11), Koht = "Otepää", Lisainfo = "Võtan suusad kaasa" });
            Uritus.Add(new UritusModel { UrituseNimi = "Presidendi sünnipäev", ToimumisAeg = new DateTime(22, 03, 26), Koht = "Tartu", Lisainfo = "+1 kaaslane" });

            return Uritus;
        }  

        public UritusModel GetUritusByKoht(string Koht)
        {
            throw new NotImplementedException();
        }

        public int Kustuta(UritusModel Uritus)
        {
            throw new NotImplementedException();
        }

        public int Lisa(UritusModel Uritus)
        {
            throw new NotImplementedException();
        }

        public List<UritusModel> SearchUritused(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Varskenda(UritusModel Uritus)
        {
            throw new NotImplementedException();
        }
    }
}
