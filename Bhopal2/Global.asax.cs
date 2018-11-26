using Bhopal2.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Bhopal2
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //Inicializa a Session Factory do NHibernate
            NHibernateSessionManager.InitializeSessionFactory();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //Inicializa uma transação
            BeginTransaction();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            //Commit e Close session
            CommitAndCloseSession();
        }

        /// <summary>
        /// Opens a session within a transaction at the beginning of the HTTP request.
        /// This doesn't actually open a connection to the database until needed.
        /// </summary>
        private void BeginTransaction()
        {
            NHibernateSessionManager.OpenSession();
        }

        /// <summary>
        /// Commits and closes the NHibernate session provided by the supplied <see cref="NHibernateSessionManager"/>.
        /// Assumes a transaction was begun at the beginning of the request; but a transaction or session does
        /// not *have* to be opened for this to operate successfully.
        /// </summary>
        private void CommitAndCloseSession()
        {            
            ISession session = NHibernateSessionManager.Session;
            session.Flush();
            if (session.Transaction != null && session.Transaction.IsActive)
                session.Transaction.Commit();
            session.Close();
            NHibernateSessionManager.Session = null;
        }
    }

}