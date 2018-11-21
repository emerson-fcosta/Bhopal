using Bhopal2.Infra;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.DAO
{
    public class PedidoDeTonerDAO : GenericDAO
    {

        public void AdicionaPedido(PedidoDeToner pedido)
        {
            Session.Save(pedido);
        }

        public void RemovePedido(PedidoDeToner pedido)
        {
            Session.Delete(pedido);
        }

        public void AtualizaPedido(PedidoDeToner pedido)
        {
            Session.Update(pedido);
        }
    }
}