using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    public class PedidoDeToner
    {
        public virtual long Id { get; set; }

        public virtual string NumeroChamado { get; set; }

        public virtual DateTime dataSolicitacao { get; set; }

        public virtual DateTime dataAlteracao { get; set; }

        public virtual string Status { get; set; }


        public virtual Impressora Impressora { get; set; }

        //public virtual Marca Marca { get; set; }

        //public virtual Toner Toner { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual Filial Filial { get; set; }


    }
}