using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using Telerik.Windows.Controls;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadGridViewTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Button method for exporting the RadGridView Grid to xlsx file type
        protected void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string extension = "xlsx";
            SaveFileDialog dialog = new SaveFileDialog()
            {
                DefaultExt = extension,
                Filter = String.Format("{1} files (.{0})|.{0}|All files (.)|.", extension, "Excel"),
                FilterIndex = 1
            };
            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    //ExportToXlsx extension method allows exporting the RadGridView to XLSX File
                    manualGridView.ExportToXlsx(stream, new GridViewDocumentExportOptions()
                    {
                        ShowColumnFooters = true,
                        ShowGroupFooters = true,
                        ShowColumnHeaders = true,
                        //RadGridView can be exported with its default styles by setting the ExportDefaultStyles property to TRUE
                        ExportDefaultStyles = true,
                    });
                    
                }
            }
        }
    }
}
