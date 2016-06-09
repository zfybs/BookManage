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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //验证通过
            if (Validate())
            {
                string state = this.cboUserType.Text;
                int num;
                if (state.Equals("管理员"))//判断用户角色
                    num = 1;
                else
                    num = 2;
                //定义查询语句
                string sql = string.Format("select * from userinfo where uname='{0}'and upwd='{1}' and ustate={2}", this.txName.Text.Trim(),this.txtPwd.Text.Trim(),num);
                DataSet ds = DataAccess.GetDataSetBySql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("登录成功");
                    FrmMain.result = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("用户名或密码错误");

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.cboUserType.SelectedIndex = 0;
        }
        //验证方法
        private bool Vaildate()
        {
            if (this.txName.Text != string.Empty && this.txtPwd.Text != string.Empty)
                return true;
            else
                MessageBox.Show("用户名或密码不能为空");
            return false;
        
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
