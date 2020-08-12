using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalApiGusApiRegonData.Models.DaneSzukajPodmioty
{
    /// <summary>
    /// Model wyszukiwanie podmiotów
    /// </summary>
    [Table("DaneSzukajPodmioty")]
    public partial class DaneSzukajPodmioty
    {
        [Key]
        public int Id { get; set; }
        [StringLength(14)]
        public string Regon { get; set; }
        [StringLength(10)]
        public string Nip { get; set; }
        [StringLength(12)]
        public string StatusNip { get; set; }
        [StringLength(2000)]
        public string Nazwa { get; set; }
        [StringLength(200)]
        public string Wojewodztwo { get; set; }
        [StringLength(200)]
        public string Powiat { get; set; }
        [StringLength(200)]
        public string Gmina { get; set; }
        [StringLength(200)]
        public string Miejscowosc { get; set; }
        [StringLength(12)]
        public string KodPocztowy { get; set; }
        [StringLength(200)]
        public string Ulica { get; set; }
        [StringLength(20)]
        public string NrNieruchomosci { get; set; }
        [StringLength(10)]
        public string NrLokalu { get; set; }
        [StringLength(2)]
        public string Typ { get; set; }
        public int? SilosID { get; set; }
        [StringLength(10)]
        public string DataZakonczeniaDzialalnosci { get; set; }
        [StringLength(200)]
        public string MiejscowoscPoczty { get; set; }
    }
}