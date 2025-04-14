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
        [MaxLength(10)]
        public int sala { get; set; }
        public DateOnly data { get; set; }
        public TimeOnly horario { get; set; }
        [Required]
        [MaxLength(128)]
        public string tipoSessao { get; set; }


        public Boolean acessorios { get; set; } = false;

    }
}
