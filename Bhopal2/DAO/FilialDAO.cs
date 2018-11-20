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
        internal void AdicionaFilial(Filial filial)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(filial);
            session.Transaction.Commit();

            session.Close();
        }

        internal void RemoveFilial(Filial filial)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(filial);
            session.Transaction.Commit();

            session.Close();

        }

        internal void AtualizaFilial(Filial filial)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(filial);
            session.Transaction.Commit();

            session.Close();
        }

        internal IList<Filial> GetAll()
        {
            var session = NHibernateHelper.GetSession();
            IQuery buscaFilial = session.CreateQuery($"from Filial f");
            var list = (List<Filial>)buscaFilial.List<Filial>();
            return list;
        }

        internal Filial getById(string id)
        {
            var session = NHibernateHelper.GetSession();
            IQuery buscaFilial = session.CreateQuery($"from Filial f where f.Id = {id}");
            var list = buscaFilial.List<Filial>().FirstOrDefault();
            return list;
        }
    }
}