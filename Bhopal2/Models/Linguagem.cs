using System.Collections.Generic;

namespace Bhopal2.Models
{
    /// <summary>
    /// Linguagem de comandos de impressoras
    /// </summary>
    public class Linguagem
    {
        /// <summary>
        /// Campo identificador de uma linguagem
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Nome da linguagem
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// Impressoes que este usuario realizou
        /// </summary>
        public virtual IList<Impressao> Impressoes { get; set; }
    }
}