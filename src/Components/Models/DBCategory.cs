using System.Collections.Generic;

namespace Warehouse.DBClasses
{
    public class DBCategory
    {
        private List<DBgroupsGoods> groupsGoods = new List<DBgroupsGoods>();
        public string categId { get; set; }
        public string categName { get; set; }
        public string totalGroups { get; set; }
        public string totalGoods { get; set; }
        public List<DBgroupsGoods> GroupsGoods
        {
            get { return groupsGoods; }
            set { groupsGoods = value; }
        }
        public DBCategory(string categId, string categName, string totalGroups, string totalGoods)
        {
            this.categId = categId;
            this.categName = categName;
            this.totalGroups = totalGroups;
            this.totalGoods = totalGoods;
        }
        public DBCategory(string categName)
        {
            this.categName = categName;
        }
        public DBCategory() { }
    }
}
