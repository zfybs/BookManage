namespace BookManage
{
    partial class frmBookPic
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
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBook
            // 
            this.pbBook.Location = new System.Drawing.Point(32, 85);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(328, 192);
            this.pbBook.TabIndex = 11;
            this.pbBook.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(192, 293);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "取消";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Location = new System.Drawing.Point(80, 293);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 9;
            this.btnUpdatePic.Text = "更新封面";
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click_1);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(32, 53);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 8;
            this.btnPic.Text = "修改封面";
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(136, 21);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(224, 21);
            this.txtPic.TabIndex = 7;
            // 
            // lblPic
            // 
            this.lblPic.Location = new System.Drawing.Point(32, 21);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(100, 23);
            this.lblPic.TabIndex = 6;
            this.lblPic.Text = "图书封面路径";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // frmBookPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 342);
            this.Controls.Add(this.pbBook);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnUpdatePic);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.lblPic);
            this.Name = "frmBookPic";
            this.Text = "图书封面查看";
            this.Load += new System.EventHandler(this.frmBookPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.OpenFileDialog ofdFile;

    }
}