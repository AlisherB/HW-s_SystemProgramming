namespace HW_SP_14._03._18
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.beginPathTextBox = new System.Windows.Forms.TextBox();
            this.endPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBeginPath = new System.Windows.Forms.Button();
            this.btnEndPath = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCopy = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // beginPathTextBox
            // 
            this.beginPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginPathTextBox.Location = new System.Drawing.Point(62, 13);
            this.beginPathTextBox.Name = "beginPathTextBox";
            this.beginPathTextBox.ReadOnly = true;
            this.beginPathTextBox.Size = new System.Drawing.Size(354, 23);
            this.beginPathTextBox.TabIndex = 0;
            // 
            // endPathTextBox
            // 
            this.endPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endPathTextBox.Location = new System.Drawing.Point(62, 56);
            this.endPathTextBox.Name = "endPathTextBox";
            this.endPathTextBox.ReadOnly = true;
            this.endPathTextBox.Size = new System.Drawing.Size(354, 23);
            this.endPathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Откуда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Куда";
            // 
            // btnBeginPath
            // 
            this.btnBeginPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeginPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeginPath.Location = new System.Drawing.Point(422, 13);
            this.btnBeginPath.Name = "btnBeginPath";
            this.btnBeginPath.Size = new System.Drawing.Size(75, 23);
            this.btnBeginPath.TabIndex = 4;
            this.btnBeginPath.Text = "Файл...";
            this.btnBeginPath.UseVisualStyleBackColor = true;
            this.btnBeginPath.Click += new System.EventHandler(this.BtnBeginPath_Click);
            // 
            // btnEndPath
            // 
            this.btnEndPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndPath.Location = new System.Drawing.Point(422, 56);
            this.btnEndPath.Name = "btnEndPath";
            this.btnEndPath.Size = new System.Drawing.Size(75, 23);
            this.btnEndPath.TabIndex = 5;
            this.btnEndPath.Text = "Файл...";
            this.btnEndPath.UseVisualStyleBackColor = true;
            this.btnEndPath.Click += new System.EventHandler(this.BtnEndPath_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(15, 100);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(401, 23);
            this.progressBar.TabIndex = 6;
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopy.Location = new System.Drawing.Point(422, 100);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 143);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnEndPath);
            this.Controls.Add(this.btnBeginPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endPathTextBox);
            this.Controls.Add(this.beginPathTextBox);
            this.MaximumSize = new System.Drawing.Size(525, 182);
            this.MinimumSize = new System.Drawing.Size(525, 182);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beginPathTextBox;
        private System.Windows.Forms.TextBox endPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBeginPath;
        private System.Windows.Forms.Button btnEndPath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

