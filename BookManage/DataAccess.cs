using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BookManage
{
    class DataAccess
    {
        ///private static string ConnectString = "server=(local)\\sqlexpress;database=Book;user=sa;pwd=1234";//数据库连接字符串
        private static string ConnectString = @"Data Source=(local) \SQLEXPRESS;Initial Catalog=BookManage;Integrated Security=True;Pooling=False";//数据库连接字符串
        /// <summary>
        /// 根据表名获取数据集的表
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static DataTable GetDataSetByTableName(string table)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                string sql = "select * from " + table + "";//查询sql语句
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);//创建适配器对象
                    DataSet ds = new DataSet();//创建数据集对象
                    adapter.Fill(ds, "table");//填充数据集
                    return ds.Tables[0];//返回数据表
                }
                catch (SqlException ex)
                {
                    //异常处理
                    throw new Exception(ex.Message); ;
                }
            }
        }

        //public static DataSet GetDataSetBySql(string sql, string table)
        //{
        //    using (SqlConnection con = new SqlConnection(ConnectString))
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
        //        DataSet ds = new DataSet();
        //        adapter.Fill(ds, "table");
        //        return ds;
        //    }

        //}
        /// <summary>
        /// 根据Sql语句获取数据集对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSetBySql(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);//创建适配器对象
                DataSet ds = new DataSet();//创建数据集对象
                try
                {
                    adapter.Fill(ds);//填充数据集
                    return ds;//返回数据集
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
            }

        }
        /// <summary>
        /// 根据id值获取DataReader对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReaderByID(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = "select * from bookinfo where bookid=" + id;//sql语句

                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return reader;//返回DataReader
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool UpdateDataTable(string sql)
        {

            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                try
                {
                    con.Open();//打开连接
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    if (comm.ExecuteNonQuery() > 0) //执行更新
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 根据数据集和sql语句更新数据库
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="sql"></param>
        public static void UpdateDataSet(DataSet ds, string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);//创建适配器
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//根据适配器自动生成表单
                    adapter.Update(ds, "table");//更新数据库

                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
            }

        }
    }
}
