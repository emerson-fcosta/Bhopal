using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Models
{
    public class Impressao
    {
        /// <summary>
        /// Identificador de uma impressão
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Data da impressão
        /// </summary>
        public virtual DateTime Data { get; set; }

        public virtual DateTime Processamento { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual int Paginas { get; set; }
        public virtual int Copias { get; set; }
        public virtual string NomeImpressora { get; set; }
        public virtual string NomeDocumento { get; set; }
        public virtual Dispositivo Dispositivo { get; set; }
        public virtual TamanhoPapel TamanhoPapel { get; set; }
        public virtual Linguagem Linguagem { get; set; }
        public virtual string Altura { get; set; }
        public virtual string Largura { get; set; }
        public virtual bool Duplex { get; set; }
        public virtual bool Grayscale { get; set; }
        public virtual string Tamanho { get; set; }
    }
}