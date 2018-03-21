using System.Collections.Generic;

namespace Bhopal2.Models
{
    /// <summary>
    /// Equipamento que poderá imprimir no sistema
    /// </summary>
    public class Dispositivo
    {
        /// <summary>
        /// Identificador de um dispositivo
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Nome do dispositivo
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// <see cref="Usuario"/> vinculado a este dispositivo
        /// </summary>
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// Impressoes que este usuario realizou
        /// </summary>
        public virtual IList<Impressao> Impressoes { get; set; }
    }
}