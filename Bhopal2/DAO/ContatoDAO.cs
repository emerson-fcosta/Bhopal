using Bhopal2.Infra;
using Bhopal2.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.DAO
{
    public class ContatoDAO : GenericDAO
    {
        
        public void AdicionaContato(Contato contato)
        {
            Session.Save(contato);
        }


        public void RemoveContato(Contato contato)
        {
            Session.Delete(contato);
        }

        public void AtualizaContato(Contato contato)
        {
            Session.Update(contato);
        }
    }
}