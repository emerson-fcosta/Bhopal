using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace Bhopal2.DAO
{
    public class ImpressoraDAO
    {



        public void AdicionaImpressora(Impressora impressora)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(impressora);
            session.Transaction.Commit();

            //session.Flush();
            session.Close();

        }

        public void RemoveImpressora(Impressora impressora)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(impressora);
            session.Transaction.Commit();

            session.Close();
            
        }

        public void AtualizaImpressora(Impressora impressora)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(impressora);
            session.Transaction.Commit();

            session.Close();

        }

        internal Impressora getById(string id)
        {
            var session = NHibernateHelper.GetSession();
            IQuery buscaImpressora = session.CreateQuery($"from Impressora i where i.Id = {id}");
            var list = buscaImpressora.List<Impressora>().FirstOrDefault();
            return list;
        }

        public IList<Impressora> getByDepartamento(Departamento d)
        {
            var session = NHibernateHelper.GetSession();

            IQuery buscaImpressora = session.CreateQuery($"from Departamento dep where dep.Impressora = {d.Id}");
            var list = buscaImpressora.List<Impressora>().ToList();
            return list;
        }

    }
}