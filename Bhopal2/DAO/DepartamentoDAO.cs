
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Web;
using NHibernate;
using System.Linq;

namespace Bhopal2.DAO
{
    public class DepartamentoDAO : GenericDAO
    {

       public void Salvar(Departamento departamento)
        {
            Session.Save(departamento);
        }
        
        public void Deletar(Departamento departamento)
        {
            Session.Delete(departamento);
        }

        internal void Deletar(long id)
        {
            Deletar(ObterPeloId(id));
        }

        public void Atualizar(Departamento departamento)
        {
            Session.Update(departamento);
        }

        public IList<Departamento> ObterTodos()
        {            
            IQuery buscaDepartamento = Session.CreateQuery($"select d from Departamento d");
            var list = (List<Departamento>)buscaDepartamento.List<Departamento>();
            return list;
        }

        public IList<Departamento> ObterPeloId(Filial f)
        {
            IQuery buscaDepartamento = Session.CreateQuery($"select d from Departamento d where d.Filial = {f.Id}");
            var list = buscaDepartamento.List<Departamento>().ToList();
            return list;

        }

        internal Departamento ObterPeloId(string id)
        {
            IQuery buscaDepartamento = Session.CreateQuery($"select d from Departamento d where d.Id = {id}");
            var list = buscaDepartamento.List<Departamento>().FirstOrDefault();
            return list;
        }

        internal Departamento ObterPeloId(long id)
        {
            return Session.Get<Departamento>(id);
        }

    }
}