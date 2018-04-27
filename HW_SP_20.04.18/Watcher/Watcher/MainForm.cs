using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Watcher
{
    public partial class MainForm : Form
    {
        static string path = "";
        static string filter = "";
        static bool includeSubs = false;
        Container components = null;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = folderBrowserDialog.SelectedPath;
            dir_textBox.Text = path;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dir_textBox.Text))
                MessageBox.Show("Укажите директорий");
            else
                path = dir_textBox.Text;

            if (fileFilterList_comboBox.SelectedText != "")
                filter = fileFilterList_comboBox.SelectedText.ToString();
            else
                filter = "*.*";

            if (subDirAreIncluded_checkBox.Checked == true)
                includeSubs = true;
            else
                includeSubs = false;
            
            fileSystemWatcher.Path = path.ToString();
            fileSystemWatcher.Filter = filter.ToString();
            fileSystemWatcher.IncludeSubdirectories = includeSubs;
            fileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            //Начать слежку
            fileSystemWatcher.EnableRaisingEvents = true;
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            //Остановить слежку
            fileSystemWatcher.EnableRaisingEvents = false;
        }

        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            string ChangeType = e.ChangeType.ToString();

            //Вывод сообщений об изменениях в выбранном директории
            if (ChangeType == "Created")
            {
                MessageBox.Show("File: " + e.FullPath + " " + e.ChangeType, e.Name + " Created");
            }
            else if (ChangeType == "Deleted")
            {
                MessageBox.Show("File: " + e.FullPath + " " + e.ChangeType, e.Name + " Deleted");
            }
            else if (ChangeType == "Changed")
            {
                MessageBox.Show("File: " + e.FullPath + " " + e.ChangeType, e.Name + " Changed");
            }
        }

        private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            string originalname = e.OldFullPath;
            string renamed = e.FullPath;
            MessageBox.Show("Файл: " + originalname + " переименован в " + renamed, e.OldName + " Renamed");
        }

        
    }
}
