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

namespace HW_SP_26._03._18
{
    public partial class MainForm : Form
    {
        List<string> list = new List<string>(100000);
        string proposedText;

        public MainForm()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("1.txt");
            while (!sr.EndOfStream)
            {
                list.Add(sr.ReadLine());
            }
            list.Sort();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {

            }
            else
            {
                string[] words = textBox1.Text.Split(' ');
                string lastWord = words[words.Length - 1];
                try
                {
                    int pos = list.BinarySearch(lastWord, new MyComparer());
                    if (pos >= 0)
                    {
                        proposedText = list[pos];
                        string partProposed = proposedText.Substring(proposedText.Length - (proposedText.Length - lastWord.Length));
                        textBox1.Text += partProposed;
                        textBox1.Select(textBox1.Text.Length - partProposed.Length, partProposed.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                label1.Text = proposedText;
            }
        }
    }

    public class MyComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.StartsWith(y))
                return 0;
            return x.CompareTo(y);
        }
    }
    
}
