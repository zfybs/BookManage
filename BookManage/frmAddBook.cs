using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookManage
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }
/// <summary>
/// 插入按钮单击事件处理
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void btnInsertBkDt_Click(object sender, EventArgs e)
        {
            //定义变量接收控件的值
            string booktype = this.txtType.Text.ToString();
            string bookname = this.txtName.Text.ToString();
            string bookauthor = this.txtAuthor.Text.ToString();
            Double bookprice = Convert.ToDouble(this.txtPrice.Text);
            string bookpic = this.txtPic.Text.ToString();
            string bookcontent = this.txtContent.Text.ToString();
            int bookissue = Convert.ToInt32(this.txtIssue.Text);
            //如果数据验证通过则调用DataAccess类的方法实现添加功能
            if (Validate())
            {
                //sql语句
                string sql = string.Format("insert into bookinfo values('{0}','{1}','{2}',{3},'{4}','{5}',{6})", booktype, bookname, bookauthor, bookprice, bookpic, bookcontent, bookissue);
                if (DataAccess.UpdateDataTable(sql)) //调用更新方法
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK);
                }
                //DataGridView控件显示数据
                DataSet ds = DataAccess.GetDataSetBySql("select * from BookInfo");
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }
        /// <summary>
        /// 退出按钮单击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //数据验证
        private bool Vaildate()
        {
            if (this.txtType.Text != string.Empty && this.txtName.Text != string.Empty && this.txtAuthor.Text != string.Empty && this.txtContent.Text != string.Empty && this.txtIssue.Text != string.Empty && this.txtPrice.Text != string.Empty)
                return true;
            else
                MessageBox.Show("请输入完整的信息");

            return false;
        }
    }
}
