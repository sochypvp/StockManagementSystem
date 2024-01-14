using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.DBClasses
{
    public class DBuser
    {
        public string Id { get; set; }
        public string userName { get; set; }
        public string loginName { get; set; }
        public string password { get; set; }
        public DBuser() { }
        public DBuser(string loginName, string password)
        {
            this.loginName = loginName;
            this.password = password;
        }
        public DBuser(string id, string userName, string loginName, string password)
        {
            Id = id;
            this.userName = userName;
            this.loginName = loginName;
            this.password = password;
        }
    }
}
