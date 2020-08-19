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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchOption_GroupBox = new System.Windows.Forms.GroupBox();
            this.SMTH_CheckBox = new System.Windows.Forms.CheckBox();
            this.CaseCheckBox = new System.Windows.Forms.CheckBox();
            this.WorkbookCheckBox = new System.Windows.Forms.CheckBox();
            this.TableLayout_Save = new System.Windows.Forms.TableLayoutPanel();
            this.SaveSheetButton = new System.Windows.Forms.Button();
            this.SaveBookButton = new System.Windows.Forms.Button();
            this.TableLayout_Search = new System.Windows.Forms.TableLayoutPanel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.ClarifyButton = new System.Windows.Forms.Button();
            this.CellsListBox = new System.Windows.Forms.ListBox();
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
            this.TableLayout_Main.Controls.Add(this.SearchTextBox, 0, 0);
            this.TableLayout_Main.Controls.Add(this.SearchOption_GroupBox, 0, 2);
            this.TableLayout_Main.Controls.Add(this.TableLayout_Save, 0, 3);
            this.TableLayout_Main.Controls.Add(this.TableLayout_Search, 0, 1);
            this.TableLayout_Main.Controls.Add(this.CellsListBox, 0, 4);
            this.TableLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.TableLayout_Main.Margin = new System.Windows.Forms.Padding(6);
            this.TableLayout_Main.Name = "TableLayout_Main";
            this.TableLayout_Main.RowCount = 5;
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TableLayout_Main.Size = new System.Drawing.Size(782, 1017);
            this.TableLayout_Main.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(6, 6);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(770, 44);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_TextBox_KeyPress);
            // 
            // SearchOption_GroupBox
            // 
            this.SearchOption_GroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchOption_GroupBox.Controls.Add(this.SMTH_CheckBox);
            this.SearchOption_GroupBox.Controls.Add(this.CaseCheckBox);
            this.SearchOption_GroupBox.Controls.Add(this.WorkbookCheckBox);
            this.SearchOption_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchOption_GroupBox.Location = new System.Drawing.Point(209, 177);
            this.SearchOption_GroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchOption_GroupBox.Name = "SearchOption_GroupBox";
            this.SearchOption_GroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.SearchOption_GroupBox.Size = new System.Drawing.Size(364, 237);
            this.SearchOption_GroupBox.TabIndex = 6;
            this.SearchOption_GroupBox.TabStop = false;
            this.SearchOption_GroupBox.Text = "Параметры поиска";
            // 
            // SMTH_CheckBox
            // 
            this.SMTH_CheckBox.AutoSize = true;
            this.SMTH_CheckBox.Location = new System.Drawing.Point(12, 173);
            this.SMTH_CheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.SMTH_CheckBox.Name = "SMTH_CheckBox";
            this.SMTH_CheckBox.Size = new System.Drawing.Size(275, 34);
            this.SMTH_CheckBox.TabIndex = 4;
            this.SMTH_CheckBox.TabStop = false;
            this.SMTH_CheckBox.Text = "Учитывать регистр";
            this.SMTH_CheckBox.UseVisualStyleBackColor = true;
            // 
            // CaseCheckBox
            // 
            this.CaseCheckBox.AutoSize = true;
            this.CaseCheckBox.Location = new System.Drawing.Point(12, 92);
            this.CaseCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.CaseCheckBox.Name = "CaseCheckBox";
            this.CaseCheckBox.Size = new System.Drawing.Size(275, 34);
            this.CaseCheckBox.TabIndex = 3;
            this.CaseCheckBox.TabStop = false;
            this.CaseCheckBox.Text = "Учитывать регистр";
            this.CaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // WorkbookCheckBox
            // 
            this.WorkbookCheckBox.AutoSize = true;
            this.WorkbookCheckBox.Location = new System.Drawing.Point(12, 42);
            this.WorkbookCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.WorkbookCheckBox.Name = "WorkbookCheckBox";
            this.WorkbookCheckBox.Size = new System.Drawing.Size(327, 34);
            this.WorkbookCheckBox.TabIndex = 2;
            this.WorkbookCheckBox.TabStop = false;
            this.WorkbookCheckBox.Text = "Искать по всем листам";
            this.WorkbookCheckBox.UseVisualStyleBackColor = true;
            // 
            // TableLayout_Save
            // 
            this.TableLayout_Save.ColumnCount = 2;
            this.TableLayout_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.Controls.Add(this.SaveSheetButton, 0, 0);
            this.TableLayout_Save.Controls.Add(this.SaveBookButton, 1, 0);
            this.TableLayout_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Save.Location = new System.Drawing.Point(6, 426);
            this.TableLayout_Save.Margin = new System.Windows.Forms.Padding(6);
            this.TableLayout_Save.Name = "TableLayout_Save";
            this.TableLayout_Save.RowCount = 1;
            this.TableLayout_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.Size = new System.Drawing.Size(770, 103);
            this.TableLayout_Save.TabIndex = 7;
            // 
            // SaveSheet_Button
            // 
            this.SaveSheetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveSheetButton.Enabled = false;
            this.SaveSheetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSheetButton.Location = new System.Drawing.Point(82, 13);
            this.SaveSheetButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveSheetButton.Name = "SaveSheet_Button";
            this.SaveSheetButton.Size = new System.Drawing.Size(220, 77);
            this.SaveSheetButton.TabIndex = 3;
            this.SaveSheetButton.Text = "Сохранить как\r\nлист";
            this.SaveSheetButton.UseVisualStyleBackColor = true;
            // 
            // SaveBook_Button
            // 
            this.SaveBookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBookButton.Enabled = false;
            this.SaveBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBookButton.Location = new System.Drawing.Point(466, 13);
            this.SaveBookButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveBookButton.Name = "SaveBook_Button";
            this.SaveBookButton.Size = new System.Drawing.Size(222, 77);
            this.SaveBookButton.TabIndex = 4;
            this.SaveBookButton.Text = "Сохранить как\r\nкнигу";
            this.SaveBookButton.UseVisualStyleBackColor = true;
            // 
            // TableLayout_Search
            // 
            this.TableLayout_Search.ColumnCount = 2;
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.Controls.Add(this.Search_Button, 0, 0);
            this.TableLayout_Search.Controls.Add(this.ClarifyButton, 1, 0);
            this.TableLayout_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Search.Location = new System.Drawing.Point(6, 62);
            this.TableLayout_Search.Margin = new System.Windows.Forms.Padding(6);
            this.TableLayout_Search.Name = "TableLayout_Search";
            this.TableLayout_Search.RowCount = 1;
            this.TableLayout_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.Size = new System.Drawing.Size(770, 103);
            this.TableLayout_Search.TabIndex = 9;
            // 
            // Search_Button
            // 
            this.Search_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(82, 13);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(220, 77);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Найти!";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Clarify_Button
            // 
            this.ClarifyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClarifyButton.Enabled = false;
            this.ClarifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClarifyButton.Location = new System.Drawing.Point(467, 13);
            this.ClarifyButton.Margin = new System.Windows.Forms.Padding(6);
            this.ClarifyButton.Name = "Clarify_Button";
            this.ClarifyButton.Size = new System.Drawing.Size(220, 77);
            this.ClarifyButton.TabIndex = 2;
            this.ClarifyButton.Text = "Уточнить";
            this.ClarifyButton.UseVisualStyleBackColor = true;
            this.ClarifyButton.Click += new System.EventHandler(this.Clarify_Button_Click);
            // 
            // CellsListBox
            // 
            this.CellsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellsListBox.FormattingEnabled = true;
            this.CellsListBox.ItemHeight = 25;
            this.CellsListBox.Location = new System.Drawing.Point(6, 541);
            this.CellsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.CellsListBox.Name = "CellsListBox";
            this.CellsListBox.Size = new System.Drawing.Size(770, 470);
            this.CellsListBox.TabIndex = 10;
            // 
            // FindControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayout_Main);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FindControl";
            this.Size = new System.Drawing.Size(782, 1017);
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
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox SearchOption_GroupBox;
        private System.Windows.Forms.CheckBox SMTH_CheckBox;
        private System.Windows.Forms.CheckBox CaseCheckBox;
        private System.Windows.Forms.CheckBox WorkbookCheckBox;
        private System.Windows.Forms.TableLayoutPanel TableLayout_Save;
        private System.Windows.Forms.Button SaveSheetButton;
        private System.Windows.Forms.Button SaveBookButton;
        private System.Windows.Forms.TableLayoutPanel TableLayout_Search;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button ClarifyButton;
        private System.Windows.Forms.ListBox CellsListBox;
    }
}
