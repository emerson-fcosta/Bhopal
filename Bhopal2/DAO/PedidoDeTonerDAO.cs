using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.DAO
{
    public class PedidoDeTonerDAO
    {

        public void AdicionaPedido(PedidoDeToner pedido)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(pedido);
            session.Transaction.Commit();

            session.Close();
        }

        public void RemovePedido(PedidoDeToner pedido)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(pedido);
            session.Transaction.Commit();

            session.Close();
        }

        public void AtualizaPedido(PedidoDeToner pedido)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(pedido);
            session.Transaction.Commit();

            session.Close();
        }
    }
}