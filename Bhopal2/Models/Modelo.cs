using System.Collections.Generic;

namespace Bhopal2.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Modelo
    {
        /// <summary>
        /// Identificador unico do modelo
        /// </summary>
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual string Fabricante => $"{Marca.Nome}";

    }
}