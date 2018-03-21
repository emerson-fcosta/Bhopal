using System.Collections.Generic;

namespace Bhopal2.Models
{
    /// <summary>
    /// Tamanhos de papel
    /// </summary>
    public class TamanhoPapel
    {
        /// <summary>
        /// Identificador de um dispositivo
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Descrição do tamanho
        /// </summary>
        public virtual string Descricao { get; set; }

        /// <summary>
        /// Impressões vinculadas
        /// </summary>
        public virtual IList<Impressao> Impressoes { get; set; }
    }
}