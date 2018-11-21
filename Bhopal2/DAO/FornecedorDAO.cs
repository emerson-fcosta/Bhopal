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

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            Session.Save(fornecedor);
        }
        
        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            Session.Delete(fornecedor);
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            Session.Update(fornecedor);
        }

        public IList<Fornecedor> GetAll()
        {
            List<Fornecedor> list = Session.Query<Fornecedor>().ToList();
            return list;
        }
    }
}