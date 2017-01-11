using System.Collections.Generic;

namespace Bhopal2.Models
{
    public class Modelo
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual IList<Impressora> Impressoras { get; set; }
    }
}