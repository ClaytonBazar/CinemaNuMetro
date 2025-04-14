using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaNuMetroV1.Models
{
    [Table("tb_filme")]
    public class filme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string titulo { get; set; }
        [Required]
        [MaxLength(100)]
        public string categoria { get; set; }
        public TimeOnly duracao { get; set;}
        [Required]
        [MaxLength(250)]
        public string descricao { get; set;}
        [Required]
        public string cast {  get; set;}
        [Required]
        public string trailer {  get; set;}
        [Required]
        public double preco { get; set;}
        [Required]
        public string imagemUrl {  get; set;}

    }
}
