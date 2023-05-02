using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMVCnet7.TypesConnections
{
    internal  interface IBDConnection
    {
        public object ExecutionQuery(string query)
        {
            return null;
        }
    }
}
