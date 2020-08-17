namespace Find
{
    partial class FindControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Line_checkBox = new System.Windows.Forms.CheckBox();
            this.Reverse_CheckBox = new System.Windows.Forms.CheckBox();
            this.Register_CheckBox = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Search_TextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Search_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(385, 26);
            this.Search_TextBox.TabIndex = 0;
            this.Search_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_TextBox_KeyPress);
            // 
            // Search_button
            // 
            this.Search_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(156, 35);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(79, 33);
            this.Search_button.TabIndex = 1;
            this.Search_button.Text = "Найти!";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Line_checkBox);
            this.groupBox1.Controls.Add(this.Reverse_CheckBox);
            this.groupBox1.Controls.Add(this.Register_CheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(114, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // Line_checkBox
            // 
            this.Line_checkBox.AutoSize = true;
            this.Line_checkBox.Location = new System.Drawing.Point(6, 90);
            this.Line_checkBox.Name = "Line_checkBox";
            this.Line_checkBox.Size = new System.Drawing.Size(143, 20);
            this.Line_checkBox.TabIndex = 4;
            this.Line_checkBox.TabStop = false;
            this.Line_checkBox.Text = "Поиск по строкам";
            this.Line_checkBox.UseVisualStyleBackColor = true;
            // 
            // Reverse_CheckBox
            // 
            this.Reverse_CheckBox.AutoSize = true;
            this.Reverse_CheckBox.Location = new System.Drawing.Point(6, 48);
            this.Reverse_CheckBox.Name = "Reverse_CheckBox";
            this.Reverse_CheckBox.Size = new System.Drawing.Size(145, 36);
            this.Reverse_CheckBox.TabIndex = 3;
            this.Reverse_CheckBox.TabStop = false;
            this.Reverse_CheckBox.Text = "Поиск в обратном\r\nнаправлении";
            this.Reverse_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Register_CheckBox
            // 
            this.Register_CheckBox.AutoSize = true;
            this.Register_CheckBox.Location = new System.Drawing.Point(6, 22);
            this.Register_CheckBox.Name = "Register_CheckBox";
            this.Register_CheckBox.Size = new System.Drawing.Size(153, 20);
            this.Register_CheckBox.TabIndex = 2;
            this.Register_CheckBox.TabStop = false;
            this.Register_CheckBox.Text = "Учитывать регистр";
            this.Register_CheckBox.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 242);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 121);
            this.listView1.TabIndex = 5;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(125, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить в книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FindControl";
            this.Size = new System.Drawing.Size(391, 366);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Line_checkBox;
        private System.Windows.Forms.CheckBox Reverse_CheckBox;
        private System.Windows.Forms.CheckBox Register_CheckBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}
