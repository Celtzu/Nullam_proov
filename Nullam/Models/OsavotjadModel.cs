using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Nullam.Models
{
    public class OsavotjadModel
    {
        [Required]
        [DisplayName("Eesnimi:")]
        public string? Eesnimi { get; set; }

        [DisplayName("Perenimi:")]
        public string? Perenimi { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [DisplayName("Isikukood:")]
        public string? Isikukood { get; set; }

        [DisplayName("Lisainfo:")]
        public string? Lisainfo { get; set; }

    }
}
