using System;
using Nullam.Models;

namespace Nullam.OsavotjadData
{
    public class SampleDataRepository2 : OsavotjadDataService
    {
        List<OsavotjadModel> Osavotjad = new List<OsavotjadModel>();
        
        public List<OsavotjadModel> GetAllOsavotjad()
        {

            Osavotjad.Add(new OsavotjadModel { Eesnimi = "Mati", Perenimi = "Kaal", Isikukood = "38605241213", Lisainfo = "+1 kaaslane" });
            Osavotjad.Add(new OsavotjadModel { Eesnimi = "Kati", Perenimi = "Maal", Isikukood = "47104130241", Lisainfo = "Tulen rattaga" });
            Osavotjad.Add(new OsavotjadModel { Eesnimi = "Mari", Perenimi = "Maasikas", Isikukood = "49505120745", Lisainfo = "Jõuan hiljem" });
            Osavotjad.Add(new OsavotjadModel { Eesnimi = "Kaisa", Perenimi = "Kivi", Isikukood = "48605241213", Lisainfo = "+1 kaaslane" });
            Osavotjad.Add(new OsavotjadModel { Eesnimi = "Margus", Perenimi = "Mets", Isikukood = "37705130241", Lisainfo = "Tulen autoga, 3 kohta" });
            Osavotjad.Add(new OsavotjadModel { Eesnimi = "Magnus", Perenimi = "Mustikas", Isikukood = "39505120745", Lisainfo = "Laps kaasas" });

            return Osavotjad;

        }

        public OsavotjadModel GetUritusByOsavotja(string nimi)
        {
            throw new NotImplementedException();
        }

        public int Kustuta(OsavotjadModel Eesnimi)
        {
            throw new NotImplementedException();
        }

        public int Lisa(OsavotjadModel Eesnimi)
        {
            throw new NotImplementedException();
        }

        public List<OsavotjadModel> SearchOsavotja(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Varskenda(OsavotjadModel Eesnimi)
        {
            throw new NotImplementedException();
        }
    }
}
