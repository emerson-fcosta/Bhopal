using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Bhopal2.Business
{
    public class ImpressoraBusiness
    {

        public Impressora GetByID(long id)
        {
            var session = NHibernateHelper.GetSession();
            return session.Get<Impressora>(id);
        }

        public void buscaTodasImpressoras()
        {
            var session = NHibernateHelper.GetSession();

            IQuery buscaImpressora = session.CreateQuery("from Impressora i order by i.Id");
            IList<Impressora> impressoras = buscaImpressora.List<Impressora>();

            foreach (Impressora impressora in impressoras)
            {
                //...
            }
        }

        public void buscaImpressoraPorModelo()
        {
            var session = NHibernateHelper.GetSession();
            
            IQuery buscaImpressora = session.CreateQuery("from Impressora i order by i.Id join fetch i.Modelo.Nome");
            IList<Impressora> impressoras = buscaImpressora.List<Impressora>();

            foreach (Impressora impressora in impressoras)
            {
                //...
            }
        }

        public void buscaImpressoraPorCodigo()
        {
            var session = NHibernateHelper.GetSession();

            //verificar este metodo
            IQuery buscaImpressora = session.CreateQuery("from Impressora i where i.Codigo = idImpressora order by i.Id");
            buscaImpressora.SetParameter("idImpressora", 0);
            IList<Impressora> impressoras = buscaImpressora.List<Impressora>();

            foreach (Impressora impressora in impressoras)
            {
                //...
            }
    
        }

        public IList<Impressora> retornaImpressoras()
        {
            var session = NHibernateHelper.GetSession();

            IQuery buscaImpressoras = session.CreateQuery($"from Impressora i");
            List<Impressora> list = (List<Impressora>)buscaImpressoras.List<Impressora>();
            return list;
        }


    }
}