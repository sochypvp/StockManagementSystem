using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMG.src.Components.Models
{
    public class DBUserAccount
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }

        public DBUserAccount() { }
        public DBUserAccount(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public DBUserAccount(string id, string username, string password, string userId)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.UserId = userId;
        }
    }
}
