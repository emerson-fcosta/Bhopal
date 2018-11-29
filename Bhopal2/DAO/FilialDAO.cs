using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bhopal2.Models;
using NHibernate;

namespace Bhopal2.DAO
{
    /// <summary>
    /// Centraliza o acesso a dados do Tipo <see cref="Filial"/>
    /// </summary>
    public class FilialDAO : GenericDAO
    {
        internal void Salvar(Filial filial)
        {
            Session.Save(filial);
        }

        internal void Deletar(Filial filial)
        {
            Session.Delete(filial);
        }

        internal void Deletar(long id)
        {
            Deletar(ObterPeloId(id));
        }

        internal void Atualizar(Filial filial)
        {
            Session.Update(filial);
        }

        internal IList<Filial> ObterTodos()
        {
            return Session.Query<Filial>().ToList();
        }

        internal Filial ObterPeloId(string id)
        {
            IQuery buscaFilial = Session.CreateQuery($"from Filial f where f.Id = {id}");
            var list = buscaFilial.List<Filial>().FirstOrDefault();
            return list;
        }

        internal Filial ObterPeloId(long id)
        {
            return Session.Get<Filial>(id);
        }
    }
}