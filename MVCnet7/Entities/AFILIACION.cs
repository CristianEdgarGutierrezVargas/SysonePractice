using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMVCnet7.Entities
{
    public class AFILIACION
    {
        public long ID { get; set; }
        public string ID_POLIZA { get; set; }
        public string ID_PERSONA { get; set; }
        
        public AFILIACION()
        {
            ID = 0;
            ID_POLIZA= string.Empty;    
            ID_PERSONA= string.Empty;
        }
    }
}
