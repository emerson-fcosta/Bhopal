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

        public void Deletar(Modelo modelo)
        {
            Session.Delete(modelo);
        }

        public void AtualizaModelo(Modelo modelo)
        {
            Session.Update(modelo);
        }

        public IList<Modelo> ObterTodos()
        {
            IQuery buscaModelos = Session.CreateQuery($"from Modelo mod");
            var list = (List<Modelo>)buscaModelos.List<Modelo>();
            return list;
        }

        internal void Deletar(long id)
        {
            Deletar(ObterPeloId(id));
        }

        internal Modelo ObterPeloId(long id)
        {
            return Session.Query<Modelo>()
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
        }
    }
}