using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            done.Enabled = false;
        }

        private void review_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                way_filePaste.Text = folder.SelectedPath;
            }
        }

        private void file_location_Click(object sender, EventArgs e)
        {
            OpenFileDialog folder = new OpenFileDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                way_fileCopy.Text = folder.FileName;
            }
        }
        private string fileName(){
            string fileName="";
            string start = way_fileCopy.Text;
  
            int i = start.Length;
            while (start.Substring(i - 1, 1)!="\\")
            {
                i--;
                fileName = start.Substring(i - 1, 1)+fileName;
                
            }
            return fileName;
        }
        private void done_Click(object sender, EventArgs e)
        {
            Copy(way_fileCopy.Text, way_filePaste.Text+fileName());
        }

        private void agree_CheckedChanged(object sender, EventArgs e)
        {
            if (agree.Checked)
            {
                done.Enabled = true;
            }
            else
            {
                done.Enabled = false;
            }
        }
        private void Copy(string SourceFilePath,string DestFilePath)
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            bool cancelFlag = false;

            using (var sourceStream = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan))

            {
                long fileLength = sourceStream.Length;
                using (var destinationStream = new FileStream(DestFilePath, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan))
                {
                    long totalBytes = 0;
                    int currentBlockSize = 0;

                    while ((currentBlockSize = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytes += currentBlockSize;
                        int persentage = (int)((double)totalBytes * 100.0 / fileLength);

                        destinationStream.Write(buffer, 0, currentBlockSize);

                        cancelFlag = false;
                        progress.Value = persentage;

                        if (cancelFlag == true)
                        {
                            //еще не закончено
                            //тут удаление файла
                            //программа копирования
                            break;
                        }
                    } 
                }
            }
            MessageBox.Show("the file was copied " + DestFilePath, "Done", MessageBoxButtons.OK);
        }
    }
}
