using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace HW_SP_14._03._18
{
    public partial class MainForm : Form
    {
        string beginPath;
        string endPath;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnBeginPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            beginPath = openFileDialog.FileName;
            beginPathTextBox.Text = beginPath;
        }

        private void BtnEndPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            endPath = openFileDialog.FileName;
            endPathTextBox.Text = endPath;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(beginPath) || String.IsNullOrEmpty(endPath))
            {
                MessageBox.Show("Выберите файл...");
            }
            Thread th = new Thread(Copy);
            th.Start();
        }

        private void Copy()
        {
            int byteSize = 4096;
            byte[] array = new byte[byteSize];
            try
            {
                using (FileStream input = new FileStream(beginPath, FileMode.Open))
                {
                    long length = input.Length;
                    long pos = input.Position;
                    using (FileStream output = new FileStream(endPath, FileMode.OpenOrCreate))
                    {
                        progressBar.Invoke(new Action<int>(((x) => progressBar.Maximum = x)), (int)length / byteSize);

                        while (pos < length)
                        {
                            input.Read(array, 0, byteSize);
                            output.Write(array, 0, byteSize);
                            progressBar.Invoke(new Action<int>(((x) => progressBar.Value = x)), (int)pos / byteSize);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            
            MessageBox.Show("Копирование завершено!");
        }
    }
}
