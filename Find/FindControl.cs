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
        // Сокращения в форме методов
        private Workbook ActiveWorkbook => Globals.ThisAddIn.Application.ActiveWorkbook;
        private Workbook Workbooks => (Workbook)Globals.ThisAddIn.Application.Workbooks;
        private Worksheet ActiveWorksheet => Globals.ThisAddIn.Application.ActiveSheet;

        private List<Range> SearchResultRanges; // Список найденных ячеек для кажого листа книги
                                                //  (0 элемен - список ячеек найденных на первом листе и тд)
                                                //  если на листе небыло найдено ячеек, в список заносится null
                                                
        private BindingList<RangeView> SearchResultList; // Списк представлений найденных ячеек для таблицы во вкладке

        private Searcher Searcher; // Класс, реализующий поиск
        private Saver Saver;

        public FindControl()
        {
            InitializeComponent();

            this.SearchResultRanges = new List<Range>();
            this.SearchResultList = new BindingList<RangeView>();
            this.Searcher = new Searcher();
            this.Saver = new Saver();

            // Привязка списка представлений к таблице
            this.SearchResultDataGridView.DataSource = this.SearchResultList;

            // Привязка обработчиков событий
            this.SearchResultDataGridView.SelectionChanged += Select_Cell;
            this.CaseCheckBox.CheckedChanged += Search_Option_Changed;
            this.RowSaveCheckBox.CheckedChanged += RowSave_Option_Changed;
            this.SearchCheckBox.CheckedChanged += Disable_Workbook_Search;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            // В случае когда в строку поиска введено что-то
            if (!String.IsNullOrEmpty(SearchTextBox.Text))
            {
                // Обработка флага поиска в поиске
                if (SearchCheckBox.Checked)
                {
                    // Поиск в поиске

                    // Полное копирование результата поиска во временное хранилище
                    List<Range> searchResultRangesCopy = new List<Range>();
                    foreach (var range in this.SearchResultRanges)
                    {
                        searchResultRangesCopy.Add(range);
                    }

                    this.SearchResultRanges.Clear();
                    this.SearchResultList.Clear();

                    // Для каждого листа ищем в найденных на нём ячейках
                    foreach (var range in searchResultRangesCopy)
                    {
                        Searcher.SearchInRange(SearchTextBox.Text, range, ref SearchResultRanges, ref SearchResultList);
                    }
                }
                else
                {
                    // Поиск в документе Excel

                    this.SearchResultRanges.Clear();
                    this.SearchResultList.Clear();

                    // Обработка флага поиска по всей книге
                    if (this.WorkbookCheckBox.Checked)
                    {
                        // Поиск по всей книге

                        foreach (Worksheet worksheet in ActiveWorkbook.Worksheets)
                        {
                            Searcher.SearchInRange(SearchTextBox.Text, worksheet.UsedRange, ref SearchResultRanges, ref SearchResultList);
                        }
                    }
                    else
                    {
                        // Поиск на текущем листе

                        Searcher.SearchInRange(SearchTextBox.Text, ActiveWorksheet.UsedRange, ref SearchResultRanges, ref SearchResultList);
                    }
                }
            }
            else
            {
                // Если в строку поиска ничего не было введено

                return;
            }

            // Обновление статуса кнопок вкладки
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
            // Очистка всех буфферов
            this.SearchTextBox.Text = String.Empty;
            this.SearchResultRanges.Clear();
            this.SearchResultList.Clear();

            // Обновление статуса кнопок
            Buttons_Status_Sub_Proc();
        }
       
        // Подметод для обновления статуса кнопок
        private void Buttons_Status_Sub_Proc()
        {
            // В зависимости от наличия содержимого таблицы
            if (this.SearchResultList.Count != 0)
            {
                // Разрешаем сохранение
                this.SaveBookButton.Enabled = true;
                this.SaveSheetButton.Enabled = true;
            }
            else
            {
                // Запрещаем сохранение
                this.SaveBookButton.Enabled = false;
                this.SaveSheetButton.Enabled = false;
            }
        }

        private void SaveSheetButton_Click(object sender, EventArgs e)
        {
            this.Saver.SaveAsWorksheet(this.SearchResultList.ToList());
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            this.Saver.SaveAsWorkbook(this.SearchResultList.ToList());
        }

        // Подметод для выделения выбранной в таблице ячейки в самом документе
        private void Select_Cell(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.SearchResultDataGridView.SelectedRows)
            {
                var view = (RangeView)row.DataBoundItem;
                view.FoundRange.Worksheet.Activate();
                view.FoundRange.Activate();
            }
        }

        // Подметод для синхронизации флага учёта регистра
        private void Search_Option_Changed(object sender, EventArgs e)
        {
            this.Searcher.CaseFlag = this.CaseCheckBox.Checked;
        }

        private void RowSave_Option_Changed(object sender, EventArgs e)
        {
            this.Saver.rowSave = this.RowSaveCheckBox.Checked;
        }

        // Подметод для игнорирования поиска по всей книге в случае, когда выбран поиск по поиску
        private void Disable_Workbook_Search(object sender, EventArgs e)
        {
            if (this.SearchCheckBox.Checked)
            {
                // Если произодиться поиск в поиске,
                //  то игнорируем поиск по книге

                this.WorkbookCheckBox.Enabled = false;
            }
            else
            {
                // Если произодиться поиск в документе,
                //  то включаем поиск по книге

                this.WorkbookCheckBox.Enabled = true;
            }
        }
    }
}
