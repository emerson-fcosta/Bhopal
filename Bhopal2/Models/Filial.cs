using System.Collections.Generic;

namespace Bhopal2.Models
{
    public class Filial
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }
        public virtual string Ddd { get; set; }
        public virtual string Codigo { get; set; }

        public virtual IList<Departamento> Departamentos { get; set; }
    }
}