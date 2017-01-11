using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bhopal2.Infra;

namespace Bhopal2.Business
{
    public class PedidoDeTonerBusiness
    {
        public void BuscaTodosPedidos()
        {
            var session = NHibernateHelper.GetSession();
           
            string buscaPedido = "from PedidoDeToner p order by p.Id";
            IQuery executaQuery = session.CreateQuery(buscaPedido);
            IList<PedidoDeToner> pedidos = executaQuery.List<PedidoDeToner>();

            foreach (PedidoDeToner pedido in pedidos)
            {
               //...
            }

            session.Close();
        }

        public void BuscaPedidosPorFilial()
        {
            var session = NHibernateHelper.GetSession();
            
            string buscaPedido = "from PedidoDeToner p order by p.Id join fetch p.Filial.Nome";
            IQuery executaQuery = session.CreateQuery(buscaPedido);
            IList<PedidoDeToner> pedidos = executaQuery.List<PedidoDeToner>();

            foreach (PedidoDeToner pedido in pedidos)
            {
                //...
            }

            session.Close();
        }


        public void BuscaPedidosPorChamado()
        {
            var session = NHibernateHelper.GetSession();
            
            IQuery buscaPedido = session.CreateQuery("from PedidoDeToner p where p.NumeroChamado = :chamado order by p.Id");
            buscaPedido.SetParameter("chamado", 0);
            IList<PedidoDeToner> pedidos = buscaPedido.List<PedidoDeToner>();

            foreach (PedidoDeToner pedido in pedidos)
            {
                //...
            }

            session.Close();
        }

    }
}