using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalApiGusApiRegonData.Models.Inny
{
    [Table("Inna")]
    public partial class Inna
    {
        [Key]
        public int Id { get; set; }
        [StringLength(14)]
        public string Regon { get; set; }
        [StringLength(10)]
        public string Nip { get; set; }
    }
}
