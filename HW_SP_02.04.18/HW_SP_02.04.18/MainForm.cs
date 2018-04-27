﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HW_SP_02._04._18
{
    public partial class MainForm : Form
    {
        List<Thread> createdThreads, waitingThreads, runningThreads;
        Dictionary<Thread, int> CountThreads;
        Semaphore semaphore;
        static int count = 0;
        static int max = 3;

        public MainForm()
        {
            InitializeComponent();
            createdThreads = new List<Thread>();
            waitingThreads = new List<Thread>();
            runningThreads = new List<Thread>();
            semaphore = new Semaphore(max, max);
            CountThreads = new Dictionary<Thread, int>();
        }

        private void Created_listView_DoubleClick(object sender, EventArgs e)
        {
            string numStr = (sender as ListView).SelectedItems[0].Text.Replace("Created thread --> ", "");
            (sender as ListView).SelectedItems[0].Remove();
            Thread th = createdThreads.First(x => x.ManagedThreadId.ToString() == numStr);
            createdThreads.Remove(th);
            waitingThreads.Add(th);
            waiting_listView.Items.Add($"Waiting thread --> { th.ManagedThreadId }");
        }

        private void Waiting_listView_DoubleClick(object sender, EventArgs e)
        {
            string numStr = (sender as ListView).SelectedItems[0].Text.Replace("Waiting thread --> ", "");
            Thread th = waitingThreads.First(x => x.ManagedThreadId.ToString() == numStr);
            if (count < max)
            {
                (sender as ListView).SelectedItems[0].Remove();
                waitingThreads.Remove(th);
                runningThreads.Add(th);
                th.Start();
                running_listView.Items.Add(runningThreads.IndexOf(th).ToString(), $"Running thread --> { th.ManagedThreadId } --> 0", "");
            }
        }

        private void Running_listView_DoubleClick(object sender, EventArgs e)
        {
            string numStr = (sender as ListView).SelectedItems[0].Text.Replace("Running thread --> ", "").Replace("-->", "");
            numStr = numStr.Remove(numStr.Length - 2);
            (sender as ListView).SelectedItems[0].Remove();
            Thread th = runningThreads.FirstOrDefault(x => x.ManagedThreadId.ToString() == numStr);
            th.Abort();
            runningThreads.Remove(th);
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            runningThreads.ForEach(x => x.Suspend());
            semaphore.Close();
            int prevMax = max;
            max = (int)(sender as NumericUpDown).Value;
            semaphore = new Semaphore(max, max);
            if (max > prevMax)
                runningThreads.ForEach(x => x.Resume());
            else
            {
                int countRel = max - prevMax;
                var threads = CountThreads.OrderBy(x => x.Value).ToList();
                for (int i = 0; i < countRel; i++)
                    runningThreads.Remove(threads[i].Key);
                runningThreads.ForEach(x => x.Resume());
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Incrementer);
            createdThreads.Add(th);
            created_listView.Items.Add($"Created thread --> { th.ManagedThreadId }");
        }

        private void Incrementer()
        {
            semaphore.WaitOne();
            count++;
            Thread curThread = Thread.CurrentThread;
            int counter = 0;
            CountThreads.Add(curThread, counter);
            while (curThread.ThreadState != ThreadState.AbortRequested)
            {
                running_listView.Invoke(new Action(() =>
                {
                    running_listView.Items.Find(runningThreads.IndexOf(curThread).ToString(), false).FirstOrDefault().Text = $"Running thread --> { curThread.ManagedThreadId }-->{counter}";
                }));
                CountThreads[curThread] = counter;
                counter++;
                Thread.Sleep(1000);
            }
            semaphore.Release();
        }
    }
}
