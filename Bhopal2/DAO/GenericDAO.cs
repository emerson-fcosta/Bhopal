using Bhopal2.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhopal2.DAO
{
    public class GenericDAO
    {
        internal ISession Session
        {
            get
            {
                return NHibernateSessionManager.Session;
            }
        }


    }
}