using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaNuMetroV1.Models
{
    [Table("Utilizador")]
    public class Utilizador
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [MaxLength(125)]
        public string nome { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set;}
        [Required]
        public long contacto { get; set;}
    }


}
