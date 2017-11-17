namespace ImageTool
{
    partial class MainFrm
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
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOutputImgs = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblImgCounts = new System.Windows.Forms.Label();
            this.progressMsg = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.LinkLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(16, 20);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "导入Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(155, 20);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImg.TabIndex = 1;
            this.btnSelectImg.Text = "选择图片";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Excel files|*.xlsx|All files|*.*";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // btnOutputImgs
            // 
            this.btnOutputImgs.Location = new System.Drawing.Point(323, 20);
            this.btnOutputImgs.Name = "btnOutputImgs";
            this.btnOutputImgs.Size = new System.Drawing.Size(75, 23);
            this.btnOutputImgs.TabIndex = 2;
            this.btnOutputImgs.Text = "批量导出图片";
            this.btnOutputImgs.UseVisualStyleBackColor = true;
            this.btnOutputImgs.Click += new System.EventHandler(this.btnOutputImgs_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(426, 282);
            this.dataGridView.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportExcel);
            this.groupBox1.Controls.Add(this.btnSelectImg);
            this.groupBox1.Controls.Add(this.btnOutputImgs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImgCounts);
            this.groupBox2.Controls.Add(this.progressMsg);
            this.groupBox2.Controls.Add(this.msg);
            this.groupBox2.Controls.Add(this.picBox);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 335);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "展示区";
            // 
            // lblImgCounts
            // 
            this.lblImgCounts.AutoSize = true;
            this.lblImgCounts.Location = new System.Drawing.Point(139, 24);
            this.lblImgCounts.Name = "lblImgCounts";
            this.lblImgCounts.Size = new System.Drawing.Size(83, 12);
            this.lblImgCounts.TabIndex = 7;
            this.lblImgCounts.Text = "导出图片数：0";
            // 
            // progressMsg
            // 
            this.progressMsg.AutoSize = true;
            this.progressMsg.Location = new System.Drawing.Point(19, 24);
            this.progressMsg.Name = "progressMsg";
            this.progressMsg.Size = new System.Drawing.Size(59, 12);
            this.progressMsg.TabIndex = 6;
            this.progressMsg.Text = "总条数：0";
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.msg.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msg.Location = new System.Drawing.Point(153, 151);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(78, 12);
            this.msg.TabIndex = 5;
            this.msg.TabStop = true;
            this.msg.Text = "正在导入...";
            this.msg.Visible = false;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(448, 47);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(168, 282);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // openImgDialog
            // 
            this.openImgDialog.RestoreDirectory = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrm";
            this.Text = "图片批量命名";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOutputImgs;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.LinkLabel msg;
        private System.Windows.Forms.OpenFileDialog openImgDialog;
        private System.Windows.Forms.Label progressMsg;
        private System.Windows.Forms.Label lblImgCounts;
    }
}

