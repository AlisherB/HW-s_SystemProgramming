using System.Windows.Forms;
using Microsoft.Win32;
using System;

namespace HW_SP_04._04._18
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RootNodes();
        }
        
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = treeView.SelectedNode;
            var path = node.FullPath;
            statusLabel_path.Text = path;
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView.BeginUpdate();
            foreach (TreeNode tn in e.Node.Nodes)
            {
                AddBranch(tn);
            }
            treeView.EndUpdate();
        }

        public void AddBranch(TreeNode tn)
        {
            tn.Nodes.Clear();
            string strRegistryPath = tn.FullPath;

            RegistryKey regBranch = null;
            //if (strRegistryPath.StartsWith("HKEY_CLASSES_ROOT"))
            //    regBranch = Registry.ClassesRoot;
            /*else*/ if (strRegistryPath.StartsWith("HKEY_CURRENT_USER"))
                regBranch = Registry.CurrentUser;
            else if (strRegistryPath.StartsWith("HKEY_LOCAL_MACHINE"))
                regBranch = Registry.LocalMachine;
            else if (strRegistryPath.StartsWith("HKEY_USERS"))
                regBranch = Registry.Users;
            else if (strRegistryPath.StartsWith("HKEY_CURRENT_CONFIG"))
                regBranch = Registry.CurrentConfig;

            RegistryKey regSubKey = null;
            try
            {
                if (null != tn.Parent)
                {
                    int nPosPathSeparator = strRegistryPath.IndexOf(treeView.PathSeparator);
                    string strSubkey = strRegistryPath.Substring(nPosPathSeparator + 1);
                    regSubKey = regBranch.OpenSubKey(strSubkey);
                }
                else
                    regSubKey = regBranch;
            }
            catch
            {
                return;
            }

            string[] strSubkeyNames = regSubKey.GetSubKeyNames();
            for (int i = 0; i < strSubkeyNames.Length; i++)
            {
                TreeNode tnBranch = new TreeNode(strSubkeyNames[i], 0, 1);
                tn.Nodes.Add(tnBranch);
            }
        }
        
        public void RootNodes()
        {
            treeView.BeginUpdate();

            //TreeNode tnHKCR = new TreeNode("HKEY_CLASSES_ROOT", 0, 1);
            //treeView.Nodes.Add(tnHKCR);
            //AddBranch(tnHKCR);

            TreeNode tnHKCU = new TreeNode("HKEY_CURRENT_USER", 0, 1);
            treeView.Nodes.Add(tnHKCU);
            AddBranch(tnHKCU);

            TreeNode tnHKLM = new TreeNode("HKEY_LOCAL_MACHINE", 0, 1);
            treeView.Nodes.Add(tnHKLM);
            AddBranch(tnHKLM);

            TreeNode tnHKU = new TreeNode("HKEY_USERS", 0, 1);
            treeView.Nodes.Add(tnHKU);
            AddBranch(tnHKU);

            TreeNode tnHKCC = new TreeNode("HKEY_CURRENT_CONFIG", 0, 1);
            treeView.Nodes.Add(tnHKCC);
            AddBranch(tnHKCC);

            treeView.SelectedNode = tnHKLM;
            treeView.EndUpdate();
        }
    }
}
