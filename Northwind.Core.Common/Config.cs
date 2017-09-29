//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Configuration;

//namespace Northwind.Core.Common
//{

//    public class Config
//    {
//        private static string _Environment = null;
//        public static string Environment
//        {
//            get
//            {
//                if(_Environment != null)
//                {
//                    return _Environment;
//                }
//                else
//                {
//                    return _Environment = string.Concat("_", ConfigurationManager.AppSettings["ACTIVE_ENVIRONMENT"]);
//                }          
//            }
//        }

//        public static string NortwindDbConnectionString
//        {
//            get
//            {
//                return string.Concat(ConfigurationManager.AppSettings["NortwindDbConnectionString"],Environment);
//            }
           
//        }
//        public static string EnvTest
//        {
//            get
//            {
//                return ConfigurationManager.AppSettings[string.Concat("ENVTEST", Environment)];
//            }

//        }
//    }
//}
