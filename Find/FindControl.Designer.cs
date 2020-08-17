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
            this.TableLayout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.SearchOption_GroupBox = new System.Windows.Forms.GroupBox();
            this.Case_CheckBox = new System.Windows.Forms.CheckBox();
            this.Reverse_CheckBox = new System.Windows.Forms.CheckBox();
            this.SearchOrder_CheckBox = new System.Windows.Forms.CheckBox();
            this.TableLayout_Save = new System.Windows.Forms.TableLayoutPanel();
            this.SaveSheet_Button = new System.Windows.Forms.Button();
            this.SaveBook_Button = new System.Windows.Forms.Button();
            this.TableLayout_Search = new System.Windows.Forms.TableLayoutPanel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Clarify_Button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TableLayout_Main.SuspendLayout();
            this.SearchOption_GroupBox.SuspendLayout();
            this.TableLayout_Save.SuspendLayout();
            this.TableLayout_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout_Main
            // 
            this.TableLayout_Main.ColumnCount = 1;
            this.TableLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout_Main.Controls.Add(this.Search_TextBox, 0, 0);
            this.TableLayout_Main.Controls.Add(this.SearchOption_GroupBox, 0, 2);
            this.TableLayout_Main.Controls.Add(this.TableLayout_Save, 0, 3);
            this.TableLayout_Main.Controls.Add(this.TableLayout_Search, 0, 1);
            this.TableLayout_Main.Controls.Add(this.listView1, 0, 4);
            this.TableLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.TableLayout_Main.Name = "TableLayout_Main";
            this.TableLayout_Main.RowCount = 5;
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout_Main.Size = new System.Drawing.Size(391, 529);
            this.TableLayout_Main.TabIndex = 0;
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
            // SearchOption_GroupBox
            // 
            this.SearchOption_GroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchOption_GroupBox.Controls.Add(this.Case_CheckBox);
            this.SearchOption_GroupBox.Controls.Add(this.Reverse_CheckBox);
            this.SearchOption_GroupBox.Controls.Add(this.SearchOrder_CheckBox);
            this.SearchOption_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchOption_GroupBox.Location = new System.Drawing.Point(114, 95);
            this.SearchOption_GroupBox.Name = "SearchOption_GroupBox";
            this.SearchOption_GroupBox.Size = new System.Drawing.Size(163, 123);
            this.SearchOption_GroupBox.TabIndex = 6;
            this.SearchOption_GroupBox.TabStop = false;
            this.SearchOption_GroupBox.Text = "Параметры поиска";
            // 
            // Case_CheckBox
            // 
            this.Case_CheckBox.AutoSize = true;
            this.Case_CheckBox.Location = new System.Drawing.Point(6, 90);
            this.Case_CheckBox.Name = "Case_CheckBox";
            this.Case_CheckBox.Size = new System.Drawing.Size(153, 20);
            this.Case_CheckBox.TabIndex = 4;
            this.Case_CheckBox.TabStop = false;
            this.Case_CheckBox.Text = "Учитывать регистр";
            this.Case_CheckBox.UseVisualStyleBackColor = true;
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
            // SearchOrder_CheckBox
            // 
            this.SearchOrder_CheckBox.AutoSize = true;
            this.SearchOrder_CheckBox.Location = new System.Drawing.Point(6, 22);
            this.SearchOrder_CheckBox.Name = "SearchOrder_CheckBox";
            this.SearchOrder_CheckBox.Size = new System.Drawing.Size(158, 20);
            this.SearchOrder_CheckBox.TabIndex = 2;
            this.SearchOrder_CheckBox.TabStop = false;
            this.SearchOrder_CheckBox.Text = "Искать по столбцам";
            this.SearchOrder_CheckBox.UseVisualStyleBackColor = true;
            // 
            // TableLayout_Save
            // 
            this.TableLayout_Save.ColumnCount = 2;
            this.TableLayout_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.Controls.Add(this.SaveSheet_Button, 0, 0);
            this.TableLayout_Save.Controls.Add(this.SaveBook_Button, 1, 0);
            this.TableLayout_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Save.Location = new System.Drawing.Point(3, 224);
            this.TableLayout_Save.Name = "TableLayout_Save";
            this.TableLayout_Save.RowCount = 1;
            this.TableLayout_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.Size = new System.Drawing.Size(385, 54);
            this.TableLayout_Save.TabIndex = 7;
            // 
            // SaveSheet_Button
            // 
            this.SaveSheet_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveSheet_Button.Enabled = false;
            this.SaveSheet_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSheet_Button.Location = new System.Drawing.Point(41, 7);
            this.SaveSheet_Button.Name = "SaveSheet_Button";
            this.SaveSheet_Button.Size = new System.Drawing.Size(110, 40);
            this.SaveSheet_Button.TabIndex = 3;
            this.SaveSheet_Button.Text = "Сохранить как\r\nлист";
            this.SaveSheet_Button.UseVisualStyleBackColor = true;
            // 
            // SaveBook_Button
            // 
            this.SaveBook_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBook_Button.Enabled = false;
            this.SaveBook_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBook_Button.Location = new System.Drawing.Point(233, 7);
            this.SaveBook_Button.Name = "SaveBook_Button";
            this.SaveBook_Button.Size = new System.Drawing.Size(111, 40);
            this.SaveBook_Button.TabIndex = 4;
            this.SaveBook_Button.Text = "Сохранить как\r\nкнигу";
            this.SaveBook_Button.UseVisualStyleBackColor = true;
            this.SaveBook_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableLayout_Search
            // 
            this.TableLayout_Search.ColumnCount = 2;
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.Controls.Add(this.Search_Button, 0, 0);
            this.TableLayout_Search.Controls.Add(this.Clarify_Button, 1, 0);
            this.TableLayout_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Search.Location = new System.Drawing.Point(3, 35);
            this.TableLayout_Search.Name = "TableLayout_Search";
            this.TableLayout_Search.RowCount = 1;
            this.TableLayout_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.Size = new System.Drawing.Size(385, 54);
            this.TableLayout_Search.TabIndex = 9;
            // 
            // Search_Button
            // 
            this.Search_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(41, 7);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(110, 40);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Найти!";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Clarify_Button
            // 
            this.Clarify_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clarify_Button.Enabled = false;
            this.Clarify_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clarify_Button.Location = new System.Drawing.Point(233, 7);
            this.Clarify_Button.Name = "Clarify_Button";
            this.Clarify_Button.Size = new System.Drawing.Size(110, 40);
            this.Clarify_Button.TabIndex = 2;
            this.Clarify_Button.Text = "Уточнить";
            this.Clarify_Button.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 284);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 242);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FindControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayout_Main);
            this.Name = "FindControl";
            this.Size = new System.Drawing.Size(391, 529);
            this.TableLayout_Main.ResumeLayout(false);
            this.TableLayout_Main.PerformLayout();
            this.SearchOption_GroupBox.ResumeLayout(false);
            this.SearchOption_GroupBox.PerformLayout();
            this.TableLayout_Save.ResumeLayout(false);
            this.TableLayout_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout_Main;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.GroupBox SearchOption_GroupBox;
        private System.Windows.Forms.CheckBox Case_CheckBox;
        private System.Windows.Forms.CheckBox Reverse_CheckBox;
        private System.Windows.Forms.CheckBox SearchOrder_CheckBox;
        private System.Windows.Forms.TableLayoutPanel TableLayout_Save;
        private System.Windows.Forms.Button SaveSheet_Button;
        private System.Windows.Forms.Button SaveBook_Button;
        private System.Windows.Forms.TableLayoutPanel TableLayout_Search;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Clarify_Button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}
