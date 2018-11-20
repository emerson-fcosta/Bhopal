using System.Collections.Generic;

namespace Bhopal2.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Filial
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }
        public virtual string Ddd { get; set; }
        public virtual string Codigo { get; set; }

        public virtual IList<Departamento> Departamentos { get; set; }

        /// <summary>
        /// Propriedade para exibição no GridView
        /// </summary>
        public virtual string QtdeLocais => $"{Departamentos.Count}";
    }
}