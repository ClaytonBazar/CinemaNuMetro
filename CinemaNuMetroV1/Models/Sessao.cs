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
        private long Id { get; set; }
        private DateOnly data { get; set; }
        private TimeOnly horario { get; set; }
        [Required]
        [MaxLength(128)]
        private string tipoSessao { get; set; }
        [Required]
        [MaxLength(1)]
        private int sala {  get; set; }

        private Boolean acessorios { get; set; } = false;

    }
}
