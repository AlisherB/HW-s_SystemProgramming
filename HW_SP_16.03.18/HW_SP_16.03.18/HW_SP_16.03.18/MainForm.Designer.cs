namespace HW_SP_16._03._18
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
            this.setFile_button = new System.Windows.Forms.Button();
            this.filePath_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encrypt_radioButton = new System.Windows.Forms.RadioButton();
            this.decrypt_radioButton = new System.Windows.Forms.RadioButton();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.start_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // setFile_button
            // 
            this.setFile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setFile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setFile_button.Location = new System.Drawing.Point(12, 12);
            this.setFile_button.Name = "setFile_button";
            this.setFile_button.Size = new System.Drawing.Size(85, 24);
            this.setFile_button.TabIndex = 0;
            this.setFile_button.Text = "Файл...";
            this.setFile_button.UseVisualStyleBackColor = true;
            this.setFile_button.Click += new System.EventHandler(this.SetFile_button_Click);
            // 
            // filePath_textBox
            // 
            this.filePath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePath_textBox.Location = new System.Drawing.Point(103, 13);
            this.filePath_textBox.Name = "filePath_textBox";
            this.filePath_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.filePath_textBox.Size = new System.Drawing.Size(450, 23);
            this.filePath_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль";
            // 
            // encrypt_radioButton
            // 
            this.encrypt_radioButton.AutoSize = true;
            this.encrypt_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt_radioButton.Location = new System.Drawing.Point(301, 60);
            this.encrypt_radioButton.Name = "encrypt_radioButton";
            this.encrypt_radioButton.Size = new System.Drawing.Size(109, 19);
            this.encrypt_radioButton.TabIndex = 3;
            this.encrypt_radioButton.TabStop = true;
            this.encrypt_radioButton.Text = "Зашифровать";
            this.encrypt_radioButton.UseVisualStyleBackColor = true;
            // 
            // decrypt_radioButton
            // 
            this.decrypt_radioButton.AutoSize = true;
            this.decrypt_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_radioButton.Location = new System.Drawing.Point(438, 60);
            this.decrypt_radioButton.Name = "decrypt_radioButton";
            this.decrypt_radioButton.Size = new System.Drawing.Size(115, 19);
            this.decrypt_radioButton.TabIndex = 4;
            this.decrypt_radioButton.TabStop = true;
            this.decrypt_radioButton.Text = "Расшифровать";
            this.decrypt_radioButton.UseVisualStyleBackColor = true;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(103, 59);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(180, 20);
            this.password_textBox.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(15, 101);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(538, 23);
            this.progressBar.TabIndex = 6;
            // 
            // start_button
            // 
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(348, 140);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(85, 24);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "Пуск";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(468, 140);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(85, 24);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 176);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.decrypt_radioButton);
            this.Controls.Add(this.encrypt_radioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePath_textBox);
            this.Controls.Add(this.setFile_button);
            this.MaximumSize = new System.Drawing.Size(581, 215);
            this.MinimumSize = new System.Drawing.Size(581, 215);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setFile_button;
        private System.Windows.Forms.TextBox filePath_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton encrypt_radioButton;
        private System.Windows.Forms.RadioButton decrypt_radioButton;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

