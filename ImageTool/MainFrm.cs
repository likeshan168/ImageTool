using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ImageTool.Helper;
using MetroFramework;
using MetroFramework.Forms;
using Syncfusion.Windows.Forms;
using Utility;

namespace ImageTool
{
    public partial class MainFrm : Syncfusion.Windows.Forms.Office2010Form
    {
        private DataTable dataTable = new DataTable();
        private DataTable dataTable2 = new DataTable();
        private string img = string.Empty;
        private string folder = string.Empty;
        private string folder2 = string.Empty;
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
                MessageBoxAdv.Show(this, $"选择图片异常：{ex.Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBoxAdv.Show(this, $"导入Excel异常：{ex.Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOutputImgs_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTable.Rows.Count == 0)
                {
                    MessageBoxAdv.Show(this, $"请选择Excel文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrWhiteSpace(img))
                {
                    MessageBoxAdv.Show(this, $"请选择图片文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (DialogResult.OK == folderBrowserDialog.ShowDialog())
                {
                    if (!string.IsNullOrWhiteSpace(folder = folderBrowserDialog.DirectoryPath))
                    {
                        msg.Text = "正在导出图片...";
                        msg.Visible = true;
                        progressMsg.Text = $"导出进度：0/{dataTable.Rows.Count}";
                        progressMsg.Visible = true;
                        new Thread(ThreadExportImgs).Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, $"导出图片异常：{ex.Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ThreadImportExcel()
        {
            syncContext.Post(ImportExcel, null);
        }

        private void ThreadImportExcel2()
        {
            syncContext.Post(ImportExcel2, null);
        }
        private void ThreadExportImgs()
        {
            syncContext.Post(OutputImgs, null);
        }
        private void ImportExcel(object message)
        {
            var excelHelper = new ExcelHelper(openFileDialog.FileName);
            dataTable = excelHelper.ExcelToDataTable(string.Empty, true);

            dataGridView.DataSource = dataTable.AsDataView();
            msg.Visible = false;
            progressMsg.Text = $"总条数：{dataTable.Rows.Count}";
        }

        private void ImportExcel2(object message)
        {
            var excelHelper = new ExcelHelper(openFileDialog.FileName);
            dataTable2 = excelHelper.ExcelToDataTable(string.Empty, true);

            dgv2.DataSource = dataTable2.AsDataView();
            msg2.Visible = false;
            progressMsg2.Text = $"总条数：{dataTable2.Rows.Count}";
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
            MessageBoxAdv.Show(this, $"导出：{count}张图片", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImportPrintData_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        msg2.Visible = true;
                        msg2.Text = "正在导入...";
                        new Thread(ThreadImportExcel2).Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, $"导入Excel异常：{ex.Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void batchPrint_Click(object sender, EventArgs e)
        {
            if (dataTable2.Rows.Count == 0)
            {
                MessageBoxAdv.Show(this, $"请导入Excel文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                if (!string.IsNullOrWhiteSpace(folder2 = folderBrowserDialog.DirectoryPath))
                {
                    try
                    {
                        var imgs = Directory.GetFiles(folder2);
                        var fileNames = imgs.Select(Path.GetFileNameWithoutExtension).ToList();
                        PrintDocument pd;

                        msg2.Visible = true;
                        foreach (DataRow row in dataTable2.Rows)
                        {
                            var value = row.Field<string>(0);
                            if (string.IsNullOrWhiteSpace(value) || !fileNames.Contains(value))
                            {
                                continue;
                            }

                            imgFile = imgs.FirstOrDefault(p => Path.GetFileNameWithoutExtension(p) == value);
                            if (string.IsNullOrWhiteSpace(imgFile))
                                continue;
                            msg2.Text = $"正在打印:{value}";
                            //打印预览
                            //PrintPreviewDialog ppd = new PrintPreviewDialog();
                            pd = new PrintDocument();
                            //设置边距
                            Margins margin = new Margins(20, 20, 20, 20);
                            pd.DefaultPageSettings.Margins = margin;
                            ////纸张设置默认
                            //PaperSize pageSize = new PaperSize();
                            //pd.DefaultPageSettings.PaperSize = ;
                            //打印事件设置
                            pd.PrintPage += pd_PrintPage;
                            //ppd.Document = pd;
                            //ppd.ShowDialog();

                            pd.Print();
                            break;
                        }
                        msg2.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private string imgFile = string.Empty;
        private float width = (float)MillimetersToPixelsWidth(210);
        private float height = (float)MillimetersToPixelsWidth(297);

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            //读取图片模板
            var temp = Image.FromFile(imgFile);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            var newImg = ImageHelper.SizeImageWithOldPercent(temp, 400, 500);
            int w = newImg.Width;
            int h = newImg.Height;
            Rectangle destRect = new Rectangle(x, y, 500, 580);
            //A4纸尺寸：210×297；指定大小
            e.Graphics.DrawImage(newImg, destRect, 0, 0, 400, 500, GraphicsUnit.Pixel);
            //自适应大小
            //e.Graphics.DrawImage(ImageHelper.SizeImageWithOldPercent(temp, 140, 180), e.MarginBounds);
        }

        private static double MillimetersToPixelsWidth(double length) //length是毫米，1厘米=10毫米
        {
            Panel p = new Panel();
            Graphics g = Graphics.FromHwnd(p.Handle);
            IntPtr hdc = g.GetHdc();
            int width = GetDeviceCaps(hdc, 4);     // HORZRES 
            int pixels = GetDeviceCaps(hdc, 8);     // BITSPIXEL
            g.ReleaseHdc(hdc);
            return ((pixels / (double)width) * length);
        }
        [DllImport("gdi32.dll")]
        private static extern int GetDeviceCaps(IntPtr hdc, int index);
    }
}
