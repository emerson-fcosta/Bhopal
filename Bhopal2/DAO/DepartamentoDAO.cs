using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Web;
using NHibernate;
using System.Linq;

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

            IQuery buscaDepartamento = session.CreateQuery($"from Departamento d");
            var list = (List<Departamento>)buscaDepartamento.List<Departamento>();
            return list;
        }

        public IList<Departamento> getByFilial(Filial f)
        {

            var session = NHibernateHelper.GetSession();

            IQuery buscaDepartamento = session.CreateQuery($"from Departamento d where d.Filial = {f.Id}");
            var list = buscaDepartamento.List<Departamento>().ToList();
            return list;

        }

    }
}