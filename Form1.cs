using System;
using System.IO;
using System.Windows.Forms;

namespace BinCleaner
{
    public partial class Form1 : Form
    {
        string rootDir = @"D:\tfs\BOA\Test\";

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = rootDir;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            Clean(rootDir);

            MessageBox.Show("İşlem tamam");
        }

        private void Clean(string dirPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);

            if (directoryInfo.Name == "Debug")
            {
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    directory.Delete(true);
                }
            }
            else
            {
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    Clean(directory.FullName);
                }
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();

            rootDir = folderBrowserDialog1.SelectedPath;
            textBox1.Text = rootDir;
        }
    }
}
