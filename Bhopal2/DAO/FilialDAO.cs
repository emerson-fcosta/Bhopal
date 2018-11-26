using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bhopal2.Models;
using NHibernate;

namespace Bhopal2.DAO
{
    public class FilialDAO : GenericDAO
    {
        internal void AdicionaFilial(Filial filial)
        {
            Session.Save(filial);
        }

        internal void RemoveFilial(Filial filial)
        {
            Session.Delete(filial);
        }

        internal void AtualizaFilial(Filial filial)
        {
            Session.Update(filial);
        }

        internal IList<Filial> GetAll()
        {
            return Session.Query<Filial>().ToList();
            //var list = (List<Filial>)buscaFilial.List<Filial>();
            //return list;
        }

        internal Filial GetById(string id)
        {
            IQuery buscaFilial = Session.CreateQuery($"from Filial f where f.Id = {id}");
            var list = buscaFilial.List<Filial>().FirstOrDefault();
            return list;
        }
    }
}