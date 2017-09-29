using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Northwind.Settings
{
    public class Config
    {
        public class NorthwindAPI
        {
            private  const string __ACTIVE_ENVIRONMENT = "ACTIVE_ENVIRONMENT";
            private  const string __NORTWINDDBCONNECTION = "NORTWINDDBCONNECTION";
            private static string _Environment = null;
            public static string Environment
            {
                get
                {
                    if (_Environment != null)
                    {
                        return _Environment;
                    }
                    else
                    {
                        
                        return _Environment = string.Concat("_", ConfigurationManager.AppSettings[__ACTIVE_ENVIRONMENT]);
                    }
                }
            }

            public static string NortwindDbConnection
            {
                get
                {
                    return ConfigurationManager.AppSettings[string.Concat(__NORTWINDDBCONNECTION, Environment)];
                }

            }
            public static string EnvTest
            {
                get
                {
                    return ConfigurationManager.AppSettings[string.Concat("ENVTEST", Environment)];
                }

            }
        }
    }
}
