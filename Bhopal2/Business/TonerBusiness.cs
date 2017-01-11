using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Business
{
    public class TonerBusiness
    {

        public void BuscaTodosToneres()
        {
            var session = NHibernateHelper.GetSession();

            IQuery buscaToner = session.CreateQuery("from Toner t order by t.Id");
            IList<Toner> toneres = buscaToner.List<Toner>();

            foreach (Toner toner in toneres)
            {
                //...
            }

            session.Close();
        }
    }
}