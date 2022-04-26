using Nullam.Models;

namespace Nullam.OsavotjadData
{
    public interface OsavotjadDataService
    {
        List<OsavotjadModel> GetAllOsavotjad();

        List<OsavotjadModel> SearchOsavotja(string searchTerm);

        OsavotjadModel GetUritusByOsavotja(string nimi);

        int Lisa(OsavotjadModel Eesnimi);

        int Kustuta(OsavotjadModel Eesnimi);

        int Varskenda(OsavotjadModel Eesnimi);
    }
}
