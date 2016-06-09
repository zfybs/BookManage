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
    public partial class frmIssueBook : Form
    {
        DataSet da;
        public frmIssueBook()
        {
            InitializeComponent();
        }

        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select BookInfo.BookID,BookName,IssBookID,IssDateTime from IssueInfo,BookInfo where BookInfo.BookID=IssueInfo.BookID");
            this.dgvIssInfo.DataSource = ds.Tables[0];

            da = DataAccess.GetDataSetBySql("select * from bookinfo");
            this.cboBookName.DataSource = da.Tables[0];
            this.cboBookName.DisplayMember = "BookName";
            this.cboBookName.ValueMember = "BookID";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow objRow in da.Tables[0].Rows)
            {
                if (string.Compare(cboBookName.Text, objRow["BookName"].ToString(), true) == 0)
                {
                    this.txtBookAccessCode.Text = objRow["BookIssue"].ToString();
                    this.txtAuthor.Text = objRow["BookAuthor"].ToString();
             
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(this.cboBookName.SelectedValue);
            int issbookid = Convert.ToInt32(this.txtIssID.Text);
            DateTime  date = Convert.ToDateTime(this.dateTimePicker1.Text);
            string sql = string.Format("insert into IssueInfo values({0},{1},'{2}')", bookid, issbookid, date);
            if (DataAccess.UpdateDataTable(sql))
            {
                MessageBox.Show("借阅成功");
            
            }
            DataSet data = DataAccess.GetDataSetBySql("select BookInfo.BookID,BookName,IssUBookID,IssDateTime from IssueInfo,BookInfo where BookInfo.BookID=IssueInfo.BookID");
            this.dgvIssInfo.DataSource = data.Tables[0];

        }
    }
}
