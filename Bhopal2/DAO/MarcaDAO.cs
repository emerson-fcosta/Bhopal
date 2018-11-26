using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.DAO
{

    public class MarcaDAO : GenericDAO
    {

        public void AdicionaMarca(Marca marca)
        {
            Session.Save(marca);
        }

        public void Deletar(Marca marca)
        {
            Session.Delete(marca);
        }

        public void Deletar(long id)
        {
            Deletar(ObterPeloId(id));
        }

        internal Marca ObterPeloId(long v)
        {
            return Session.Query<Marca>()
                    .Where(x => x.Id == v)
                    .FirstOrDefault();
        }

        public void AtualizaMarca(Marca marca)
        {
            Session.Update(marca);
        }

        public IList<Marca> GetAll()
        {
            IQuery buscaMarcas = Session.CreateQuery($"from Marca");
            var list = (List<Marca>)buscaMarcas.List<Marca>();
            return list;
        }

    }
}