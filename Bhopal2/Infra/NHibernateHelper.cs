using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate;

namespace Bhopal2.Infra
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory = null;

        public static Configuration RecuperaConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            
            return cfg;
        }

        public static ISession GetSession()
        {
            return GetSessionFactory().OpenSession();
        }

        public static ISessionFactory GetSessionFactory()
        {
            if (_sessionFactory == null)
            {
                InitializeSessionFactory();
            }
            return _sessionFactory;
        }

        private static void InitializeSessionFactory()
        {
            if (_sessionFactory == null)
            {
                var cfg = RecuperaConfiguracao();
                _sessionFactory = cfg.BuildSessionFactory();
            }
        }

        public static void GeraSchema()
        {
            Configuration cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }


    }
}