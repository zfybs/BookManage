namespace BookManage
{
    partial class frmUpdateBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.grbUpdate = new System.Windows.Forms.GroupBox();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbContent = new System.Windows.Forms.TextBox();
            this.txtbPic = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbType = new System.Windows.Forms.TextBox();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.lblbContent = new System.Windows.Forms.Label();
            this.lblbPic = new System.Windows.Forms.Label();
            this.lblbPrice = new System.Windows.Forms.Label();
            this.lblbName = new System.Windows.Forms.Label();
            this.lblbType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblbID = new System.Windows.Forms.Label();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbUpdate.SuspendLayout();
            this.grpBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUpdate
            // 
            this.grbUpdate.Controls.Add(this.txtIssueID);
            this.grbUpdate.Controls.Add(this.label2);
            this.grbUpdate.Controls.Add(this.txtAuthor);
            this.grbUpdate.Controls.Add(this.label1);
            this.grbUpdate.Controls.Add(this.txtbContent);
            this.grbUpdate.Controls.Add(this.txtbPic);
            this.grbUpdate.Controls.Add(this.txtbPrice);
            this.grbUpdate.Controls.Add(this.txtbName);
            this.grbUpdate.Controls.Add(this.txtbType);
            this.grbUpdate.Controls.Add(this.txtbID);
            this.grbUpdate.Controls.Add(this.lblbContent);
            this.grbUpdate.Controls.Add(this.lblbPic);
            this.grbUpdate.Controls.Add(this.lblbPrice);
            this.grbUpdate.Controls.Add(this.lblbName);
            this.grbUpdate.Controls.Add(this.lblbType);
            this.grbUpdate.Controls.Add(this.btnClose);
            this.grbUpdate.Controls.Add(this.btnDel);
            this.grbUpdate.Controls.Add(this.btnUpdatePic);
            this.grbUpdate.Controls.Add(this.btnUpdate);
            this.grbUpdate.Controls.Add(this.lblbID);
            this.grbUpdate.Location = new System.Drawing.Point(436, 22);
            this.grbUpdate.Name = "grbUpdate";
            this.grbUpdate.Size = new System.Drawing.Size(344, 279);
            this.grbUpdate.TabIndex = 1;
            this.grbUpdate.TabStop = false;
            this.grbUpdate.Text = "更新图书信息";
            // 
            // txtIssueID
            // 
            this.txtIssueID.Location = new System.Drawing.Point(244, 186);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(84, 21);
            this.txtIssueID.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "访问码：";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(80, 184);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(89, 21);
            this.txtAuthor.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "图书作者：";
            // 
            // txtbContent
            // 
            this.txtbContent.Location = new System.Drawing.Point(244, 136);
            this.txtbContent.Name = "txtbContent";
            this.txtbContent.Size = new System.Drawing.Size(84, 21);
            this.txtbContent.TabIndex = 31;
            // 
            // txtbPic
            // 
            this.txtbPic.Location = new System.Drawing.Point(244, 87);
            this.txtbPic.Name = "txtbPic";
            this.txtbPic.Size = new System.Drawing.Size(84, 21);
            this.txtbPic.TabIndex = 29;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(244, 40);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(84, 21);
            this.txtbPrice.TabIndex = 27;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(80, 136);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(89, 21);
            this.txtbName.TabIndex = 25;
            // 
            // txtbType
            // 
            this.txtbType.Location = new System.Drawing.Point(80, 87);
            this.txtbType.Name = "txtbType";
            this.txtbType.Size = new System.Drawing.Size(89, 21);
            this.txtbType.TabIndex = 23;
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(80, 40);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(89, 21);
            this.txtbID.TabIndex = 17;
            // 
            // lblbContent
            // 
            this.lblbContent.Location = new System.Drawing.Point(175, 136);
            this.lblbContent.Name = "lblbContent";
            this.lblbContent.Size = new System.Drawing.Size(100, 23);
            this.lblbContent.TabIndex = 30;
            this.lblbContent.Text = "图书内容：";
            // 
            // lblbPic
            // 
            this.lblbPic.Location = new System.Drawing.Point(175, 87);
            this.lblbPic.Name = "lblbPic";
            this.lblbPic.Size = new System.Drawing.Size(100, 23);
            this.lblbPic.TabIndex = 28;
            this.lblbPic.Text = "图书封面：";
            // 
            // lblbPrice
            // 
            this.lblbPrice.Location = new System.Drawing.Point(175, 40);
            this.lblbPrice.Name = "lblbPrice";
            this.lblbPrice.Size = new System.Drawing.Size(100, 23);
            this.lblbPrice.TabIndex = 26;
            this.lblbPrice.Text = "图书价格：";
            // 
            // lblbName
            // 
            this.lblbName.Location = new System.Drawing.Point(12, 136);
            this.lblbName.Name = "lblbName";
            this.lblbName.Size = new System.Drawing.Size(100, 23);
            this.lblbName.TabIndex = 24;
            this.lblbName.Text = "图书名字：";
            // 
            // lblbType
            // 
            this.lblbType.Location = new System.Drawing.Point(12, 87);
            this.lblbType.Name = "lblbType";
            this.lblbType.Size = new System.Drawing.Size(100, 23);
            this.lblbType.TabIndex = 22;
            this.lblbType.Text = "图书类型：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(261, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(176, 234);
            this.btnDel.Name = "btnDel";
            this.btnDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 20;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Location = new System.Drawing.Point(6, 234);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 19;
            this.btnUpdatePic.Text = "更新封面";
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblbID
            // 
            this.lblbID.Location = new System.Drawing.Point(12, 40);
            this.lblbID.Name = "lblbID";
            this.lblbID.Size = new System.Drawing.Size(100, 23);
            this.lblbID.TabIndex = 16;
            this.lblbID.Text = "图书编号：";
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.Controls.Add(this.dgvBookInfo);
            this.grpBookDetails.Location = new System.Drawing.Point(6, 25);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Size = new System.Drawing.Size(424, 276);
            this.grpBookDetails.TabIndex = 12;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "图书详细信息";
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToOrderColumns = true;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.RowTemplate.Height = 23;
            this.dgvBookInfo.Size = new System.Drawing.Size(418, 256);
            this.dgvBookInfo.TabIndex = 0;
            this.dgvBookInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookInfo_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(262, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 373);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBookDetails);
            this.Controls.Add(this.grbUpdate);
            this.Name = "frmUpdateBook";
            this.Text = "frmUpdateBook";
            this.Load += new System.EventHandler(this.frmUpdateBook_Load);
            this.grbUpdate.ResumeLayout(false);
            this.grbUpdate.PerformLayout();
            this.grpBookDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUpdate;
        private System.Windows.Forms.TextBox txtbContent;
        private System.Windows.Forms.TextBox txtbPic;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbType;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.Label lblbContent;
        private System.Windows.Forms.Label lblbPic;
        private System.Windows.Forms.Label lblbPrice;
        private System.Windows.Forms.Label lblbName;
        private System.Windows.Forms.Label lblbType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblbID;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.Button btnSave;
    }
}