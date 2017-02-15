using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    /// <summary>
    /// Abstração de um contato
    /// </summary>
    public class Contato
    {
        /// <summary>
        /// Campo identificador de um contato
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Nome de um contato
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// Telefone de um contato
        /// </summary>
        public virtual string Telefone { get; set; }

        /// <summary>
        /// Forncedor a qual o contato esta vinculado
        /// </summary>
        public virtual Fornecedor Fornecedor { get; set; }
    }
}