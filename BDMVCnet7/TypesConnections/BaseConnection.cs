using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMVCnet7.TypesConnections
{
    public   abstract class BaseConnection: IBDConnection
    {
        public string Server { get; set; }
        public string Catalog { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public BaseConnection(string _Server, string _Catalog, string _User, string _Password)
        {
            Server= _Server;
            Catalog= _Catalog;
            User= _User;
            Password= _Password;
        }

        public abstract object ExecutionQuery(string query);
    }
}
