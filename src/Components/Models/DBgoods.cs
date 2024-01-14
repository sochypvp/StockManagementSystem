using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.DBClasses
{
    public class DBgoods
    {
        public string ID { get; set; }
        public string barcode { get; set; }
        public string goodsName { get; set; }
        public string goodsModel { get; set; }
        public string goodsQty { get; set; }
        public string goodsDescription { get; set; }
        public string goodsDetail { get; set;}
        public string dateStored { get; set; }
        public string goodsGroups { get; set;}
        public DBgoods()
        {

        }
        public DBgoods(string barcode, string goodsName, string goodsModel)
        {
            this.barcode = barcode;
            this.goodsName = goodsName;
            this.goodsModel = goodsModel;
        }
        public DBgoods(string barcode, string goodsName, string goodsModel, string goodsDescription, string goodsDetail, string goodsGroups)
        {
            this.barcode = barcode;
            this.goodsName = goodsName;
            this.goodsModel = goodsModel;
            this.goodsDescription = goodsDescription;
            this.goodsDetail = goodsDetail;
            this.goodsGroups = goodsGroups;
        }
        public DBgoods(string iD, string barcode, string goodsName, string goodsModel, string goodsDescription, string goodsDetail, string goodsGroups)
        {
            this.ID = iD;
            this.barcode = barcode;
            this.goodsName = goodsName;
            this.goodsModel = goodsModel;
            this.goodsDescription = goodsDescription;
            this.goodsDetail = goodsDetail;
            this.goodsGroups = goodsGroups;
        }
        public DBgoods(string iD, string barcode, string goodsName, string goodsModel, string goodsDescription, string goodsDetail, string dateStored, string goodsGroups)
        {
            this.ID = iD;
            this.barcode = barcode;
            this.goodsName = goodsName;
            this.goodsModel = goodsModel;
            this.goodsDescription = goodsDescription;
            this.goodsDetail = goodsDetail;
            this.dateStored = dateStored;
            this.goodsGroups = goodsGroups;
        }
        public DBgoods(string iD, string barcode, string goodsName, string goodsModel, string qty, string goodsDescription, string goodsDetail, string dateStored, string goodsGroups)
        {
            this.ID = iD;
            this.barcode = barcode;
            this.goodsName = goodsName;
            this.goodsModel = goodsModel;
            this.goodsQty = qty;
            this.goodsDescription = goodsDescription;
            this.goodsDetail = goodsDetail;
            this.dateStored = dateStored;
            this.goodsGroups = goodsGroups;
        }
        public DBgoods(string iD, string barcode, string goodsName, string goodsModel)
        {
            this.ID = iD;
            this.barcode = barcode;
            this.goodsName = goodsName;
            this.goodsModel = goodsModel;
        }
    }
}
