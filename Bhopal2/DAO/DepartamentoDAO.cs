using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace Bhopal2.DAO
{
    public class DepartamentoDAO
    {

       public void AdicionaDepartamento(Departamento departamento)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(departamento);
            session.Transaction.Commit();

            session.Close();
        }


        public void RemoveDepartamento(Departamento departamento)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(departamento);
            session.Transaction.Commit();

            session.Close();
        }


        public void AtualizaDepartamento(Departamento departamento)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(departamento);
            session.Transaction.Commit();

            session.Close();
        }

        public IList<Departamento> getAll()
        {
            var session = NHibernateHelper.GetSession();

            IQuery buscaImpressoras = session.CreateQuery($"from Departamento f");
            var list = (List<Departamento>)buscaImpressoras.List<Departamento>();
            return list;
        }
    }
}