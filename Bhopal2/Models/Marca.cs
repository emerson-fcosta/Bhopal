using System.Collections.Generic;

namespace Bhopal2.Models
{
    public class Marca
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual IList<Modelo> Modelos { get; set; }

        public virtual IList<PedidoDeToner> PedidosDeToner { get; set; }

        public virtual IList<Impressora> Impressoras { get; set; }
    }
}