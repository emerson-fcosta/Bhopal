﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bhopal2.Infra;
using Bhopal2.Models;

namespace Bhopal2.DAO
{
    public class TonerDAO
    {

        public void AdicionaToner(Toner toner)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Save(toner);
            session.Transaction.Commit();

            session.Close();
        }

        public void RemoveToner(Toner toner)
        {
           
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Delete(toner);
            session.Transaction.Commit();

            session.Close();
        }

       
        public void AtualizaToner(Toner toner)
        {
            var session = NHibernateHelper.GetSession();

            session.BeginTransaction();
            session.Update(toner);
            session.Transaction.Commit();

            session.Close(); 
        }
    }
}