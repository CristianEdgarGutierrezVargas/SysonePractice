using BDMVCnet7;
using BDMVCnet7.TypesConnections;
using BDMVCnet7.Entities;
using System.Data;

namespace BDMVCnet7
{
    public class DataBase
    {
        private BaseConnection instanceDBConnection;

        public DataBase(string _Server, string _Catalog, string _User, string _Password) 
        {
            //solo que cambia aqui otro tipo de conexion a una base de datos
            instanceDBConnection = new SQLServer( _Server,  _Catalog,  _User,  _Password);
        }

        public List<AFILIACION> GetListAfiliacion()
        {
            string query = "SELECT TOP (1000) [ID]\r\n      ,[ID_POLIZA]\r\n      ,[ID_PERSONA]\r\n  FROM [SYSONE].[dbo].[AFILIACION]";
            List<AFILIACION> result = new List<AFILIACION>();

            var resultQuery = (DataTable)instanceDBConnection.ExecutionQuery(query);
            foreach (DataRow item in resultQuery.Rows)
            { 
                AFILIACION itemAfiliacion=new AFILIACION();
                itemAfiliacion.ID = (long) item.ItemArray[0] ;
                itemAfiliacion.ID_POLIZA= (string)item.ItemArray[1];
                itemAfiliacion.ID_PERSONA= (string)item.ItemArray[2];
                result.Add(itemAfiliacion);
            }

            return result;  
        }
    }
}