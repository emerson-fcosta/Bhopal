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
    public class ImpressoraDAO : GenericDAO
    {

        public void AdicionaImpressora(Impressora impressora)
        {
            Session.Save(impressora);
        }

        internal IList<Impressora> GetAll()
        {
            IQuery buscaImpressora = Session.CreateQuery($"from Impressora i");
            var list = buscaImpressora.List<Impressora>().ToList();
            return list;
        }

        public void Deletar(Impressora impressora)
        {
            Session.Delete(impressora);
        }

        public void Deletar(long id)
        {
            Deletar(getById(id.ToString()));
        }

        public void AtualizaImpressora(Impressora impressora)
        {
            Session.Update(impressora);
        }

        internal Impressora getById(string id)
        {
            IQuery buscaImpressora = Session.CreateQuery($"from Impressora i where i.Id = {id}");
            var list = buscaImpressora.List<Impressora>().FirstOrDefault();
            return list;

        }

        public IList<Impressora> getByDepartamento(Departamento d)
        {
            IQuery buscaImpressora = Session.CreateQuery($"from Impressora i where i.Id = {d.Id}");
            var list = buscaImpressora.List<Impressora>().ToList();
            return list;
        }

    }
}