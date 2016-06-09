namespace BookManage
{
    partial class frmAddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label lblBookAccessCode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.GroupBox grpInsertDetails;
        private System.Windows.Forms.Button btnInsertBkDt;
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.lblBookAccessCode = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.btnInsertBkDt = new System.Windows.Forms.Button();
            this.grpInsertDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBookDetails.SuspendLayout();
            this.grpInsertDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.Location = new System.Drawing.Point(16, 54);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(86, 26);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "书名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(128, 96);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(120, 21);
            this.txtAuthor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "作者：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 21);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(16, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 26);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "价格：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(128, 201);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(120, 21);
            this.txtContent.TabIndex = 7;
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(128, 236);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(120, 21);
            this.txtIssue.TabIndex = 9;
            // 
            // lblBookAccessCode
            // 
            this.lblBookAccessCode.Location = new System.Drawing.Point(7, 236);
            this.lblBookAccessCode.Name = "lblBookAccessCode";
            this.lblBookAccessCode.Size = new System.Drawing.Size(115, 35);
            this.lblBookAccessCode.TabIndex = 8;
            this.lblBookAccessCode.Text = "指定访问码：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(632, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "退出(&E)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.Controls.Add(this.dataGridView1);
            this.grpBookDetails.Location = new System.Drawing.Point(296, 26);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Size = new System.Drawing.Size(424, 276);
            this.grpBookDetails.TabIndex = 11;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "图书详细信息";
            // 
            // btnInsertBkDt
            // 
            this.btnInsertBkDt.Location = new System.Drawing.Point(520, 310);
            this.btnInsertBkDt.Name = "btnInsertBkDt";
            this.btnInsertBkDt.Size = new System.Drawing.Size(90, 25);
            this.btnInsertBkDt.TabIndex = 10;
            this.btnInsertBkDt.Text = "插入(&I)";
            this.btnInsertBkDt.Click += new System.EventHandler(this.btnInsertBkDt_Click);
            // 
            // grpInsertDetails
            // 
            this.grpInsertDetails.Controls.Add(this.label4);
            this.grpInsertDetails.Controls.Add(this.txtPic);
            this.grpInsertDetails.Controls.Add(this.label3);
            this.grpInsertDetails.Controls.Add(this.txtType);
            this.grpInsertDetails.Controls.Add(this.label2);
            this.grpInsertDetails.Controls.Add(this.txtName);
            this.grpInsertDetails.Controls.Add(this.lblBookAccessCode);
            this.grpInsertDetails.Controls.Add(this.label1);
            this.grpInsertDetails.Controls.Add(this.lblBookName);
            this.grpInsertDetails.Controls.Add(this.lblPrice);
            this.grpInsertDetails.Controls.Add(this.txtPrice);
            this.grpInsertDetails.Controls.Add(this.txtAuthor);
            this.grpInsertDetails.Controls.Add(this.txtContent);
            this.grpInsertDetails.Controls.Add(this.txtIssue);
            this.grpInsertDetails.Location = new System.Drawing.Point(16, 26);
            this.grpInsertDetails.Name = "grpInsertDetails";
            this.grpInsertDetails.Size = new System.Drawing.Size(264, 276);
            this.grpInsertDetails.TabIndex = 0;
            this.grpInsertDetails.TabStop = false;
            this.grpInsertDetails.Text = "插入详细信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(418, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "类别：";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(128, 26);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(120, 21);
            this.txtType.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "封面：";
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(128, 166);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(120, 21);
            this.txtPic.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "内容简介：";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookID";
            this.Column1.HeaderText = "BookId";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookType";
            this.Column2.HeaderText = "类别";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BookName";
            this.Column3.HeaderText = "书名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BookAuthor";
            this.Column4.HeaderText = "作者";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BookPrice";
            this.Column5.HeaderText = "价格";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BookPic";
            this.Column6.HeaderText = "封面";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "BookContent";
            this.Column7.HeaderText = "内容简介";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "BookIssue";
            this.Column8.HeaderText = "访问码";
            this.Column8.Name = "Column8";
            // 
            // frmAddBook
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(736, 350);
            this.Controls.Add(this.grpBookDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpInsertDetails);
            this.Controls.Add(this.btnInsertBkDt);
            this.Name = "frmAddBook";
            this.ShowInTaskbar = false;
            this.Text = "图书入库";
            this.grpBookDetails.ResumeLayout(false);
            this.grpInsertDetails.ResumeLayout(false);
            this.grpInsertDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
       
    }
}