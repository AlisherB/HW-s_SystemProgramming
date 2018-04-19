using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_SP_16._03._18
{
    public partial class MainForm : Form
    {
        Thread th_crypt = null;
        const int bufferSize = 1024;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Encrypt(string password)
        {
            byte[] passwordBytes = Encoding.Default.GetBytes(password_textBox.Text);
            try
            {
                using (FileStream fstream = new FileStream(ofd.FileName, FileMode.Open))
                {
                    progressBar.Invoke(new Action<int>(((x) => progressBar.Maximum = x)), (int)fstream.Length / bufferSize);
                    Crypt(password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Decrypt(string password)
        {
            byte[] passwordBytes = Encoding.Default.GetBytes(password_textBox.Text);
            try
            {
                using (FileStream fstream = new FileStream(ofd.FileName, FileMode.Open))
                {
                    progressBar.Invoke(new Action<int>(((x) => progressBar.Maximum = x)), (int)fstream.Length / bufferSize);
                    Crypt(password);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Crypt(string password)
        {
            string pText;
            byte[] txt;
            using (FileStream fstream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite))
            {
                txt = new byte[fstream.Length];
                
                fstream.Read(txt, 0, txt.Length);
                pText = Encoding.Default.GetString(txt);
            }

            byte[] result = new byte[pText.Length];
            for (int i = 0; i < txt.Length; i++)
                result[i] = (byte)(txt[i] ^ password[i % password.Length]);
                
            using (FileStream fstream = new FileStream(ofd.FileName, FileMode.Truncate,FileAccess.ReadWrite))
            {
                progressBar.Invoke(new Action<int>((x) =>
                {
                    if (progressBar.Maximum < x)
                        progressBar.Maximum = x;
                    progressBar.Value = x;
                }), (int)(fstream.Position / bufferSize));
                progressBar.Invoke(new Action<int>(((x) => progressBar.Value = x)), (int)(fstream.Position / bufferSize));
                fstream.Write(result, 0, result.Length);
                
            }
        }

        private void SetFile_button_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            filePath_textBox.Text = ofd.FileName;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(filePath_textBox.Text))
            {
                MessageBox.Show("Выберите файл!!!");
                return;
            }
            else if (String.IsNullOrEmpty(password_textBox.Text))
            {
                MessageBox.Show("Введите пароль!!!");
                return;
            }

            if (!(encrypt_radioButton.Checked || decrypt_radioButton.Checked))
            {
                MessageBox.Show("Не выбран пункт шифровки или дешифровки!");
            }
            else if (encrypt_radioButton.Checked)
            {
                th_crypt = new Thread(() => Encrypt(password_textBox.Text));
                
                MessageBox.Show("Шифрование завершено!");
            }
            else if (decrypt_radioButton.Checked)
            {
                th_crypt = new Thread(() => Decrypt(password_textBox.Text));
                MessageBox.Show("Расшифровка завершена!");
            }
            th_crypt.Start();
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            if (th_crypt.ThreadState == ThreadState.Running)
                th_crypt.Suspend();
        }
    }
}
