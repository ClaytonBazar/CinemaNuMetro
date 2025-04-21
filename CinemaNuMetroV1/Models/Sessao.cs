using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaNuMetroV1.Models
{
    [Table("tb_sessao")]
    public class Sessao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string tipoSessao { get; set; }
        [Required]
        public DateOnly data { get; set; }
        [Required]
        public TimeOnly horario { get; set; }


        public Boolean acessorios { get; set; } = false;
        [Required]
        public int sala { get; set; }


    }
}