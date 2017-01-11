using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.DAO
{
    public class MarcaDAO
    {

        public void AdicionaMarca(Marca marca)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(marca);
            session.Transaction.Commit();

            session.Close();
        }

        public void RemoveMarca(Marca marca)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(marca);
            session.Transaction.Commit();

            session.Close();
        }

        public void AtualizaMarca(Marca marca)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(marca);
            session.Transaction.Commit();

            session.Close();
        }
    }
}