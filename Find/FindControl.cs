using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Find
{
    public partial class FindControl : UserControl
    {
        private Workbook ActiveWorkbook => Globals.ThisAddIn.Application.ActiveWorkbook;
        private Worksheet ActiveWorksheet => Globals.ThisAddIn.Application.ActiveSheet;

        private List<Range> SearchResultRanges;
        private BindingList<RangeView> SearchResultList;

        private Searcher Searcher;

        public FindControl()
        {
            InitializeComponent();

            this.SearchResultRanges = new List<Range>();
            this.SearchResultList = new BindingList<RangeView>();
            this.Searcher = new Searcher();

            this.SearchResultDataGridView.DataSource = this.SearchResultList;

            this.SearchResultDataGridView.SelectionChanged += Select_Cell;
            this.CaseCheckBox.CheckedChanged += Search_Option_Changed;
            this.SearchCheckBox.CheckedChanged += Disable_Workbook_Search;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchTextBox.Text))
            {
                if (SearchCheckBox.Checked)
                {
                    List<Range> searchResultRangesCopy = new List<Range>();
                    foreach (var range in this.SearchResultRanges)
                    {
                        searchResultRangesCopy.Add(range);
                    }

                    this.SearchResultRanges.Clear();
                    this.SearchResultList.Clear();

                    foreach (var range in searchResultRangesCopy)
                    {
                        Searcher.SearchInRange(SearchTextBox.Text, range, ref SearchResultRanges, ref SearchResultList);
                    }
                }
                else
                {
                    this.SearchResultRanges.Clear();
                    this.SearchResultList.Clear();

                    if (this.WorkbookCheckBox.Checked)
                    {
                        foreach (Worksheet worksheet in ActiveWorkbook.Worksheets)
                        {
                            Searcher.SearchInRange(SearchTextBox.Text, worksheet.UsedRange, ref SearchResultRanges, ref SearchResultList);
                        }
                    }
                    else
                    {
                        Searcher.SearchInRange(SearchTextBox.Text, ActiveWorksheet.UsedRange, ref SearchResultRanges, ref SearchResultList);
                    }
                }
            }
            else
            {
                return;
            }

            Buttons_Status_Sub_Proc();
        }

        private void Search_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;

            if (e.KeyChar == (char)Keys.Enter)
            {
                Search_Button_Click(sender, e);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.SearchTextBox.Text = String.Empty;
            this.SearchResultRanges.Clear();
            this.SearchResultList.Clear();

            Buttons_Status_Sub_Proc();
        }

        private void Buttons_Status_Sub_Proc()
        {
            if (this.SearchResultList.Count != 0)
            {
                this.SaveBookButton.Enabled = true;
                this.SaveSheetButton.Enabled = true;
            }
            else
            {
                this.SaveBookButton.Enabled = false;
                this.SaveSheetButton.Enabled = false;
            }
        }

        private void SaveSheetButton_Click(object sender, EventArgs e)
        {
            Saver.SaveAsWorksheet("Результат поиска", ActiveWorkbook, this.SearchResultList);
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            string workbookName = "";
            string selectedPath = "";

            Saver.SaveAsWorkbook(workbookName, ActiveWorkbook, selectedPath, this.SearchResultRanges);
        }

        private void Select_Cell(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.SearchResultDataGridView.SelectedRows)
            {
                var view = (RangeView)row.DataBoundItem;
                view.FoundRange.Worksheet.Activate();
                view.FoundRange.Activate();
            }
        }

        private void Search_Option_Changed(object sender, EventArgs e)
        {
            this.Searcher.CaseFlag = this.CaseCheckBox.Checked;
        }

        private void Disable_Workbook_Search(object sender, EventArgs e)
        {
            if (this.SearchCheckBox.Checked)
            {
                this.WorkbookCheckBox.Enabled = false;
            }
            else
            {
                this.WorkbookCheckBox.Enabled = true;
            }
        }
    }
}
