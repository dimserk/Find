using System;
using Microsoft.Office.Tools;

namespace Find
{
    public partial class ThisAddIn
    {
        private FindControl findControl;
        private CustomTaskPane customFindTaskPane;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            findControl = new FindControl();
            customFindTaskPane = this.CustomTaskPanes.Add(findControl, "Поиск");
            customFindTaskPane.Visible = true;
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
