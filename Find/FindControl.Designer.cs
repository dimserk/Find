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
            this.TableLayout_Option = new System.Windows.Forms.TableLayoutPanel();
            this.WorkbookCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchCheckBox = new System.Windows.Forms.CheckBox();
            this.CaseCheckBox = new System.Windows.Forms.CheckBox();
            this.TableLayout_Search = new System.Windows.Forms.TableLayoutPanel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayout_Save = new System.Windows.Forms.TableLayoutPanel();
            this.SaveBookButton = new System.Windows.Forms.Button();
            this.SaveSheetButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TableLayout_Main.SuspendLayout();
            this.SearchOption_GroupBox.SuspendLayout();
            this.TableLayout_Option.SuspendLayout();
            this.TableLayout_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).BeginInit();
            this.TableLayout_Save.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout_Main
            // 
            this.TableLayout_Main.ColumnCount = 1;
            this.TableLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout_Main.Controls.Add(this.SearchTextBox, 0, 0);
            this.TableLayout_Main.Controls.Add(this.SearchOption_GroupBox, 0, 2);
            this.TableLayout_Main.Controls.Add(this.TableLayout_Search, 0, 1);
            this.TableLayout_Main.Controls.Add(this.SearchResultDataGridView, 0, 3);
            this.TableLayout_Main.Controls.Add(this.TableLayout_Save, 0, 4);
            this.TableLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.TableLayout_Main.Name = "TableLayout_Main";
            this.TableLayout_Main.RowCount = 5;
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11086F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.21939F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.55888F));
            this.TableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11086F));
            this.TableLayout_Main.Size = new System.Drawing.Size(391, 529);
            this.TableLayout_Main.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(385, 23);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_TextBox_KeyPress);
            // 
            // SearchOption_GroupBox
            // 
            this.SearchOption_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchOption_GroupBox.Controls.Add(this.TableLayout_Option);
            this.SearchOption_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchOption_GroupBox.Location = new System.Drawing.Point(3, 87);
            this.SearchOption_GroupBox.Name = "SearchOption_GroupBox";
            this.SearchOption_GroupBox.Size = new System.Drawing.Size(385, 130);
            this.SearchOption_GroupBox.TabIndex = 6;
            this.SearchOption_GroupBox.TabStop = false;
            this.SearchOption_GroupBox.Text = "Параметры поиска";
            // 
            // TableLayout_Option
            // 
            this.TableLayout_Option.ColumnCount = 1;
            this.TableLayout_Option.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout_Option.Controls.Add(this.WorkbookCheckBox, 0, 0);
            this.TableLayout_Option.Controls.Add(this.SearchCheckBox, 0, 1);
            this.TableLayout_Option.Controls.Add(this.CaseCheckBox, 0, 2);
            this.TableLayout_Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Option.Location = new System.Drawing.Point(3, 18);
            this.TableLayout_Option.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayout_Option.Name = "TableLayout_Option";
            this.TableLayout_Option.RowCount = 3;
            this.TableLayout_Option.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout_Option.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout_Option.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout_Option.Size = new System.Drawing.Size(379, 109);
            this.TableLayout_Option.TabIndex = 0;
            // 
            // WorkbookCheckBox
            // 
            this.WorkbookCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WorkbookCheckBox.Location = new System.Drawing.Point(5, 2);
            this.WorkbookCheckBox.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.WorkbookCheckBox.Name = "WorkbookCheckBox";
            this.WorkbookCheckBox.Size = new System.Drawing.Size(173, 32);
            this.WorkbookCheckBox.TabIndex = 1;
            this.WorkbookCheckBox.Text = "Искать по всем листам";
            this.WorkbookCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchCheckBox
            // 
            this.SearchCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchCheckBox.Location = new System.Drawing.Point(5, 38);
            this.SearchCheckBox.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.SearchCheckBox.Name = "SearchCheckBox";
            this.SearchCheckBox.Size = new System.Drawing.Size(172, 32);
            this.SearchCheckBox.TabIndex = 2;
            this.SearchCheckBox.Text = "Искать по поиску";
            this.SearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // CaseCheckBox
            // 
            this.CaseCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CaseCheckBox.Location = new System.Drawing.Point(5, 74);
            this.CaseCheckBox.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.CaseCheckBox.Name = "CaseCheckBox";
            this.CaseCheckBox.Size = new System.Drawing.Size(172, 33);
            this.CaseCheckBox.TabIndex = 0;
            this.CaseCheckBox.Text = "Учитывать регистр";
            this.CaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // TableLayout_Search
            // 
            this.TableLayout_Search.ColumnCount = 2;
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TableLayout_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TableLayout_Search.Controls.Add(this.Search_Button, 0, 0);
            this.TableLayout_Search.Controls.Add(this.ClearButton, 1, 0);
            this.TableLayout_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Search.Location = new System.Drawing.Point(3, 32);
            this.TableLayout_Search.Name = "TableLayout_Search";
            this.TableLayout_Search.RowCount = 1;
            this.TableLayout_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout_Search.Size = new System.Drawing.Size(385, 49);
            this.TableLayout_Search.TabIndex = 9;
            // 
            // Search_Button
            // 
            this.Search_Button.AutoSize = true;
            this.Search_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(5, 5);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(182, 39);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Найти!";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Location = new System.Drawing.Point(197, 5);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(183, 39);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Очистить поиск";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchResultDataGridView
            // 
            this.SearchResultDataGridView.AllowUserToAddRows = false;
            this.SearchResultDataGridView.AllowUserToDeleteRows = false;
            this.SearchResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchResultDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SearchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.SearchResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultDataGridView.Location = new System.Drawing.Point(2, 222);
            this.SearchResultDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SearchResultDataGridView.Name = "SearchResultDataGridView";
            this.SearchResultDataGridView.ReadOnly = true;
            this.SearchResultDataGridView.RowHeadersVisible = false;
            this.SearchResultDataGridView.RowHeadersWidth = 82;
            this.SearchResultDataGridView.RowTemplate.Height = 33;
            this.SearchResultDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SearchResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResultDataGridView.Size = new System.Drawing.Size(387, 248);
            this.SearchResultDataGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SheetName";
            this.Column1.HeaderText = "Лист";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CellAddress";
            this.Column2.HeaderText = "Ячейка";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Text";
            this.Column3.HeaderText = "Текст";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // TableLayout_Save
            // 
            this.TableLayout_Save.ColumnCount = 2;
            this.TableLayout_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout_Save.Controls.Add(this.SaveBookButton, 1, 0);
            this.TableLayout_Save.Controls.Add(this.SaveSheetButton, 0, 0);
            this.TableLayout_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout_Save.Location = new System.Drawing.Point(2, 474);
            this.TableLayout_Save.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayout_Save.Name = "TableLayout_Save";
            this.TableLayout_Save.RowCount = 1;
            this.TableLayout_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout_Save.Size = new System.Drawing.Size(387, 53);
            this.TableLayout_Save.TabIndex = 11;
            // 
            // SaveBookButton
            // 
            this.SaveBookButton.AutoSize = true;
            this.SaveBookButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBookButton.Enabled = false;
            this.SaveBookButton.Location = new System.Drawing.Point(198, 5);
            this.SaveBookButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveBookButton.Name = "SaveBookButton";
            this.SaveBookButton.Size = new System.Drawing.Size(184, 43);
            this.SaveBookButton.TabIndex = 0;
            this.SaveBookButton.Text = "Сохранить как\r\nновая книга";
            this.SaveBookButton.UseVisualStyleBackColor = true;
            this.SaveBookButton.Click += new System.EventHandler(this.SaveBookButton_Click);
            // 
            // SaveSheetButton
            // 
            this.SaveSheetButton.AutoSize = true;
            this.SaveSheetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveSheetButton.Enabled = false;
            this.SaveSheetButton.Location = new System.Drawing.Point(5, 5);
            this.SaveSheetButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveSheetButton.Name = "SaveSheetButton";
            this.SaveSheetButton.Size = new System.Drawing.Size(183, 43);
            this.SaveSheetButton.TabIndex = 1;
            this.SaveSheetButton.Text = "Сохранить как\r\nновый лист";
            this.SaveSheetButton.UseVisualStyleBackColor = true;
            this.SaveSheetButton.Click += new System.EventHandler(this.SaveSheetButton_Click);
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
            this.TableLayout_Option.ResumeLayout(false);
            this.TableLayout_Search.ResumeLayout(false);
            this.TableLayout_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).EndInit();
            this.TableLayout_Save.ResumeLayout(false);
            this.TableLayout_Save.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout_Main;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox SearchOption_GroupBox;
        private System.Windows.Forms.TableLayoutPanel TableLayout_Search;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TableLayoutPanel TableLayout_Option;
        private System.Windows.Forms.CheckBox CaseCheckBox;
        private System.Windows.Forms.CheckBox WorkbookCheckBox;
        private System.Windows.Forms.CheckBox SearchCheckBox;
        private System.Windows.Forms.DataGridView SearchResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TableLayoutPanel TableLayout_Save;
        private System.Windows.Forms.Button SaveBookButton;
        private System.Windows.Forms.Button SaveSheetButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}
