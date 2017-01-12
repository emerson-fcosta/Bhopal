using System.ComponentModel;
using NHibernate.Type;

namespace Bhopal2.Models
{
    public enum TipoImpressoraEnum
    {
        [Description("Monocromática")]
        Monocromatica = 0,

        [Description("Multifuncional")]
        Multifuncional = 1,

    }

    public class TipoImpressoraType : EnumStringType
    {
        public TipoImpressoraType() : base(typeof(TipoImpressoraEnum), 20) { }
    }
}