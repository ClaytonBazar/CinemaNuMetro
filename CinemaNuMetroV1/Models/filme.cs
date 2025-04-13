using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaNuMetroV1.Models
{
    [Table("tb_filme")]
    public class filme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id {  get; set; }
        [Required]
        [MaxLength(256)]
        private string titulo { get; set; }
        [Required]
        [MaxLength(100)]
        private string categoria { get; set; }
        private TimeOnly duracao { get; set;}
        [Required]
        [MaxLength(250)]
        private string descricao { get; set;}
        [Required]
        private string cast {  get; set;}
        [Required]
        private string trailer {  get; set;}
        [Required]
        private double preco { get; set;}


    }
}
