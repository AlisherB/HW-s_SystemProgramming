using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Sync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    ShowProcesses();
                    Thread.Sleep(10000);
                }
            });
            thread.Start();

        }
        void ShowProcesses()
        {
            Process[] processes = Process.GetProcesses();
            List<ListViewItem> list = new List<ListViewItem>();
            ListViewItem lvi = null;
            long memory = 0;
            try
            {
                foreach (Process process in processes)
                {
                    memory = process.WorkingSet64 / 1024;
                    lvi = new ListViewItem(new string[] 
                    {
                        process.ProcessName,
                        process.Id.ToString(),
                        process.MachineName,
                        memory.ToString() + " KB",
                        process.Threads.Count.ToString(),
                        //process.StartTime.ToString(),
                    });
                    list.Add(lvi);
                }
            }
            catch(Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listView.Invoke(new Action<Object>(x => listView.Items.Clear()), new Object());
            listView.Invoke(new Action<Object>(x => listView.Items.AddRange(list.ToArray())), new Object());
           // listView.Invoke(new Action<View>(x => listView.View = x), View.Details);
        }
    }
}
