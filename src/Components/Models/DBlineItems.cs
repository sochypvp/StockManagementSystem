using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.DBClasses
{
    public class DBlineItems
    {
        DBgoods goods = new DBgoods();
        public string lineId { get; set; }
        public string orderId { get; set; } 
        public string goodsId { get; set; }
        public string qtyOrdered { get; set; }
        public DBgoods Goods
        {
            get { return goods; }
            set { goods = value; }
        }
        public DBlineItems() { }
        public DBlineItems(string orderId, string goodsId, string qtyOrdered)
        {
            this.orderId = orderId;
            this.goodsId = goodsId;
            this.qtyOrdered = qtyOrdered;
        }
        public DBlineItems(string lineId, string orderId, string goodsId, string qtyOrdered)
        {
            this.lineId = lineId;
            this.orderId = orderId;
            this.goodsId = goodsId;
            this.qtyOrdered = qtyOrdered;
        }
    }
}
