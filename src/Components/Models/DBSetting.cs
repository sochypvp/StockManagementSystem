using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.DBConnection;

namespace WarehouseMG.src.Components.Models
{
    public class DBSetting
    {
        string Id { get; set; }
        string SttCode { get; set; }
        string SttStatus { get; set; }
        public DBSetting()
        {
        }
        public DBSetting(string id, string sttCode, string sttStatus)
        {
            Id = id;
            SttCode = sttCode;
            SttStatus = sttStatus;
        }

    }
}
