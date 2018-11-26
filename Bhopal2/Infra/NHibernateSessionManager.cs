using NHibernate;
using NHibernate.Cfg;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Bhopal2.Infra
{
    internal class NHibernateSessionManager
    {
        private static ISessionFactory _sessionFactory = null;
        private const string TRANSACTION_KEY = "CONTEXT_TRANSACTION";
        private const string SESSION_KEY = "CONTEXT_SESSION";

        /// <summary>
        /// Retorna a Factory de Session do NHibernate
        /// </summary>
        /// <returns>um objeto do tipo ISessionFactory</returns>
        public static ISessionFactory GetSessionFactory()
        {
            InitializeSessionFactory();
            return _sessionFactory;
        }

        /// <summary>
        /// Retorna uma nova Session para ser usado na aplicação
        /// </summary>
        /// <returns>ISession</returns>
        public static ISession GetSession()
        {
            var session = GetSessionFactory().OpenSession();
            return session;
        }

        /// <summary>
        /// Cria e inicializa a sessão para ser usada no contexto.
        /// </summary>
        public static void OpenSession()
        {
            //Seta uma sessão nova para ser usada.
            Session = GetSession();
        }

        /// <summary>
        /// Inicializa a Session Factory do nHibernate
        /// </summary>
        public static void InitializeSessionFactory()
        {
            if (_sessionFactory == null)
            {
                var configuration = new Configuration();
                //var engine = new ValidatorEngine();

                try
                {
                    configuration.Configure();
                    //configuration.IntegrateWithEnvers(new AttributeConfiguration());

                    //engine.Configure();
                    //ValidatorInitializer.Initialize(configuration, engine);

                    _sessionFactory = configuration.BuildSessionFactory();
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }

            }
        }

        /// <summary>
        /// Finaliza a SessionFactory criada
        /// </summary>
        public static void CloseSessionFactory()
        {
            GetSessionFactory().Close();
        }


        /// <summary>
        /// Verifica se está no contexto Web
        /// </summary>
        /// <returns></returns>
        private static bool IsInWebContext()
        {
            return HttpContext.Current != null;
        }

        /// <summary>
        /// Retorna a Session correspondente a requisição implementação do padrão "Open Session in View"
        /// </summary>
        public static ISession Session
        {
            get
            {
                if (IsInWebContext())
                {
                    return (ISession)HttpContext.Current.Items[SESSION_KEY];
                }
                else
                {
                    return (ISession)CallContext.GetData(SESSION_KEY);
                }
            }
            set
            {
                if (IsInWebContext())
                {
                    HttpContext.Current.Items[SESSION_KEY] = value;
                }
                else
                {
                    CallContext.SetData(SESSION_KEY, value);
                }
            }
        }
    }
}