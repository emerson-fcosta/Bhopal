using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace Bhopal2.DAO
{
    public class ModeloDAO
    {

        public void AdicionaModelo(Modelo modelo)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(modelo);
            session.Transaction.Commit();

            session.Close();
        }

        public void RemoveModelo(Modelo modelo)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(modelo);
            session.Transaction.Commit();

            session.Close();
        }

        public void AtualizaModelo(Modelo modelo)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(modelo);
            session.Transaction.Commit();

            session.Close();
        }

        public IList<Modelo> getAll()
        {
            var session = NHibernateHelper.GetSession();

            IQuery buscaModelos = session.CreateQuery($"from Modelo mod");
            var list = (List<Modelo>)buscaModelos.List<Modelo>();
            return list;
        }
    }
}