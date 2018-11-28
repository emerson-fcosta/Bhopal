using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace Bhopal2.DAO
{
    public class ImpressoraDAO : GenericDAO
    {

        public void AdicionaImpressora(Impressora impressora)
        {
            Session.Save(impressora);
        }

        internal IList<Impressora> ObterTodos()
        {
            IQuery buscaImpressora = Session.CreateQuery($"select i from Impressora i");
            var list = buscaImpressora.List<Impressora>().ToList();
            return list;
        }

        public void Deletar(Impressora impressora)
        {
            Session.Delete(impressora);
        }

        public void Deletar(long id)
        {
            Deletar(ObterPeloId(id.ToString()));
        }

        public void AtualizaImpressora(Impressora impressora)
        {
            Session.Update(impressora);
        }

        internal Impressora ObterPeloId(string id)
        {
            long i;

            var result = long.TryParse(id, out i);

            if (result)
            {
                IQuery buscaImpressora = Session.CreateQuery($"from Impressora i where i.Id = {id}");
                return buscaImpressora.List<Impressora>().FirstOrDefault();
            }
            else
            {
                return null;
            }

        }

        public IList<Impressora> ObterPeloDepartamento(Departamento d)
        {
            IQuery buscaImpressora = Session.CreateQuery($"from Impressora i where i.Id = {d.Id}");
            var list = buscaImpressora.List<Impressora>().ToList();
            return list;
        }

    }
}