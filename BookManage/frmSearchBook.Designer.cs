namespace BookManage
{
    partial class frmSearchBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.ComboBox cboAnd;
        private System.Windows.Forms.ComboBox cboOR;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboAnd = new System.Windows.Forms.ComboBox();
            this.cboOR = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.grpIssueDetails = new System.Windows.Forms.GroupBox();
            this.dgvSearchBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpIssueDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cboAnd);
            this.groupBox1.Controls.Add(this.cboOR);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Location = new System.Drawing.Point(32, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(135, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(135, 243);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(75, 23);
            this.btnSerch.TabIndex = 8;
            this.btnSerch.Text = "搜索";
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(90, 199);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(120, 21);
            this.txtContent.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 21);
            this.txtName.TabIndex = 6;
            // 
            // cboAnd
            // 
            this.cboAnd.Items.AddRange(new object[] {
            "or",
            "and"});
            this.cboAnd.Location = new System.Drawing.Point(90, 157);
            this.cboAnd.Name = "cboAnd";
            this.cboAnd.Size = new System.Drawing.Size(121, 20);
            this.cboAnd.TabIndex = 5;
            // 
            // cboOR
            // 
            this.cboOR.Items.AddRange(new object[] {
            "or",
            "and"});
            this.cboOR.Location = new System.Drawing.Point(90, 72);
            this.cboOR.Name = "cboOR";
            this.cboOR.Size = new System.Drawing.Size(121, 20);
            this.cboOR.TabIndex = 4;
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(90, 30);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 20);
            this.cboType.TabIndex = 3;
            // 
            // lblContent
            // 
            this.lblContent.Location = new System.Drawing.Point(6, 202);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(100, 23);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "主要内容：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "图书名称：";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(6, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "图书类别：";
            // 
            // grpIssueDetails
            // 
            this.grpIssueDetails.Controls.Add(this.dgvSearchBook);
            this.grpIssueDetails.Location = new System.Drawing.Point(296, 20);
            this.grpIssueDetails.Name = "grpIssueDetails";
            this.grpIssueDetails.Size = new System.Drawing.Size(488, 319);
            this.grpIssueDetails.TabIndex = 3;
            this.grpIssueDetails.TabStop = false;
            this.grpIssueDetails.Text = "搜索结果：";
            //this.grpIssueDetails.Enter += new System.EventHandler(this.grpIssueDetails_Enter);
            // 
            // dgvSearchBook
            // 
            this.dgvSearchBook.AllowUserToOrderColumns = true;
            this.dgvSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.bookname,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dgvSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchBook.Location = new System.Drawing.Point(3, 17);
            this.dgvSearchBook.Name = "dgvSearchBook";
            this.dgvSearchBook.RowTemplate.Height = 23;
            this.dgvSearchBook.Size = new System.Drawing.Size(482, 299);
            this.dgvSearchBook.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookID";
            this.Column1.HeaderText = "BookID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookType";
            this.Column2.HeaderText = "图书类别";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // bookname
            // 
            this.bookname.DataPropertyName = "BookName";
            this.bookname.HeaderText = "书名";
            this.bookname.Name = "bookname";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BookAuthor";
            this.Column3.HeaderText = "作者";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BookPrice";
            this.Column4.HeaderText = "价格";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "BookPic";
            this.Column7.HeaderText = "封面";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BookContent";
            this.Column5.HeaderText = "内容简介";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BookIssue";
            this.Column6.HeaderText = "指定访问码";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // frmSearchBook
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 373);
            this.Controls.Add(this.grpIssueDetails);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearchBook";
            this.Text = "图书搜索";
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpIssueDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox grpIssueDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSearchBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}