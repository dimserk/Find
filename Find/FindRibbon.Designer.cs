namespace Find
{
    partial class FindRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FindRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.FindPane_ToggleButton = this.Factory.CreateRibbonToggleButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.ToggleButtonCell = this.Factory.CreateRibbonToggleButton();
            this.ToggleButtonRow = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Расширенный поиск";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.FindPane_ToggleButton);
            this.group1.Label = "Меню поиска";
            this.group1.Name = "group1";
            // 
            // FindPane_ToggleButton
            // 
            this.FindPane_ToggleButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.FindPane_ToggleButton.Image = global::Find.Properties.Resources.Icon_Find;
            this.FindPane_ToggleButton.Label = "Показать вкладку поиска";
            this.FindPane_ToggleButton.Name = "FindPane_ToggleButton";
            this.FindPane_ToggleButton.ShowImage = true;
            this.FindPane_ToggleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FindPane_ToggleButton_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.ToggleButtonCell);
            this.group2.Items.Add(this.ToggleButtonRow);
            this.group2.Label = "Параметры поиска";
            this.group2.Name = "group2";
            // 
            // ToggleButtonCell
            // 
            this.ToggleButtonCell.Checked = true;
            this.ToggleButtonCell.Label = "Поиск по ячейкам";
            this.ToggleButtonCell.Name = "ToggleButtonCell";
            this.ToggleButtonCell.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButtonCell_Click);
            // 
            // ToggleButtonRow
            // 
            this.ToggleButtonRow.Label = "Поиск по строкам";
            this.ToggleButtonRow.Name = "ToggleButtonRow";
            this.ToggleButtonRow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButtonRow_Click);
            // 
            // FindRibbon
            // 
            this.Name = "FindRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.FindRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton FindPane_ToggleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton ToggleButtonCell;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton ToggleButtonRow;
    }

    partial class ThisRibbonCollection
    {
        internal FindRibbon FindRibbon
        {
            get { return this.GetRibbon<FindRibbon>(); }
        }
    }
}
