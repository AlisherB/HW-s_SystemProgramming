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
        Thread th_encrypt, th_decrypt;
        public MainForm()
        {
            InitializeComponent();
            th_encrypt = new Thread(Encrypt);
            th_decrypt = new Thread(Decrypt);
        }

        private void Encrypt()
        {
            string pText;
            try
            {
                FileStream fstream = new FileStream(filePath_textBox.Text, FileMode.Open);
                byte[] text = new byte[fstream.Length];
                fstream.Read(text, 0, text.Length);
                pText = Encoding.Default.GetString(text);
            
                byte[] key = Encoding.Default.GetBytes(password_textBox.Text);
                byte[] result = new byte[pText.Length];

                for (int i = 0; i < text.Length; i++)
                {
                    result[i] = (byte)(text[i] ^ key[i % key.Length]);
                }

                FileStream fstream1 = new FileStream(filePath_textBox.Text, FileMode.Truncate);
                fstream1.Write(result, 0, result.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Decrypt()
        {
            string pText;
            try
            {
                FileStream fstream = new FileStream(filePath_textBox.Text, FileMode.Open);
                byte[] text = new byte[fstream.Length];
                fstream.Read(text, 0, text.Length);
                pText = Encoding.Default.GetString(text);

                byte[] result = new byte[pText.Length];
                byte[] key = Encoding.Default.GetBytes(password_textBox.Text);

                for (int i = 0; i < pText.Length; i++)
                {
                    result[i] = (byte)(pText[i] ^ key[i % key.Length]);
                }

                FileStream fstream1 = new FileStream(filePath_textBox.Text, FileMode.Truncate);
                fstream1.Write(result, 0, result.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if (String.IsNullOrEmpty(password_textBox.Text))
            {
                MessageBox.Show("Введите пароль!!!");
                return;
            }

            if (encrypt_radioButton.Checked)
            {
                if (th_encrypt.ThreadState == ThreadState.Unstarted)
                    th_encrypt.Start();
                else th_encrypt.Resume();
                MessageBox.Show("Шифрование завершено!");
            }
            else if (decrypt_radioButton.Checked)
            {
                if (th_decrypt.ThreadState == ThreadState.Unstarted)
                    th_decrypt.Start();
                else th_decrypt.Resume();
                MessageBox.Show("Расшифровка завершена!");
            }
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            if (th_encrypt.ThreadState == ThreadState.Running)
            {
                th_encrypt.Suspend();
            }
            else if (th_decrypt.ThreadState == ThreadState.Running)
            {
                th_decrypt.Suspend();
            }
        }
    }
}
