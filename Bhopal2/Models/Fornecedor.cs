using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Fornecedor
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        /// <summary>
        /// Propriedades para exibição na Grid
        /// </summary>
        public virtual string Contato => $"{Contatos[0].Nome}";

        public virtual string QtdeImpressoras => $"{Impressoras.Count}";
        
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<Contato> Contatos { get; set; }

        public virtual IList<Impressora> Impressoras { get; set; }
    }
}