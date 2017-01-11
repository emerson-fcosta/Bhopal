using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    public class Contato
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Telefone { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}