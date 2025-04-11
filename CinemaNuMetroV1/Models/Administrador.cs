namespace CinemaNuMetroV1.Models
{
    public class Administrador : Utilizador
    {
        private string password {  get; set; }

        public Administrador(string password) : base()
        {
            this.password = password;
        }
    }
}
