using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Toner
    {
        /// <summary>
        /// ////
        /// </summary>
        public virtual long Id { get; set; }

        public virtual string Cor { get; set; }
        
        public virtual string Codigo { get; set; }


        public virtual Impressora Impressora { get; set; }

        /// <summary>
        /// Impressoras compativeis <seealso cref="Impressora"/>
        /// </summary>
        public virtual IList<Impressora> Impressoras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool Colorido { get; set; }
    }
}