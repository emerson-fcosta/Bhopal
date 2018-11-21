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

        public void RemoveToner(Toner toner)
        {
            Session.Delete(toner);
        }
        
        public void AtualizaToner(Toner toner)
        {
            Session.Update(toner);
        }

        public IList<Toner> GetAll()
        {
            IQuery buscaToneres = Session.CreateQuery($"from Toner t");
            var list = (List<Toner>)buscaToneres.List<Toner>();
            return list;
        }

        public IList<Toner> getByImpressora(Impressora I)
        {
            IQuery buscaToner = Session.CreateQuery($"from Toner t where t.Id = {I.Id}");
            var list = buscaToner.List<Toner>().ToList();
            return list;
        }
    }
}