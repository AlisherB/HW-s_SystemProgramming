using System;
using System.Windows.Forms;
using System.IO;

namespace MyWatcher
{
    public partial class MainForm : Form
    {
        public const String startMonitoring = "Start Monitoring...";
        public const String stopMonitoring = "Stop Monitoring...";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                dir_textBox.Text = folderBrowserDialog.SelectedPath;
                Environment.SpecialFolder root = folderBrowserDialog.RootFolder;
            }
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            switch (start_button.Text)
            {
                case startMonitoring:
                    if (!string.IsNullOrEmpty(dir_textBox.Text))
                    {
                        listBox.Items.Add("Сервис мониторинга запущен...");
                        watcher.Path = dir_textBox.Text;
                        
                        watcher.Filter = (string.IsNullOrEmpty(filter_textBox.Text)) ? "*.*" : filter_textBox.Text;
                        watcher.IncludeSubdirectories = true;
                        
                        watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime |
                                                 NotifyFilters.DirectoryName | NotifyFilters.FileName |
                                                 NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                                                 NotifyFilters.Security | NotifyFilters.Size;
                        watcher.EnableRaisingEvents = true;
                        
                        watcher.Changed += new FileSystemEventHandler(OnChanged);
                        watcher.Created += new FileSystemEventHandler(OnCreated);
                        watcher.Deleted += new FileSystemEventHandler(OnDeleted);
                        watcher.Renamed += new RenamedEventHandler(OnRenamed);
                        watcher.Error += new ErrorEventHandler(OnError);

                        start_button.Text = stopMonitoring;
                        dir_textBox.Enabled = false;
                        filter_textBox.Enabled = false;
                    }
                    else
                        listBox.Items.Add("Выберите директорий для мониторинга...");
                    break;
                    
                case stopMonitoring:
                default:
                    watcher.EnableRaisingEvents = false;
                    watcher = null;
                    start_button.Text = startMonitoring;
                    dir_textBox.Enabled = true;
                    filter_textBox.Enabled = true;
                    listBox.Items.Add("Сервис мониторинга остановлен...");
                    break;
            }
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { listBox.Items.Add(String.Format("Ошибка : {0}", e.GetException().Message)); });
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { listBox.Items.Add(String.Format("Путь : \"{0}\"   || Действие : {1} to \"{2}\"", e.FullPath, e.ChangeType, e.Name)); });
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { listBox.Items.Add(String.Format("Путь : \"{0}\"   || Действие : {1}", e.FullPath, e.ChangeType)); });
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { listBox.Items.Add(String.Format("Путь : \"{0}\"   || Действие : {1}", e.FullPath, e.ChangeType)); });
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { listBox.Items.Add(String.Format("Путь : \"{0}\"   || Действие : {1}", e.FullPath, e.ChangeType)); });

        }
    }
}
