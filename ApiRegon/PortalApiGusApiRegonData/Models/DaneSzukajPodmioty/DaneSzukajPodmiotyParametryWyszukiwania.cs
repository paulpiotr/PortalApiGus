using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalApiGusApiRegonData.Models.DaneSzukajPodmioty
{
    /// <summary>
    /// Model wyszukiwanie podmiotów Parametry Wyszukiwania
    /// </summary>
    [Table("DaneSzukajPodmiotyParametryWyszukiwania")]
    public partial class DaneSzukajPodmiotyParametryWyszukiwania
    {
        [Key]
        public int Id { get; set; }
        [StringLength(2147483647)]
        public string SHA512 { get; set; }
        [StringLength(14)]
        public string Regon { get; set; }
        [StringLength(10)]
        public string Nip { get; set; }
        [StringLength(10)]
        public string Krs { get; set; }
        [StringLength(220)]
        public string Nipy { get; set; }
        [StringLength(300)]
        public string Regony14zn { get; set; }
        [StringLength(200)]
        public string Regony9zn { get; set; }
        [StringLength(220)]
        public string Krsy { get; set; }
    }
}
