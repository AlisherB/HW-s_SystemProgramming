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
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            endPath = saveFileDialog.FileName;
            endPathTextBox.Text = endPath;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(beginPath) || String.IsNullOrEmpty(endPath))
            {
                MessageBox.Show("Файл не выбран");
            }
            Thread th = new Thread(Copy);
            th.Start();
        }

        private void Copy()
        {
            const int bufferSize = 1024 * 4;
            
            try
            {
                using (FileStream input = new FileStream(beginPath, FileMode.Open))
                {
                    byte[] buf = new byte[bufferSize];
                    int rw_count = (int)input.Length / bufferSize;
                    int lastSize = (int)input.Length % bufferSize;
                    using (FileStream output = new FileStream(endPath, FileMode.Create))
                    {
                        progressBar.Invoke(new Action<int>(((x) => progressBar.Maximum = x)), (int)input.Length / bufferSize);

                        for (int i = 0; i < rw_count; i++)
                        {
                            input.Read(buf, 0, bufferSize);
                            output.Write(buf, 0, bufferSize);
                            progressBar.Invoke(new Action<int>(((x) => progressBar.Value = x)), (int)input.Position / bufferSize);
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
