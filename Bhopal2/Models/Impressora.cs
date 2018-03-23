using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    public class Impressora
    {
        public virtual long Id { get; set; }

        public virtual string Codigo { get; set; }

        public virtual string Tipo { get; set; }

        public virtual string Nome => $"[{Id}] {Modelo.Nome}  ";

        public virtual Fornecedor Fornecedor { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual Modelo Modelo { get; set; }

        public virtual Marca Marca => this.Modelo.Marca; //{ get; set; }

        public virtual Filial Filial { get; set; }

        //public virtual Toner Toner { get; set; }


        public virtual IList<PedidoDeToner> PedidosDeToner { get; set; }

        public virtual IList<Toner> Toneres { get; set; }


    }
}