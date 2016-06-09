using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookManage
{
    public partial class frmUpdateBook : Form
    {
        DataSet ds = new DataSet();
        public frmUpdateBook()
        {
            InitializeComponent();
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)
        {
            string sql = "select * from bookinfo";
            ds = DataAccess.GetDataSetBySql(sql);
            this.dgvBookInfo.DataSource=ds.Tables[0];
            this.txtbID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string booktype = this.txtbType.Text.ToString();
            string bookname = this.txtbName.Text.ToString();
            string bookauthor = this.txtAuthor.Text.ToString();
            Double bookprice = Convert.ToDouble(this.txtbPrice.Text);
            string bookpic = this.txtbPic.Text.ToString();
            string bookcontent = this.txtbContent.Text.ToString();
            int bookissue = Convert.ToInt32(this.txtIssueID.Text);
            string sql = string.Format("update bookInfo set BookType='{0}',BookName='{1}',BookAuthor='{2}',BookPrice={3},BookPic='{4}',BookContent='{5}',BookIssue={6} where BookID={7}", booktype, bookname, bookauthor, bookprice, bookpic, bookcontent, bookissue,Convert.ToInt32(this.txtbID.Text));
            if (DataAccess.UpdateDataTable(sql))
            {
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from BookInfo";
            DialogResult result = MessageBox.Show("确实要将修改保存到数据库吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                DataAccess.UpdateDataSet(ds, sql);
                MessageBox.Show("保存成功");

            }
            this.dgvBookInfo.DataSource = DataAccess.GetDataSetBySql(sql).Tables[0];
        }

        private void dgvBookInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前鼠标单击时的行索引号
            int index = this.dgvBookInfo.CurrentCell.RowIndex;
            //通过索引号获得值并赋予相应的文本框显示
            this.txtbID.Text = this.dgvBookInfo.Rows[index].Cells[0].Value.ToString().Trim();
            this.txtbType.Text = this.dgvBookInfo.Rows[index].Cells[1].Value.ToString().Trim();
            this.txtbName.Text = this.dgvBookInfo.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtAuthor.Text = this.dgvBookInfo.Rows[index].Cells[3].Value.ToString().Trim();
            this.txtbPrice.Text = this.dgvBookInfo.Rows[index].Cells[4].Value.ToString().Trim();
            this.txtbPic.Text = this.dgvBookInfo.Rows[index].Cells[5].Value.ToString().Trim();
            this.txtbContent.Text = this.dgvBookInfo.Rows[index].Cells[6].Value.ToString();
            this.txtIssueID.Text = this.dgvBookInfo.Rows[index].Cells[7].Value.ToString();
        
        }

        private void btnUpdatePic_Click(object sender, EventArgs e)
        {
            string pic = this.txtbPic.Text.ToString();
            int bookid = Convert.ToInt32(this.txtbID.Text);
            frmBookPic bookpic = new frmBookPic();
            bookpic.ShowContent(bookid,pic);
            bookpic.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select * from IssueInfo where BookID="+Convert.ToInt32(this.txtbID.Text)+"");
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("此书有借阅，不能删除");
                return;
            }
            else
            {
                string sql = "delete from bookInfo where BookID=" + this.txtbID.Text + "";
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK);
                }
            }
            this.txtAuthor.Text = "";
            this.txtbContent.Text = "";
            this.txtbID.Text = "";
            this.txtbName.Text = "";
            this.txtbPic.Text = "";
            this.txtbPrice.Text = "";
            this.txtbType.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
