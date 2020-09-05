using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  我们会使用SQLServer提供程序,然而,使用ADO.NET工厂模式来获得更好的灵活性也是可以的
using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer
{
    public class InventoryDAL
    {
        //  这个成员会被所有方法使用
        private SqlConnection sqlCn = null;

        public void OpenConnection(string connectionString)
        {
            sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
        }

        public void CloseConnection()
        {
            sqlCn.Close();
        }

        public void InsertAuto(int id, string color, string make, string petName)
        {
            //  注意SQL查询中的"占位符"
            string sql = string.Format("Insert Into Inventory " +
                "(CarID,Make,Color,PetName) values " +
                "(@CarID,@Make,@Color,@PetName)");

            //  这个命令又内部参数
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                //  填充参数集合
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CarID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Color";
                param.Value = color;
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Make";
                param.Value = make;
                param.SqlDbType = SqlDbType.VarChar;
                param.Size = 50;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@PetName";
                param.Value = petName;
                param.SqlDbType = SqlDbType.NChar;
                param.Size = 10;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public void InsertAuto(NewCar car)
        {
            //  格式化并且执行SQL语句
            string sql = string.Format("Insert Into Inventory " +
                "(CarID,Make,Color,PetName) values " +
                "('{0}','{1}','{2}','{3}')", car.CarID, car.Make, car.Color, car.PetName);

            //  使用我们的连接来执行
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCar(int id)
        {
            //  获取要删除的汽车的ID,然后删除
            string sql = string.Format("Delete from Inventory where CarID = '{0}')", id);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! That car is on order!", ex);
                    throw;
                }
            }
        }

        public void UpdateCarPetName(int id, string newPetName)
        {
            //  获取要修改的汽车的ID以及新的昵称
            string sql = string.Format("Update Inventory Set PetName = '{0}' Where CarID = '{1}'",
                newPetName, id);

            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public List<NewCar> GetAllInventoryAsList()
        {
            //  这将保存记录
            List<NewCar> inv = new List<NewCar>();

            //  准备命令对象
            string sql = "Select * From Inventory";
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inv.Add(new NewCar
                    {
                        CarID = (int)dr["CarID"],
                        Color = (string)dr["Color"],
                        Make = (string)dr["Make"],
                        PetName = (string)dr["PetName"]
                    });
                }
                dr.Close();
            }
            return inv;
        }

        public DataTable GetAllInventoryAsDataTable()
        {
            //  它会保存记录
            DataTable inv = new DataTable();

            //  准备命令对象
            string sql = "Select * From Inventory";
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                //  用读取器的数据填充DataTable并且清理
                inv.Load(dr);
                dr.Close();
            }
            return inv;
        }

        public string LookUpPetName(int carID)
        {
            string carPetName = string.Empty;

            //  设定存储过程名
            using (SqlCommand cmd = new SqlCommand("GetPetName", this.sqlCn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                //  输入参数
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@carID";
                param.SqlDbType = SqlDbType.Int;
                param.Value = carID;

                //  默认的方向即为Input,但为了更清楚
                param.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(param);

                //  输出参数
                param = new SqlParameter();
                param.ParameterName = "@petName";
                param.SqlDbType = SqlDbType.Char;
                param.Size = 10;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                //  执行存储过程
                cmd.ExecuteNonQuery();

                carPetName = cmd.Parameters["@petName"].Value as string;
            }

            return carPetName;
        }

        public void ProcessCreditRisk(bool throwEx, int custID)
        {
            //  首先,基于客户ID查询当前的名字
            string fName = string.Empty;
            string lName = string.Empty;
            SqlCommand cmdSelect = new SqlCommand(
                string.Format("Select * From Customers Where CustID = {0}", custID),
                sqlCn);
            using (SqlDataReader dr = cmdSelect.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    fName = (string)dr["FirstName"];
                    lName = (string)dr["LastName"];
                }
                else
                    return;
            }

            //  创建每一步操作的命令对象
            SqlCommand cmdRemove = new SqlCommand(
                string.Format("Delete from Customers where CustID = {0}", custID),
                sqlCn);

            SqlCommand cmdInsert = new SqlCommand(
                string.Format("Insert Into CreditRisks (CustID,FirstName,LastName) values ({0},'{1}','{2}')", custID, fName, lName),
                sqlCn);

            //  我们会从连接对象获得
            SqlTransaction tx = null;
            try
            {
                tx = sqlCn.BeginTransaction();

                //  将命令加入到事务
                cmdInsert.Transaction = tx;
                cmdRemove.Transaction = tx;

                //  执行命令
                cmdInsert.ExecuteNonQuery();
                cmdRemove.ExecuteNonQuery();

                //  模拟错误
                if (throwEx)
                {
                    throw new Exception("Sorry! Database error! Tx failed...");
                }

                //  提交
                tx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //  有任何错误都会回滚事务
                tx.Rollback();
            }
        }
    }
}
