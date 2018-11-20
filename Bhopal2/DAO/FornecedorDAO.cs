using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace Bhopal2.DAO
{
    public class FornecedorDAO
    {

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(fornecedor);
            session.Transaction.Commit();

            session.Close();
        }


        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(fornecedor);
            session.Transaction.Commit();

            session.Close();
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(fornecedor);
            session.Transaction.Commit();

            session.Close();
        }

        public IList<Fornecedor> GetAll()
        {
            var session = NHibernateHelper.GetSession();

            List<Fornecedor> list = session.Query<Fornecedor>().ToList();
            return list;
        }
    }
}