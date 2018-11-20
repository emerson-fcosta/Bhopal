using System.Collections.Generic;

namespace Bhopal2.Models
{
    public class Departamento
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Local => $"{Filial.Nome}";

        public virtual Filial Filial { get; set; }

        public virtual IList<Impressora> Impressoras { get; set; }

        public virtual IList<PedidoDeToner> PedidosDeToner { get; set; }
    }
}