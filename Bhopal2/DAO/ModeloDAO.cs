using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace Bhopal2.DAO
{

    public class ModeloDAO : GenericDAO
    {

        public void AdicionaModelo(Modelo modelo)
        {
            Session.Save(modelo);
        }

        public void RemoveModelo(Modelo modelo)
        {
            Session.Delete(modelo);
        }

        public void AtualizaModelo(Modelo modelo)
        {
            Session.Update(modelo);
        }

        public IList<Modelo> GetAll()
        {
            IQuery buscaModelos = Session.CreateQuery($"from Modelo mod");
            var list = (List<Modelo>)buscaModelos.List<Modelo>();
            return list;
        }

        public IList<Modelo> ObterTodos()
        {
            return Session.Query<Modelo>().ToList();
        }

    }
}