using System.Collections.Generic;

namespace ProjetoUrgencia.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Chamado> Chamados { get; set; }
    }
}
