using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaNuMetroV1.Models
{
    [Table("tb_utilizador")]
    public class Utilizador
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private long id { get; set; }
        [Required]
        [MaxLength(125)]
        private string nome { get; set; }
        [Required]
        [EmailAddress]
        private string email { get; set;}
        [Required]
        [Phone]
        private int contacto { get; set;}
    }


}
