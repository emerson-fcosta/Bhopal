using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.DAO
{
    public class ContatoDAO
    {

        public void AdicionaContato(Contato contato)
        {

            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(contato);
            session.Transaction.Commit();

            session.Close();
        }


        public void RemoveContato(Contato contato)
        {

            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(contato);
            session.Transaction.Commit();

            session.Close();
        }

        public void AtualizaContato(Contato contato)
        {

            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(contato);
            session.Transaction.Commit();

            session.Close();
        }
    }
}