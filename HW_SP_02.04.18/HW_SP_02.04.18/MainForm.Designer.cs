﻿namespace HW_SP_02._04._18
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.created_listView = new System.Windows.Forms.ListView();
            this.thread1_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waiting_listView = new System.Windows.Forms.ListView();
            this.thread2_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.running_listView = new System.Windows.Forms.ListView();
            this.thread3_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
<<<<<<< HEAD
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
=======
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
=======
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.label1.TabIndex = 0;
            this.label1.Text = "Created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(244, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
=======
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(435, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
=======
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.label3.TabIndex = 2;
            this.label3.Text = "Running";
            // 
            // created_listView
            // 
            this.created_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.thread1_column});
<<<<<<< HEAD
            this.created_listView.Location = new System.Drawing.Point(13, 53);
            this.created_listView.Name = "created_listView";
            this.created_listView.Size = new System.Drawing.Size(150, 97);
=======
            this.created_listView.Location = new System.Drawing.Point(12, 36);
            this.created_listView.Name = "created_listView";
            this.created_listView.Size = new System.Drawing.Size(156, 97);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.created_listView.TabIndex = 3;
            this.created_listView.UseCompatibleStateImageBehavior = false;
            this.created_listView.View = System.Windows.Forms.View.Details;
            this.created_listView.DoubleClick += new System.EventHandler(this.Created_listView_DoubleClick);
            // 
            // thread1_column
            // 
            this.thread1_column.Text = "Threads";
<<<<<<< HEAD
            this.thread1_column.Width = 150;
=======
            this.thread1_column.Width = 145;
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            // 
            // waiting_listView
            // 
            this.waiting_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.thread2_column});
<<<<<<< HEAD
            this.waiting_listView.Location = new System.Drawing.Point(202, 53);
            this.waiting_listView.Name = "waiting_listView";
            this.waiting_listView.Size = new System.Drawing.Size(150, 97);
=======
            this.waiting_listView.Location = new System.Drawing.Point(197, 36);
            this.waiting_listView.Name = "waiting_listView";
            this.waiting_listView.Size = new System.Drawing.Size(156, 97);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.waiting_listView.TabIndex = 4;
            this.waiting_listView.UseCompatibleStateImageBehavior = false;
            this.waiting_listView.View = System.Windows.Forms.View.Details;
            this.waiting_listView.DoubleClick += new System.EventHandler(this.Waiting_listView_DoubleClick);
            // 
            // thread2_column
            // 
            this.thread2_column.Text = "Threads";
<<<<<<< HEAD
            this.thread2_column.Width = 150;
=======
            this.thread2_column.Width = 145;
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            // 
            // running_listView
            // 
            this.running_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.thread3_column});
<<<<<<< HEAD
            this.running_listView.Location = new System.Drawing.Point(393, 53);
            this.running_listView.Name = "running_listView";
            this.running_listView.Size = new System.Drawing.Size(150, 97);
=======
            this.running_listView.Location = new System.Drawing.Point(381, 36);
            this.running_listView.Name = "running_listView";
            this.running_listView.Size = new System.Drawing.Size(156, 97);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.running_listView.TabIndex = 5;
            this.running_listView.UseCompatibleStateImageBehavior = false;
            this.running_listView.View = System.Windows.Forms.View.Details;
            this.running_listView.DoubleClick += new System.EventHandler(this.Running_listView_DoubleClick);
            // 
            // thread3_column
            // 
            this.thread3_column.Text = "Threads";
<<<<<<< HEAD
            this.thread3_column.Width = 150;
            // 
            // numUpDown
            // 
            this.numUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDown.Location = new System.Drawing.Point(193, 178);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(75, 26);
            this.numUpDown.TabIndex = 6;
            this.numUpDown.ValueChanged += new System.EventHandler(this.NumUpDown_ValueChanged);
=======
            this.thread3_column.Width = 145;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown.Location = new System.Drawing.Point(207, 164);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown.TabIndex = 6;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            // 
            // label4
            // 
            this.label4.AutoSize = true;
<<<<<<< HEAD
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(133, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
=======
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(149, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // create_btn
            // 
<<<<<<< HEAD
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.Location = new System.Drawing.Point(291, 178);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(93, 27);
            this.create_btn.TabIndex = 8;
            this.create_btn.Text = "Create";
=======
            this.create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.Location = new System.Drawing.Point(278, 164);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(97, 23);
            this.create_btn.TabIndex = 8;
            this.create_btn.Text = "Create thread";
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(554, 231);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUpDown);
=======
            this.ClientSize = new System.Drawing.Size(553, 214);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown);
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.Controls.Add(this.running_listView);
            this.Controls.Add(this.waiting_listView);
            this.Controls.Add(this.created_listView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
<<<<<<< HEAD
            this.MaximumSize = new System.Drawing.Size(570, 270);
            this.MinimumSize = new System.Drawing.Size(570, 270);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
=======
            this.MaximumSize = new System.Drawing.Size(569, 253);
            this.MinimumSize = new System.Drawing.Size(569, 253);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView created_listView;
        private System.Windows.Forms.ListView waiting_listView;
        private System.Windows.Forms.ListView running_listView;
<<<<<<< HEAD
        private System.Windows.Forms.NumericUpDown numUpDown;
=======
        private System.Windows.Forms.NumericUpDown numericUpDown;
>>>>>>> 34ba290710a8846675ed62417a1854c2a60f84d0
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.ColumnHeader thread1_column;
        private System.Windows.Forms.ColumnHeader thread2_column;
        private System.Windows.Forms.ColumnHeader thread3_column;
    }
}

