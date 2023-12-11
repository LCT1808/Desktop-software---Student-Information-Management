using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management.Helpers
{
    class ExportData
    {
        public static void ExportToData(DataGridView dataGridView, List<string> columnHeaders)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV Files (.csv)|.csv|Excel Files (.xlsx)|.xlsx",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (Path.GetExtension(filePath).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                    {
                        ExportToExcelFile(dataGridView, columnHeaders, filePath);
                    }
                    else if (Path.GetExtension(filePath).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        ExportToCSVFile(dataGridView, columnHeaders, filePath);
                    }

                    MessageBox.Show("Export successful.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ExportToExcelFile(DataGridView dataGridView, List<string> columnHeaders, string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                int col = 1;
                foreach (var header in columnHeaders)
                {
                    worksheet.Cells[1, col].Value = header;
                    col++;
                }

                int row = 2;
                foreach (DataGridViewRow dataRow in dataGridView.Rows)
                {
                    col = 1;
                    foreach (var cellValue in GetRowData(dataRow, columnHeaders, dataGridView))
                    {
                        worksheet.Cells[row, col].Value = cellValue;
                        col++;
                    }
                    row++;
                }

                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }
        }

        private static void ExportToCSVFile(DataGridView dataGridView, List<string> columnHeaders, string filePath)
        {
            StringBuilder csvContent = new StringBuilder();

            csvContent.AppendLine(string.Join(",", columnHeaders));

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                csvContent.AppendLine(string.Join(",", GetRowData(row, columnHeaders, dataGridView)));
            }

            File.WriteAllText(filePath, csvContent.ToString());
        }

        private static List<string> GetRowData(DataGridViewRow row, List<string> columnHeaders, DataGridView dataGridView)
        {
            List<string> rowData = new List<string>();

            foreach (var header in columnHeaders)
            {
                var columnIndex = dataGridView.Columns[header].Index;
                var cellValue = row.Cells[columnIndex].Value;

                if (cellValue is DateTime)
                {
                    cellValue = ((DateTime)cellValue).ToString("dd/MM/yyyy");
                }

                rowData.Add(cellValue?.ToString() ?? "");
            }

            return rowData;
        }
    }
}
