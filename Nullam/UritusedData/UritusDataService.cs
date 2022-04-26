using Nullam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nullam.Services
{
    public interface UritusDataService
    {
        List<UritusModel> GetAllUritused();

        List<UritusModel> SearchUritused(string searchTerm);

        UritusModel GetUritusByKoht(string Koht);

        int Lisa(UritusModel Uritus);

        int Kustuta(UritusModel Uritus);

        int Varskenda(UritusModel Uritus);

    }
}
