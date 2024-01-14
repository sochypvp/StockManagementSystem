using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.DBConnection;

namespace WarehouseMG.src.Components.Controller
{
    public class LineItemController
    {
        private DBuser user;
        private SqlConnection MyCon;

        public LineItemController(DBuser user)
        {
            this.user = user;
            DBServerConnection dbCon = new DBServerConnection();
            this.MyCon = dbCon.conn(this.user.loginName, this.user.password);
        }

        public bool addLine(DBlineItems dBlineItems)
        {
            try
            {
                MyCon.Open();

                string query = "INSERT INTO tbl_lineItems VALUES(@orderId,@goodsId,@qty)";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@orderId",dBlineItems.orderId);
                cmd.Parameters.AddWithValue("@goodsId", dBlineItems.goodsId);
                cmd.Parameters.AddWithValue("@qty", dBlineItems.qtyOrdered);
                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public List<DBlineItems> getLineByOrderId(string orderId)
        {
            try
            {
                MyCon.Open();

                List<DBlineItems> dBlineItems = new List<DBlineItems>();

                string query = "EXECUTE getLineItems @orderId = " + orderId;

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DBlineItems newLineItems = new DBlineItems();
                    newLineItems.lineId = reader["lineId"].ToString();
                    newLineItems.goodsId = reader["goodsId"].ToString();
                    newLineItems.qtyOrdered = reader["qtyOrdered"].ToString();
                    newLineItems.Goods.barcode = reader.GetString(3);
                    newLineItems.Goods.goodsName = reader["goodsName"].ToString();
                    newLineItems.Goods.goodsModel = reader["goodsModel"].ToString();
                    newLineItems.Goods.goodsGroups = reader["goodsGroupsId"].ToString();

                    dBlineItems.Add(newLineItems);
                }


                MyCon.Close();
                return dBlineItems;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
    }
}
