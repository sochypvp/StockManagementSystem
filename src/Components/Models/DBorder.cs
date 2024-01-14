using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Warehouse.DBClasses
{
    public class DBorder
    {
        public string orderId { get; set; }
        public string orderDate { get; set; }
        public string customerId { get; set; }
        public string userId { get; set; }
        public DBorder() { }
        public DBorder(string orderId, string orderDate, string customerId, string userId)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.customerId = customerId;
            this.userId = userId;
        }
    }
}
