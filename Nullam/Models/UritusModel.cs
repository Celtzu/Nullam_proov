using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullam.Models
{
    public class UritusModel
    {

        [Required]
        [DisplayName("Ürituse nimi")]
        public string? UrituseNimi { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Toimumisaeg")]
        public DateTime ToimumisAeg { get; set; }

        [DisplayName("Koht")]
        public string? Koht { get; set; }

        [StringLength(maximumLength: 1000)]
        [DisplayName("Lisainfo")]
        public string? Lisainfo { get; set; }
 
    }

    
}
