using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace Bhopal2.DAO
{

    public class FornecedorDAO : GenericDAO
    {

        public void Adicionar(Fornecedor fornecedor)
        {
            Session.Save(fornecedor);
        }
        
        public void Deletar(Fornecedor fornecedor)
        {
            Session.Delete(fornecedor);
        }

        public void Deletar(long id)
        {
            Deletar(ObterPeloId(id));
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            Session.Update(fornecedor);
        }

        public IList<Fornecedor> ObterTodos()
        {
            List<Fornecedor> list = Session.Query<Fornecedor>().ToList();
            return list;
        }

        internal Fornecedor ObterPeloId(long v)
        {
            return Session.Get<Fornecedor>(v);
        }
    }
}