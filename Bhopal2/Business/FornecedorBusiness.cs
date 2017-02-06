using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.Business
{
    public class FornecedorBusiness
    {

        public IList<Fornecedor> retornaFornecedores()
        {
            var session = NHibernateHelper.GetSession();

            IQuery retornaFornecedores = session.CreateQuery($"from Fornecedor f");
            List<Fornecedor> lista = (List<Fornecedor>)retornaFornecedores.List<Fornecedor>();

            return lista;
        }

        public Fornecedor retornaId(long id)
        {
            var session = NHibernateHelper.GetSession();
            return session.Get<Fornecedor>(id);
        }
    }
}