using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;

namespace Bhopal2.DAO
{

    public class TonerDAO : GenericDAO
    {

        public void AdicionaToner(Toner toner)
        {
            Session.Save(toner);
        }

        public void Deletar(Toner toner)
        {
            Session.Delete(toner);
        }

        public void Deletar(long id)
        {
            Deletar(ObterPeloId(id));
        }

        public void AtualizaToner(Toner toner)
        {
            Session.Update(toner);
        }

        public IList<Toner> ObterTodos()
        {
            IQuery buscaToneres = Session.CreateQuery($"from Toner");
            var list = (List<Toner>)buscaToneres.List<Toner>();
            return list;
        }

        public IList<Toner> ObterPeloIdImpressora(Impressora I)
        {
            IQuery buscaToner = Session.CreateQuery($"from Toner t where t.Impressora.Id = {I.Id}");
            var list = buscaToner.List<Toner>().ToList();
            return list;
        }

        internal Toner ObterPeloId(long id)
        {
            return Session.Query<Toner>()
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}