using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DBClasses;

namespace WarehouseMG.src.Components.Controller
{
    public class goodsLocalController
    {
        public List<DBgoods> goods = null;

        public goodsLocalController(List<DBgoods> goods)
        {
            this.goods = goods;
        }
        public void saveData (List<DBgoods> goods)
        {
            this.goods = goods;
        }
        public List<DBgoods> goodsGroupsIdFilter(string groupsId)
        {
            if(this.goods != null)
            {
                List<DBgoods> newGoods = new List<DBgoods>();
                foreach(var s in this.goods)
                {
                    if (groupsId.Equals(s.goodsGroups))
                    {
                        DBgoods listGoods = new DBgoods();
                        listGoods.ID = s.ID;
                        listGoods.barcode = s.barcode;
                        listGoods.goodsName = s.goodsName;
                        listGoods.goodsModel = s.goodsModel;
                        listGoods.goodsQty = s.goodsQty;
                        listGoods.goodsGroups = s.goodsGroups;
                        newGoods.Add(listGoods);
                    }
                }
                return newGoods;
            }
            else
            {
                return null;
            }
        }
    }
}
