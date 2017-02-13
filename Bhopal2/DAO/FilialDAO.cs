using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bhopal2.Models;
using Bhopal2.Infra;
using NHibernate;

namespace Bhopal2.DAO
{
    public class FilialDAO
    {
        public void AdicionaFilial(Filial filial)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(filial);
            session.Transaction.Commit();

            session.Close();
        }

        public void RemoveFilial(Filial filial)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(filial);
            session.Transaction.Commit();

            session.Close();

        }

        public void AtualizaFilial(Filial filial)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(filial);
            session.Transaction.Commit();

            session.Close();
        }

        public IList<Filial> getAll()
        {
            var session = NHibernateHelper.GetSession();
            IQuery buscaFilial = session.CreateQuery($"from Filial f");
            var list = (List<Filial>)buscaFilial.List<Filial>();
            return list;
        }
    }
}