using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMG.src.Components.DBConnection
{
    public class DBServerConnection
    {
        //private SqlConnection conn;
        protected string serverName = "localhost";
        protected string databaseName = "db_warehouse";
        protected string userName = "";
        protected string password = "";

        public DBServerConnection()
        {
            
        }
        public SqlConnection conn(string username, string password)
        {
            this.userName = username;
            this.password = password;
            return new SqlConnection("Server="+ this.serverName +";Database="+ this.databaseName +";User Id="+ this.userName +";Password="+ this.password +";");
        }

        protected SqlConnection conn()
        {
            return new SqlConnection("Server=localhost;Database=db_warehouse;Trusted_Connection=True;");
        }
    }
}
