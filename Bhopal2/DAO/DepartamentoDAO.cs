using Bhopal2.Infra;
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

       public void AdicionaDepartamento(Departamento departamento)
        {
            Session.Save(departamento);
        }


        public void RemoveDepartamento(Departamento departamento)
        {
            Session.Delete(departamento);
        }


        public void AtualizaDepartamento(Departamento departamento)
        {
            Session.Update(departamento);
        }

        public IList<Departamento> GetAll()
        {            
            IQuery buscaDepartamento = Session.CreateQuery($"from Departamento d");
            var list = (List<Departamento>)buscaDepartamento.List<Departamento>();
            return list;
        }

        public IList<Departamento> getByFilial(Filial f)
        {
            IQuery buscaDepartamento = Session.CreateQuery($"from Departamento d where d.Filial = {f.Id}");
            var list = buscaDepartamento.List<Departamento>().ToList();
            return list;

        }

        internal Departamento getById(string id)
        {
            IQuery buscaDepartamento = Session.CreateQuery($"from Departamento d where d.Id = {id}");
            var list = buscaDepartamento.List<Departamento>().FirstOrDefault();
            return list;
        }

    }
}