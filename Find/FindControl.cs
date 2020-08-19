﻿using System;
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

            this.CellsListBox.DataSource = this.SearchResultList;

            this.CellsListBox.SelectedIndexChanged += Select_Cell;
            this.CaseCheckBox.CheckedChanged += Search_Option_Changed;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchTextBox.Text))
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

        private void Clarify_Button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchTextBox.Text))
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
                return;
            }

            Buttons_Status_Sub_Proc();
        }

        private void Buttons_Status_Sub_Proc()
        {
            if (this.SearchResultList.Count != 0)
            {
                this.SaveBookButton.Enabled = true;
                this.SaveSheetButton.Enabled = true;
                this.ClarifyButton.Enabled = true;
            }
            else
            {
                this.SaveBookButton.Enabled = false;
                this.SaveSheetButton.Enabled = false;
                this.ClarifyButton.Enabled = false;
            }
        }

        private void Select_Cell(object sender, EventArgs e)
        {
            if (this.CellsListBox.SelectedIndex != -1)
            {
                ((RangeView)CellsListBox.SelectedItem).FoundRange.Worksheet.Activate();
                ((RangeView)CellsListBox.SelectedItem).FoundRange.Activate();
            }
        }

        private void Search_Option_Changed(object sender, EventArgs e)
        {
            this.Searcher.CaseFlag = this.CaseCheckBox.Checked;
        }
    }
}
