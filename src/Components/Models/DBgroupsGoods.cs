using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.DBClasses
{
    public class DBgroupsGoods
    {
        private List<DBgoods> goods = new List<DBgoods>();
        public List<DBgoods> Goods
        {
            get { return goods; }
            set { goods = value; }
        }

        public string groupsId { get; set; }
        public string groupsName { get; set; }
        public string totalGoods { get; set; }
        public string categId { get; set; }

        public DBgroupsGoods() 
        {
            
        }
        public DBgroupsGoods(List<DBgoods> goods)
        {
            this.Goods = goods;
        }
        public DBgroupsGoods(string groupsName, string categId)
        {
            this.groupsName = groupsName;
            this.categId = categId;
        }
        public DBgroupsGoods(string groupsId, string groupsName, string totalGoods, string categId)
        {
            this.groupsId = groupsId;
            this.groupsName = groupsName;
            this.totalGoods = totalGoods;
            this.categId = categId;
        }
    }
    
}
