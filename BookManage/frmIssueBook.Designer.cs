namespace BookManage
{
    partial class frmIssueBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblBookAccessCode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpIssueDetails;
        private System.Windows.Forms.GroupBox grpIssueBooks;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.TextBox txtIssID;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.TextBox txtIssName;
        private System.Windows.Forms.ComboBox cboBookName;
        private System.Windows.Forms.TextBox txtBookAccessCode;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnIssueBook;
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookAccessCode = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpIssueDetails = new System.Windows.Forms.GroupBox();
            this.dgvIssInfo = new System.Windows.Forms.DataGridView();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.grpIssueBooks = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBookAccessCode = new System.Windows.Forms.TextBox();
            this.cboBookName = new System.Windows.Forms.ComboBox();
            this.txtIssName = new System.Windows.Forms.TextBox();
            this.txtIssID = new System.Windows.Forms.TextBox();
            this.lblStdID = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpIssueDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssInfo)).BeginInit();
            this.grpIssueBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.Location = new System.Drawing.Point(19, 172);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(87, 26);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "书名：";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(112, 250);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(135, 21);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(30, 250);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(58, 26);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "作者：";
            // 
            // lblBookAccessCode
            // 
            this.lblBookAccessCode.Location = new System.Drawing.Point(19, 121);
            this.lblBookAccessCode.Name = "lblBookAccessCode";
            this.lblBookAccessCode.Size = new System.Drawing.Size(115, 34);
            this.lblBookAccessCode.TabIndex = 8;
            this.lblBookAccessCode.Text = "图书访问码：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(696, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出(&E)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpIssueDetails
            // 
            this.grpIssueDetails.Controls.Add(this.dgvIssInfo);
            this.grpIssueDetails.Location = new System.Drawing.Point(296, 26);
            this.grpIssueDetails.Name = "grpIssueDetails";
            this.grpIssueDetails.Size = new System.Drawing.Size(488, 319);
            this.grpIssueDetails.TabIndex = 1;
            this.grpIssueDetails.TabStop = false;
            this.grpIssueDetails.Text = "借阅详细信息：";
            // 
            // dgvIssInfo
            // 
            this.dgvIssInfo.AllowUserToOrderColumns = true;
            this.dgvIssInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dgvIssInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvIssInfo.Name = "dgvIssInfo";
            this.dgvIssInfo.RowTemplate.Height = 23;
            this.dgvIssInfo.Size = new System.Drawing.Size(482, 299);
            this.dgvIssInfo.TabIndex = 0;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(584, 355);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(90, 25);
            this.btnIssueBook.TabIndex = 1;
            this.btnIssueBook.Text = "借阅(&I)";
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // grpIssueBooks
            // 
            this.grpIssueBooks.Controls.Add(this.dateTimePicker1);
            this.grpIssueBooks.Controls.Add(this.txtBookAccessCode);
            this.grpIssueBooks.Controls.Add(this.cboBookName);
            this.grpIssueBooks.Controls.Add(this.txtIssName);
            this.grpIssueBooks.Controls.Add(this.txtIssID);
            this.grpIssueBooks.Controls.Add(this.lblStdID);
            this.grpIssueBooks.Controls.Add(this.lblStdName);
            this.grpIssueBooks.Controls.Add(this.lblBookAccessCode);
            this.grpIssueBooks.Controls.Add(this.lblBookName);
            this.grpIssueBooks.Controls.Add(this.lblIssueDate);
            this.grpIssueBooks.Location = new System.Drawing.Point(10, 26);
            this.grpIssueBooks.Name = "grpIssueBooks";
            this.grpIssueBooks.Size = new System.Drawing.Size(262, 319);
            this.grpIssueBooks.TabIndex = 0;
            this.grpIssueBooks.TabStop = false;
            this.grpIssueBooks.Text = "借阅详细信息：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 21);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // txtBookAccessCode
            // 
            this.txtBookAccessCode.Location = new System.Drawing.Point(104, 121);
            this.txtBookAccessCode.Name = "txtBookAccessCode";
            this.txtBookAccessCode.Size = new System.Drawing.Size(134, 21);
            this.txtBookAccessCode.TabIndex = 3;
            // 
            // cboBookName
            // 
            this.cboBookName.Location = new System.Drawing.Point(104, 172);
            this.cboBookName.Name = "cboBookName";
            this.cboBookName.Size = new System.Drawing.Size(134, 20);
            this.cboBookName.TabIndex = 4;
            this.cboBookName.SelectedIndexChanged += new System.EventHandler(this.cboBookName_SelectedIndexChanged);
            // 
            // txtIssName
            // 
            this.txtIssName.Location = new System.Drawing.Point(104, 69);
            this.txtIssName.Name = "txtIssName";
            this.txtIssName.Size = new System.Drawing.Size(134, 21);
            this.txtIssName.TabIndex = 2;
            // 
            // txtIssID
            // 
            this.txtIssID.Location = new System.Drawing.Point(104, 26);
            this.txtIssID.Name = "txtIssID";
            this.txtIssID.Size = new System.Drawing.Size(134, 21);
            this.txtIssID.TabIndex = 1;
            // 
            // lblStdID
            // 
            this.lblStdID.Location = new System.Drawing.Point(19, 69);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(103, 17);
            this.lblStdID.TabIndex = 12;
            this.lblStdID.Text = "姓名：";
            // 
            // lblStdName
            // 
            this.lblStdName.Location = new System.Drawing.Point(19, 26);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(103, 17);
            this.lblStdName.TabIndex = 10;
            this.lblStdName.Text = "借阅证号：";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Location = new System.Drawing.Point(19, 272);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(103, 18);
            this.lblIssueDate.TabIndex = 10;
            this.lblIssueDate.Text = "借阅日期：";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IssUBookID";
            this.Column1.HeaderText = "借阅证号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookName";
            this.Column2.HeaderText = "借阅图书";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BookID";
            this.Column5.HeaderText = "图书编号";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IssDateTime";
            this.Column3.HeaderText = "借阅时间";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IssID";
            this.Column4.HeaderText = "借阅编码";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // frmIssueBook
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(808, 384);
            this.Controls.Add(this.grpIssueDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.grpIssueBooks);
            this.Controls.Add(this.btnIssueBook);
            this.Name = "frmIssueBook";
            this.ShowInTaskbar = false;
            this.Text = "借阅图书";
            this.Load += new System.EventHandler(this.frmIssueBook_Load);
            this.grpIssueDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssInfo)).EndInit();
            this.grpIssueBooks.ResumeLayout(false);
            this.grpIssueBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView dgvIssInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}