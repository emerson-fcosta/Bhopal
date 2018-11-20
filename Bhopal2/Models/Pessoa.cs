using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    /// <summary>
    /// Abstração de uma pessoa para fins diversos
    /// </summary>
    public class Pessoa
    {
        /// <summary>
        /// Campo identificador
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Nome completo
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// <see cref="Departamento"/> vinculado
        /// </summary>
        public virtual Departamento Departamento { get; set; }


        public virtual string LocalDeTrabalho => $"{Departamento.Nome}";
    }
}