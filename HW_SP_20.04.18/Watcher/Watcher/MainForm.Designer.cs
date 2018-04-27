using System;
using System.IO;

namespace Watcher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.dir_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileFilterList_comboBox = new System.Windows.Forms.ComboBox();
            this.subDirAreIncluded_checkBox = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.open_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Directory";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // start_button
            // 
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(119, 130);
            this.start_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(99, 37);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_button.Location = new System.Drawing.Point(271, 130);
            this.stop_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(99, 37);
            this.stop_button.TabIndex = 4;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // dir_textBox
            // 
            this.dir_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dir_textBox.Location = new System.Drawing.Point(92, 28);
            this.dir_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dir_textBox.Name = "dir_textBox";
            this.dir_textBox.Size = new System.Drawing.Size(295, 23);
            this.dir_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fileFilterList_comboBox
            // 
            this.fileFilterList_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileFilterList_comboBox.FormattingEnabled = true;
            this.fileFilterList_comboBox.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".xls"});
            this.fileFilterList_comboBox.Location = new System.Drawing.Point(92, 70);
            this.fileFilterList_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fileFilterList_comboBox.Name = "fileFilterList_comboBox";
            this.fileFilterList_comboBox.Size = new System.Drawing.Size(144, 24);
            this.fileFilterList_comboBox.TabIndex = 7;
            // 
            // subDirAreIncluded_checkBox
            // 
            this.subDirAreIncluded_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subDirAreIncluded_checkBox.Location = new System.Drawing.Point(286, 68);
            this.subDirAreIncluded_checkBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subDirAreIncluded_checkBox.Name = "subDirAreIncluded_checkBox";
            this.subDirAreIncluded_checkBox.Size = new System.Drawing.Size(180, 24);
            this.subDirAreIncluded_checkBox.TabIndex = 8;
            this.subDirAreIncluded_checkBox.Text = "Include Sub Directories:";
            this.subDirAreIncluded_checkBox.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.FileSystemWatcher_Renamed);
            // 
            // open_button
            // 
            this.open_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_button.Location = new System.Drawing.Point(394, 26);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 27);
            this.open_button.TabIndex = 9;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 186);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.subDirAreIncluded_checkBox);
            this.Controls.Add(this.fileFilterList_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dir_textBox);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(510, 225);
            this.MinimumSize = new System.Drawing.Size(510, 225);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectoryMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.TextBox dir_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fileFilterList_comboBox;
        private System.Windows.Forms.CheckBox subDirAreIncluded_checkBox;
        private FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

