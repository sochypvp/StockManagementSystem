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
    public class GoodsController
    {
        private SqlConnection MyCon = null;

        public GoodsController(DBuser user)
        {
            DBServerConnection dbCon = new DBServerConnection();
            this.MyCon = dbCon.conn(user.loginName,user.password);
        }

        public List<DBgoods> getAllGoods()
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_goods"; // INNER JOIN tbl_groupsGoods ON tbl_goods.goodsGroupsId = tbl_groupsGoods.groupsId

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgoods(
                            reader["Id"].ToString(),
                            reader["barcode"].ToString(),
                            reader["goodsName"].ToString(),
                            reader["goodsModel"].ToString(),
                            reader["goodsQty"].ToString(),
                            reader["goodsDescription"].ToString(),
                            reader["goodsDetails"].ToString(),
                            reader["dateStored"].ToString(),
                            reader["goodsGroupsId"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBgoods> getGoodsForOrder()
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT barcode,goodsName,goodsModel,goodsQty,goodsGroupsId FROM tbl_goods"; // INNER JOIN tbl_groupsGoods ON tbl_goods.goodsGroupsId = tbl_groupsGoods.groupsId

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DBgoods listGoods = new DBgoods();
                    listGoods.barcode = reader["barcode"].ToString();
                    listGoods.goodsName = reader["goodsName"].ToString();
                    listGoods.goodsModel = reader["goodsModel"].ToString();
                    listGoods.goodsQty = reader["goodsQty"].ToString();
                    listGoods.goodsGroups = reader["goodsGroupsId"].ToString();
                    listDb.Add(listGoods);
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBgoods> goodsIdFilter(string id)
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_goods WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgoods(
                            reader["Id"].ToString(),
                            reader["barcode"].ToString(),
                            reader["goodsName"].ToString(),
                            reader["goodsModel"].ToString(),
                            reader["goodsQty"].ToString(),
                            reader["goodsDescription"].ToString(),
                            reader["goodsDetails"].ToString(),
                            reader["dateStored"].ToString(),
                            reader["goodsGroupsId"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBgoods> goodsGroupsIdFilter(string id)
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_goods WHERE goodsGroupsId = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgoods(
                            reader["Id"].ToString(),
                            reader["barcode"].ToString(),
                            reader["goodsName"].ToString(),
                            reader["goodsModel"].ToString(),
                            reader["goodsQty"].ToString(),
                            reader["goodsDescription"].ToString(),
                            reader["goodsDetails"].ToString(),
                            reader["dateStored"].ToString(),
                            reader["goodsGroupsId"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBgoods> goodsNameFilter(string name)
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_goods WHERE goodsName = @name";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgoods(
                            reader["Id"].ToString(),
                            reader["barcode"].ToString(),
                            reader["goodsName"].ToString(),
                            reader["goodsModel"].ToString(),
                            reader["goodsQty"].ToString(),
                            reader["goodsDescription"].ToString(),
                            reader["goodsDetails"].ToString(),
                            reader["dateStored"].ToString(),
                            reader["goodsGroupsId"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBgoods> goodsQtyFilter(int qty)
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_goods WHERE goodsQty <= @qty";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@qty", qty);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgoods(
                            reader["Id"].ToString(),
                            reader["barcode"].ToString(),
                            reader["goodsName"].ToString(),
                            reader["goodsModel"].ToString(),
                            reader["goodsQty"].ToString(),
                            reader["goodsDescription"].ToString(),
                            reader["goodsDetails"].ToString(),
                            reader["dateStored"].ToString(),
                            reader["goodsGroupsId"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBgoods> goodsStandardQtyFilter(int qty)
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_goods WHERE goodsQty > @qty";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@qty", qty);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgoods(
                            reader["Id"].ToString(),
                            reader["barcode"].ToString(),
                            reader["goodsName"].ToString(),
                            reader["goodsModel"].ToString(),
                            reader["goodsQty"].ToString(),
                            reader["goodsDescription"].ToString(),
                            reader["goodsDetails"].ToString(),
                            reader["dateStored"].ToString(),
                            reader["goodsGroupsId"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBgoods> goodsFinder(string finderTxt)
        {
            List<DBgoods> listDb = new List<DBgoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_goods WHERE Id LIKE '%"+finderTxt+"%' OR goodsName LIKE '%"+finderTxt+"%'";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgoods(
                            reader["Id"].ToString(),
                            reader["barcode"].ToString(),
                            reader["goodsName"].ToString(),
                            reader["goodsModel"].ToString(),
                            reader["goodsQty"].ToString(),
                            reader["goodsDescription"].ToString(),
                            reader["goodsDetails"].ToString(),
                            reader["dateStored"].ToString(),
                            reader["goodsGroupsId"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        public int getAllGoodsQty()
        {
            try
            {
                MyCon.Open();

                string query = "SELECT goodsQty FROM tbl_goods";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                int qty = 0;

                while (reader.Read())
                {
                    qty += Convert.ToInt32(reader["goodsQty"].ToString());
                }

                MyCon.Close();
                return qty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        public bool addGoods(DBgoods goods)
        {
            try
            {
                MyCon.Open();

                string query = "INSERT INTO tbl_goods(barcode,goodsName,goodsModel,goodsQty,goodsDescription,goodsDetails,goodsGroupsId) " +
                    "VALUES(@barcode,@name,@model,@qty,@desc,@details,@group)";

                SqlCommand cmd = new SqlCommand(query, MyCon);

                cmd.Parameters.AddWithValue("@barcode", goods.barcode);
                cmd.Parameters.AddWithValue("@name", goods.goodsName);
                cmd.Parameters.AddWithValue("@model", goods.goodsModel);
                cmd.Parameters.AddWithValue("@qty", goods.goodsQty);
                cmd.Parameters.AddWithValue("@desc", goods.goodsDescription);
                cmd.Parameters.AddWithValue("@details", goods.goodsDetail);
                cmd.Parameters.AddWithValue("@group", goods.goodsGroups);

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

        public bool modifyGoods(DBgoods goods) //============= Update goods =============================
        {
            try
            {
                MyCon.Open();

                string query = "UPDATE tbl_goods SET " +
                    "barcode=@barcode," +
                    "goodsName=@name," +
                    "goodsModel=@model," +
                    "goodsQty=@qty," +
                    "goodsDescription=@desc," +
                    "goodsDetails=@details," +
                    "goodsGroupsId=@group WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);

                cmd.Parameters.AddWithValue("@barcode", goods.barcode);
                cmd.Parameters.AddWithValue("@name", goods.goodsName);
                cmd.Parameters.AddWithValue("@model", goods.goodsModel);
                cmd.Parameters.AddWithValue("@qty", goods.goodsQty);
                cmd.Parameters.AddWithValue("@desc", goods.goodsDescription);
                cmd.Parameters.AddWithValue("@details", goods.goodsDetail);
                cmd.Parameters.AddWithValue("@group", goods.goodsGroups);
                cmd.Parameters.AddWithValue("@id", goods.ID);

                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public bool modifyGoodsQty(DBgoods goods) //============= Update goods qty =============================
        {
            try
            {
                MyCon.Open();

                string query = "UPDATE tbl_goods SET goodsQty=(SELECT tbl_goods.goodsQty FROM tbl_goods WHERE tbl_goods.barcode = @barcode)-@qty WHERE barcode = @barcode";

                SqlCommand cmd = new SqlCommand(query, MyCon);

                cmd.Parameters.AddWithValue("@barcode", goods.barcode);
                cmd.Parameters.AddWithValue("@qty", goods.goodsQty);

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

        public bool removeGoods(string id)
        {
            try
            {
                MyCon.Open();

                string query = "DELETE tbl_goods WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
    }
}
