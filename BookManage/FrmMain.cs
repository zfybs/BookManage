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
    public partial class FrmMain : Form
    {
        public static DialogResult result;
        public FrmMain()
        {
            InitializeComponent();
        }
        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiChildren)
            {
                if (childFrm.Name == childfrmname)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }
        //用户登录菜单的事件处理
        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //检测该窗口是否处于打开状态
            if (this.checkchildfrm("frmLogin") == true)
                return;    //窗口已经打开，返回
            frmLogin user = new frmLogin();//实例化登录窗体
            user.ShowDialog();  //登录窗体以模式对话框的方式的打开
            //判断是否登录成功，登录成功则启用相应的菜单和按钮
            if (result == DialogResult.OK)
            {
                this.tsbtnAddBook.Enabled = true;
                this.mnuUpdateBook.Enabled = true;
                this.mnuAddBook.Enabled = true;
            
            }
        }
        //登录按钮事件处理
        private void tsbtnLogin_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmLogin") == true)
                return;
            
            frmLogin user = new frmLogin();
           
            user.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tsbtnAddBook.Enabled = true;
                this.mnuUpdateBook.Enabled = true;
                this.mnuAddBook.Enabled = true;
           
            }
        }
        //图书查询按钮Click事件处理
        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmSearchBook") == true)
                return;
            
            frmSearchBook book = new frmSearchBook();
            book.MdiParent = this;  //设置为当前窗体的子窗体
            book.Show();
            
        }
        //图书检索菜单Click事件处理
        private void 图书检索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmSearchBook") == true)
                return;
            frmSearchBook book = new frmSearchBook();
            book.MdiParent = this;
            book.Show();
        }
        //图书入库菜单Click事件处理
        private void 图书入库ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmAddBook") == true)
                return;
            frmAddBook objbook = new frmAddBook();
            objbook.MdiParent= this;
            objbook.Show();
        }
        //图书入库按钮Click事件处理
        private void tsbtnAddBook_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmUpdateBook") == true)
                return;
            frmUpdateBook objbook = new frmUpdateBook();
            objbook.MdiParent = this;
            objbook.Show();
        }
        //图书更新菜单Click事件处理
        private void 图书修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmUpdateBook") == true)
                return;
            
            frmUpdateBook objbook = new frmUpdateBook();
            objbook.MdiParent= this;
            objbook.Show();
        }
        //图书借阅按钮事件处理
        private void tsbtnIssue_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("frmIssueBook") == true)
                return;
            frmIssueBook issuebook = new frmIssueBook();
            issuebook.MdiParent= this;
            issuebook.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //窗体载入时事件处理
        private void FrmMain_Load(object sender, EventArgs e)
        {
           
                this.tsbtnAddBook.Enabled = false;
                this.mnuAddBook.Enabled = false;
                this.mnuUpdateBook.Enabled = false;

        }
    }
}
