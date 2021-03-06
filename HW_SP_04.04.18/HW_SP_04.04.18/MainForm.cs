﻿using System.Windows.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace HW_SP_04._04._18
{
    public partial class MainForm : Form
    {
        RegistryKey regBranch = null;
        RegistryKey regSubKey = null;
        public MainForm()
        {
            InitializeComponent();
            RootNodes();
        }

        RegistryKey curRegKey = Registry.CurrentUser;
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = treeView.SelectedNode;
            var path = node.FullPath;
            statusLabel_path.Text = path;
            listView.Clear();
            try
            {
                AddValuesToList(curRegKey);
                //string regKeyName = e.Node.FullPath.Replace(@"HKEY_CURRENT_USER\", "");
                //RegistryKey regSubKey = curRegKey.OpenSubKey(regKeyName);
                //string[] values = regSubKey.GetValueNames();
                //for (int i = 0; i < values.Length; i++)
                //{
                //    RegistryValueKind kind = regSubKey.GetValueKind(values[i]);
                //    ListViewItem item = listView.Items.Add(i.ToString());
                //    item.SubItems.Add(values[i]);
                //    item.SubItems.Add(kind.ToString());
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void AddValuesToList(RegistryKey key)
        {
            foreach (string name in key.GetValueNames())
            {
                string value = key.GetValue(name).ToString();
                ListViewItem item = new ListViewItem(new string[] { name, value });
                listView.Items.Add(item);
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
