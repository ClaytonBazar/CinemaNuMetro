namespace CinemaNuMetroV1.Models
{
    public class Sessao
    {
        private int id { get; set; }
        private DateOnly data { get; set; }
        private TimeOnly horario { get; set; }
        private string tipoSessao { get; set; }
        private int sala {  get; set; }
        private Boolean acessorios {  get; set; }

    }
}
