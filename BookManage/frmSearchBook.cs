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
    public partial class frmSearchBook : Form
    {
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string cbo1 = this.cboOR.Text;
            string cbo2 = this.cboAnd.Text;
            string booktype = cboType.Text;
            string bookname = this.txtName.Text;
            string bookcontent = this.txtContent.Text;
            //定义sql语句
            string sql = "select * from bookInfo where BookType='" + booktype + "' " + cbo1 + " BookName like '%" + bookname + "%' " + cbo2 + " BookContent like '%" + bookcontent + "%'";
            //调用DataAccess.GetDataSetBySql方法
            DataSet Myds = DataAccess.GetDataSetBySql(sql);
            DataTable table = Myds.Tables[0];
            //指定数据源
            this.dgvSearchBook.DataSource = table;
          
        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            //图书类别组合框初始化
            DataSet Myds = DataAccess.GetDataSetBySql("select distinct BookType from bookInfo");
            DataTable table = Myds.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.cboType.Items.Add(table.Rows[i][0].ToString().Trim());
            }
            cboType.SelectedIndex = 0;
            this.cboOR.SelectedIndex = 0;
            this.cboAnd.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
