using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    public class Fornecedor
    {
        public virtual long Id { get; set; }

        public virtual string nomeFornecedor { get; set; }


        public virtual IList<Contato> Contatos { get; set; }

        public virtual IList<Impressora> Impressoras { get; set; }
    }
}