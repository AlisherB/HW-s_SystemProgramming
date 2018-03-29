using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SP_HW_One
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MenuItem_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            ListViewItem listViewItems = null;
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (Process process in processes)
            {
                listViewItems = new ListViewItem();
                listViewItems.Text = process.ProcessName;
                listViewItems.SubItems.Add(process.Id.ToString());
                listViewItems.SubItems.Add(process.MachineName);
                //listViewItems.SubItems.Add(process.StartTime.ToString());
                listView1.Items.Add(listViewItems);
            }
            listView1.EndUpdate();
        }
    }
}
