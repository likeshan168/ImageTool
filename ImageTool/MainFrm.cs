using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Utility;

namespace ImageTool
{
    public partial class MainFrm : Form
    {
        private DataTable dataTable = new DataTable();
        private string img = string.Empty;
        private string folder = string.Empty;
        SynchronizationContext syncContext = null;
        public MainFrm()
        {
            InitializeComponent();
            syncContext = SynchronizationContext.Current;
        }
        private void Init()
        {
            openImgDialog.Filter = @"All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff|
                Windows Bitmap(*.bmp)|*.bmp|
                Windows Icon(*.ico)|*.ico|
                Graphics Interchange Format (*.gif)|(*.gif)|
                JPEG File Interchange Format (*.jpg)|*.jpg;*.jpeg|
                Portable Network Graphics (*.png)|*.png|
                Tag Image File Format (*.tif)|*.tif;*.tiff";
        }


        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == openImgDialog.ShowDialog())
                {
                    if (openImgDialog.CheckFileExists)
                    {
                        img = openImgDialog.FileName;
                        picBox.Image = Image.FromFile(openImgDialog.FileName, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"选择图片异常：{ex.Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        msg.Visible = true;
                        msg.Text = "正在导入...";
                        new Thread(new ThreadStart(ThreadImportExcel)).Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"导入Excel异常：{ex.Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOutputImgs_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show($"请选择Excel文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrWhiteSpace(img))
                {
                    MessageBox.Show($"请选择图片文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (DialogResult.OK == folderBrowserDialog.ShowDialog())
                {
                    if (!string.IsNullOrWhiteSpace(folder = folderBrowserDialog.SelectedPath))
                    {
                        msg.Text = "正在导出图片...";
                        msg.Visible = true;
                        progressMsg.Text = $"导出进度：0/{dataTable.Rows.Count}";
                        progressMsg.Visible = true;
                        new Thread(new ThreadStart(ThreadExportImgs)).Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"导出图片异常：{ex.Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ThreadImportExcel()
        {
            syncContext.Post(ImportExcel, null);
        }
        private void ThreadExportImgs()
        {
            syncContext.Post(OutputImgs, null);
        }
        private void ImportExcel(object message)
        {
            var excelHelper = new ExcelHelper(openFileDialog.FileName);
            dataTable = excelHelper.ExcelToDataTable(string.Empty, true);
            dataGridView.DataSource = dataTable;
            msg.Visible = false;
            progressMsg.Text = $"总条数：{dataTable.Rows.Count}";
        }
        private void OutputImgs(object obj)
        {
            string name = string.Empty;
            int count = dataTable.Rows.Count;
            foreach (DataRow row in dataTable.Rows)
            {
                name = row.Field<string>(0);
                File.Copy(img, Path.Combine(folder, name + Path.GetExtension(img)), true);
            }
            msg.Visible = false;
            lblImgCounts.Text = $"导出图片数：{count}";
            MessageBox.Show($"导出导出：{count}张图片", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
