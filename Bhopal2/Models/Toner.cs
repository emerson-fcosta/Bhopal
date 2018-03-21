using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    public class Toner
    {
        public virtual long Id { get; set; }

        public virtual string Cor { get; set; }
        
        public virtual string Codigo { get; set; }

        public virtual Impressora Impressora { get; set; }

        /// <summary>
        /// Impressoras compativeis <seealso cref="Impressora"/>
        /// </summary>
        public virtual IList<Impressora> Impressoras { get; set; }


        public virtual bool Colorido { get; set; }
    }
}