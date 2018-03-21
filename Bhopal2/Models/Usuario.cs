using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    /// <summary>
    /// Usuario cadastrado no sistema
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Identificador de uma impressão
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Login do usuario
        /// </summary>
        public virtual string Login { get; set; }

        /// <summary>
        /// Senha do usuario qd for interno
        /// </summary>
        public virtual string Senha { get; set; }

        /// <summary>
        /// <see cref="Pessoa"/> vinculada
        /// </summary>
        public virtual Pessoa Pessoa { get; set; }

        /// <summary>
        /// Utilizado para controle interno
        /// </summary>
        public virtual bool Interno { get; set; }
    }
}