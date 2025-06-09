namespace ProjetoUrgencia.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime CriadoEm { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
