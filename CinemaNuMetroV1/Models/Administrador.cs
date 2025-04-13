using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaNuMetroV1.Models
{

    public class Administrador : Utilizador
    {
        [Required]
        [PasswordPropertyText]
        private string password {  get; set; }

    }
}
