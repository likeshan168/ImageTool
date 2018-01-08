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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btnImportExcel = new MetroFramework.Controls.MetroButton();
            this.btnSelectImg = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.progressMsg = new MetroFramework.Controls.MetroLabel();
            this.lblImgCounts = new MetroFramework.Controls.MetroLabel();
            this.msg = new System.Windows.Forms.LinkLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new Syncfusion.Windows.Forms.FolderBrowser(this.components);
            this.tabImageRename = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportPrintData = new Syncfusion.Windows.Forms.ButtonAdv();
            this.batchPrint = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.msg2 = new System.Windows.Forms.LinkLabel();
            this.progressMsg2 = new MetroFramework.Controls.MetroLabel();
            this.grp1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.tabImageRename.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Excel files|*.xlsx|All files|*.*";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.btnImportExcel);
            this.grp1.Controls.Add(this.btnSelectImg);
            this.grp1.Controls.Add(this.metroButton1);
            this.grp1.Location = new System.Drawing.Point(3, 6);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(743, 59);
            this.grp1.TabIndex = 4;
            this.grp1.TabStop = false;
            this.grp1.Text = "操作区";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(21, 20);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnImportExcel.TabIndex = 5;
            this.btnImportExcel.Text = "导入Excel";
            this.btnImportExcel.UseSelectable = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(188, 20);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImg.TabIndex = 4;
            this.btnSelectImg.Text = "选择图片";
            this.btnSelectImg.UseSelectable = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(336, 20);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "批量导出图片";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnOutputImgs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Controls.Add(this.progressMsg);
            this.groupBox2.Controls.Add(this.lblImgCounts);
            this.groupBox2.Controls.Add(this.msg);
            this.groupBox2.Controls.Add(this.picBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 338);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "展示区";
            // 
            // dataGridView
            // 
            this.dataGridView.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.dataGridView.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Black;
            this.dataGridView.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.dataGridView.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.dataGridView.Location = new System.Drawing.Point(21, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.dataGridView.Size = new System.Drawing.Size(421, 273);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.TableDescriptor.AllowNew = false;
            this.dataGridView.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.dataGridView.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.dataGridView.TableDescriptor.TableOptions.RecordRowHeight = 25;
            this.dataGridView.TableOptions.ColumnsMaxLengthStrategy = Syncfusion.Windows.Forms.Grid.Grouping.GridColumnsMaxLengthStrategy.FirstNRecords;
            this.dataGridView.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.dataGridView.Text = "gridGroupingControl1";
            this.dataGridView.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.dataGridView.TopLevelGroupOptions.ShowCaption = false;
            this.dataGridView.UseRightToLeftCompatibleTextBox = true;
            this.dataGridView.VersionInfo = "15.4460.0.17";
            // 
            // progressMsg
            // 
            this.progressMsg.AutoSize = true;
            this.progressMsg.Location = new System.Drawing.Point(24, 24);
            this.progressMsg.Name = "progressMsg";
            this.progressMsg.Size = new System.Drawing.Size(72, 19);
            this.progressMsg.TabIndex = 9;
            this.progressMsg.Text = "总条数：0";
            // 
            // lblImgCounts
            // 
            this.lblImgCounts.AutoSize = true;
            this.lblImgCounts.Location = new System.Drawing.Point(206, 24);
            this.lblImgCounts.Name = "lblImgCounts";
            this.lblImgCounts.Size = new System.Drawing.Size(100, 19);
            this.lblImgCounts.TabIndex = 8;
            this.lblImgCounts.Text = "导出图片数：0";
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.msg.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msg.Location = new System.Drawing.Point(364, 31);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(78, 12);
            this.msg.TabIndex = 5;
            this.msg.TabStop = true;
            this.msg.Text = "正在导入...";
            this.msg.Visible = false;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(448, 56);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(289, 273);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // openImgDialog
            // 
            this.openImgDialog.RestoreDirectory = true;
            // 
            // tabImageRename
            // 
            this.tabImageRename.Controls.Add(this.tabPage1);
            this.tabImageRename.Controls.Add(this.tabPage2);
            this.tabImageRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabImageRename.Location = new System.Drawing.Point(0, 0);
            this.tabImageRename.Name = "tabImageRename";
            this.tabImageRename.SelectedIndex = 0;
            this.tabImageRename.Size = new System.Drawing.Size(767, 445);
            this.tabImageRename.TabIndex = 6;
            this.tabImageRename.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grp1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图片批量命名";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图片批量打印";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.batchPrint);
            this.groupBox1.Controls.Add(this.btnImportPrintData);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // btnImportPrintData
            // 
            this.btnImportPrintData.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnImportPrintData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImportPrintData.BeforeTouchSize = new System.Drawing.Size(126, 36);
            this.btnImportPrintData.ForeColor = System.Drawing.Color.White;
            this.btnImportPrintData.IsBackStageButton = false;
            this.btnImportPrintData.Location = new System.Drawing.Point(48, 20);
            this.btnImportPrintData.Name = "btnImportPrintData";
            this.btnImportPrintData.Size = new System.Drawing.Size(126, 36);
            this.btnImportPrintData.TabIndex = 0;
            this.btnImportPrintData.Text = "导入数据列";
            this.btnImportPrintData.UseVisualStyle = false;
            this.btnImportPrintData.Click += new System.EventHandler(this.btnImportPrintData_Click);
            // 
            // batchPrint
            // 
            this.batchPrint.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.batchPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.batchPrint.BeforeTouchSize = new System.Drawing.Size(119, 36);
            this.batchPrint.ForeColor = System.Drawing.Color.White;
            this.batchPrint.IsBackStageButton = false;
            this.batchPrint.Location = new System.Drawing.Point(272, 20);
            this.batchPrint.Name = "batchPrint";
            this.batchPrint.Size = new System.Drawing.Size(119, 36);
            this.batchPrint.TabIndex = 1;
            this.batchPrint.Text = "批量打印图片";
            this.batchPrint.Click += new System.EventHandler(this.batchPrint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.msg2);
            this.groupBox3.Controls.Add(this.progressMsg2);
            this.groupBox3.Controls.Add(this.dgv2);
            this.groupBox3.Location = new System.Drawing.Point(8, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 318);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据展示区";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(6, 63);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 23;
            this.dgv2.Size = new System.Drawing.Size(353, 249);
            this.dgv2.TabIndex = 0;
            // 
            // msg2
            // 
            this.msg2.AutoSize = true;
            this.msg2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.msg2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msg2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msg2.Location = new System.Drawing.Point(270, 34);
            this.msg2.Name = "msg2";
            this.msg2.Size = new System.Drawing.Size(78, 12);
            this.msg2.TabIndex = 6;
            this.msg2.TabStop = true;
            this.msg2.Text = "正在导入...";
            this.msg2.Visible = false;
            // 
            // progressMsg2
            // 
            this.progressMsg2.AutoSize = true;
            this.progressMsg2.Location = new System.Drawing.Point(6, 27);
            this.progressMsg2.Name = "progressMsg2";
            this.progressMsg2.Size = new System.Drawing.Size(72, 19);
            this.progressMsg2.TabIndex = 10;
            this.progressMsg2.Text = "总条数：0";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 445);
            this.Controls.Add(this.tabImageRename);
            this.Name = "MainFrm";
            this.Text = "图片工具";
            this.grp1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.tabImageRename.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.LinkLabel msg;
        private System.Windows.Forms.OpenFileDialog openImgDialog;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSelectImg;
        private MetroFramework.Controls.MetroButton btnImportExcel;
        private MetroFramework.Controls.MetroLabel lblImgCounts;
        private MetroFramework.Controls.MetroLabel progressMsg;
        private Syncfusion.Windows.Forms.FolderBrowser folderBrowserDialog;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl dataGridView;
        private System.Windows.Forms.TabControl tabImageRename;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.ButtonAdv btnImportPrintData;
        private Syncfusion.Windows.Forms.ButtonAdv batchPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.LinkLabel msg2;
        private MetroFramework.Controls.MetroLabel progressMsg2;
    }
}

