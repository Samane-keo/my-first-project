using System;
using System.Windows.Forms;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;


namespace AccessData
{
    public class clsExportFile
    {
        public bool exportDataToExcel_pro(DataTable dt)
        {
            bool result = false;
            //khoi tao cac doi tuong Com Excel de lam viec
            Excel.Application xlApp;
            Excel.Worksheet xlSheet;
            Excel.Workbook xlBook;
            //doi tuong Trống để thêm  vào xlApp sau đó lưu lại sau
            object missValue = System.Reflection.Missing.Value;
            //khoi tao doi tuong Com Excel moi
            xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Add(missValue);
            //su dung Sheet dau tien de thao tac
            xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
            //không cho hiện ứng dụng Excel lên để tránh gây đơ máy
            xlApp.Visible = false;
            int socot = dt.Columns.Count;
            int sohang = dt.Rows.Count;
            int i, j;

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {
                //set thuoc tinh cho cac header
                Excel.Range header = xlSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
                header.Select();
                header.Interior.ColorIndex = 50;
                

                header.HorizontalAlignment = Excel.Constants.xlCenter;
                header.Font.Bold = true;
                header.Font.Size = 10;
                //điền tiêu đề cho các cột trong file excel
                xlSheet.Cells[1,1] = "TÊN KH";
                xlSheet.Cells[1,2] = "SỐ LSX";
                xlSheet.Cells[1,3] = "MÃ SP";
                xlSheet.Cells[1,4] = "MÀU";
                xlSheet.Cells[1,5] = "SỐ LƯỢNG";
                xlSheet.Cells[1,6] = "TUẦN";
                xlSheet.Cells[1,7] = "NGÀY ĐPSX";
                xlSheet.Cells[1,8] = "NGÀY DỰ PHÒNG";
                xlSheet.Cells[1,9] = "NGÀY TN";
                xlSheet.Cells[1,10] = "LOẠI KH";
                xlSheet.Cells[1,11] = "CHUYỀN SX";
                xlSheet.Cells[1,12] = "NHÓM SP";
                xlSheet.Cells[1,13] = "QUY TRÌNH SP";
                xlSheet.Cells[1,14] = "CHỦNG LOẠI SP";
                xlSheet.Cells[1,15] = "LAST HC";
                xlSheet.Cells[1,16] = "ĐẾ";
                xlSheet.Cells[1,17] = "ĐM MAY";
                xlSheet.Cells[1,18] = "SỐ SO";
                xlSheet.Cells[1,19] = "GHI CHÚ";
                xlSheet.Cells[1,20] = "NGUỒN HÀNG";
                xlSheet.Cells[1,21] = "TGSX";
                xlSheet.Cells[1,22] = "TUẦN THỰC HIỆN_HC";
                xlSheet.Cells[1,23] = "XƯỞNG THỰC HIỆN HOÀN CHỈNH";
                xlSheet.Cells[1,24] = "NHÀ MÁY HOÀN CHỈNH";
                xlSheet.Cells[1,25] = "TUẦN THỰC HIỆN_CB ĐẾ";
                xlSheet.Cells[1,26] = "NHÀ MÁY CHUẨN BỊ ĐẾ";
                xlSheet.Cells[1,27] = "TUẦN THỰC HIỆN_MAY";
                xlSheet.Cells[1,28] = "NHÀ MÁY MAY";
                xlSheet.Cells[1,29] = "TUẦN THỰC HIỆN_B.HÌNH ĐẾ";
                xlSheet.Cells[1,30] = "NHÀ MÁY BẾ HÌNH ĐẾ";
                xlSheet.Cells[1,31] = "TUẦN THỰC HIỆN_B.HÌNH QUAI";
                xlSheet.Cells[1,32] = "NHÀ MÁY BẾ HÌNH QUAI";
                xlSheet.Cells[1,33] = "TUẦN THỰC HIỆN_IN LỤA ĐẾ";
                xlSheet.Cells[1,34] = "NHÀ MÁY IN LỤA ĐẾ";
                xlSheet.Cells[1,35] = "TUẦN THỰC HIỆN_IN LỤA QUAI";
                xlSheet.Cells[1,36] = "NHÀ MÁY IN LỤA QUAI";
                xlSheet.Cells[1,37] = "TUẦN THỰC HIỆN_DĐẾ";
                xlSheet.Cells[1,38] = "NHÀ MÁY DẬP ĐẾ";
                xlSheet.Cells[1,39] = "TUẦN THỰC HIỆN_DDA";
                xlSheet.Cells[1,40] = "NHÀ MÁY DẬP DA";
                xlSheet.Cells[1,41] = "TUẦN THỰC HIỆN_DLÓT";    
                xlSheet.Cells[1,42] = "NHÀ MÁY DẬP LÓT";
                xlSheet.Cells[1,43] = "TUẦN THỰC HIỆN_CDAN";
                xlSheet.Cells[1,44] = "NHÀ MÁY CÁN DÁN";
                //for (i = 0; i < socot; i++)
                //    xlSheet.Cells[2, i + 2] = dt.Columns[i].ColumnName;
                //dien cot stt

                //xlSheet.Cells[2, 1] = "STT";
                //for (i = 0; i < sohang; i++)
                //    xlSheet.Cells[i + 3, 1] = i + 1;


                //dien du lieu vao sheet
                for (i = 0; i < sohang; i++)
                {
                    for (j = 0; j < socot; j++)
                    {
                        if(dt.Rows[i][j].ToString() != "")
                        {
                            xlSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                        }
                        else
                        {
                            xlSheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                    
                //autofit độ rộng cho các cột 
                xlSheet.Columns.AutoFit();
                //Boder cho tat ca
                Excel.Range sheet_border = xlSheet.get_Range("A1", "AT" + Convert.ToString(sohang + 1));
                sheet_border.Cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //save file
                xlBook.SaveAs(f.FileName, Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
                xlBook.Close(true, missValue, missValue);
                xlApp.Quit();

                // release cac doi tuong COM
                releaseObject(xlSheet);
                releaseObject(xlBook);
                releaseObject(xlApp);
                result = true;
            }
            return result;
        }
        public bool exportDataToExcel(string tieude, DataTable dt)
        {
            bool result = false;
            //khoi tao cac doi tuong Com Excel de lam viec
            Excel.Application xlApp;
            Excel.Worksheet xlSheet;
            Excel.Workbook xlBook;
            //doi tuong Trống để thêm  vào xlApp sau đó lưu lại sau
            object missValue = System.Reflection.Missing.Value;
            //khoi tao doi tuong Com Excel moi
            xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Add(missValue);
            //su dung Sheet dau tien de thao tac
            xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
            //không cho hiện ứng dụng Excel lên để tránh gây đơ máy
            xlApp.Visible = false;
            int socot = dt.Columns.Count;
            int sohang = dt.Rows.Count;
            int i, j;

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {
                //set thuoc tinh cho tieu de
                xlSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1").Merge(false);
                Excel.Range caption = xlSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
                caption.Select();
                caption.FormulaR1C1 = tieude;
                //căn lề cho tiêu đề
                caption.HorizontalAlignment = Excel.Constants.xlCenter;
                caption.Font.Bold = true;
                caption.VerticalAlignment = Excel.Constants.xlCenter;
                caption.Font.Size = 15;
                //màu nền cho tiêu đề
                caption.Interior.ColorIndex = 20;
                caption.RowHeight = 30;
                //set thuoc tinh cho cac header
                Excel.Range header = xlSheet.get_Range("A2", Convert.ToChar(socot + 65) + "2");
                header.Select();


                header.HorizontalAlignment = Excel.Constants.xlCenter;
                header.Font.Bold = true;
                header.Font.Size = 10;
                //điền tiêu đề cho các cột trong file excel
                for (i = 0; i < socot; i++)
                    xlSheet.Cells[2, i + 2] = dt.Columns[i].ColumnName;
                //dien cot stt
                xlSheet.Cells[2, 1] = "STT";
                for (i = 0; i < sohang; i++)
                    xlSheet.Cells[i + 3, 1] = i + 1;
                //dien du lieu vao sheet


                for (i = 0; i < sohang; i++)
                {
                    for (j = 0; j < socot; j++)
                    {
                        xlSheet.Cells[i + 3, j + 2] = dt.Rows[i][j];

                    }
                }

                //autofit độ rộng cho các cột 

                xlSheet.get_Range("J", "K").NumberFormat = "0";
                for (i = 0; i < sohang; i++)
                    ((Excel.Range)xlSheet.Cells[1, i + 1]).EntireColumn.AutoFit();

                //save file
                xlBook.SaveAs(f.FileName, Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
                xlBook.Close(true, missValue, missValue);
                xlApp.Quit();

                // release cac doi tuong COM
                releaseObject(xlSheet);
                releaseObject(xlBook);
                releaseObject(xlApp);
                result = true;
            }
            return result;
        }
        public bool exportDataToExcel_get(DataTable dt)
        {
            bool result = false;
            //khoi tao cac doi tuong Com Excel de lam viec
            Excel.Application xlApp;
            Excel.Worksheet xlSheet;
            Excel.Workbook xlBook;
            //doi tuong Trống để thêm  vào xlApp sau đó lưu lại sau
            object missValue = System.Reflection.Missing.Value;
            //khoi tao doi tuong Com Excel moi
            xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Add(missValue);
            //su dung Sheet dau tien de thao tac
            xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
            //không cho hiện ứng dụng Excel lên để tránh gây đơ máy
            xlApp.Visible = false;
            int socot = dt.Columns.Count;
            int sohang = dt.Rows.Count;
            int i, j;

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {
                for (i = 0; i < sohang; i++)
                {
                    for (j = 0; j < socot; j++)
                    {
                        xlSheet.Cells[i + 1, j + 1] = dt.Rows[i][j];

                    }
                }

                //autofit độ rộng cho các cột 
                for (i = 0; i < sohang; i++)
                    ((Excel.Range)xlSheet.Cells[1, i + 1]).EntireColumn.AutoFit();

                //save file
                xlBook.SaveAs(f.FileName, Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
                xlBook.Close(true, missValue, missValue);
                xlApp.Quit();

                // release cac doi tuong COM
                releaseObject(xlSheet);
                releaseObject(xlBook);
                releaseObject(xlApp);
                result = true;
            }
            return result;
        }
        public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        public void ExportToExcel(DataTable dataTable, string ExcelFilePath)
        {
            try 
            {
                int ColumnsCount;

                if (dataTable == null || (ColumnsCount = dataTable.Columns.Count) == 0)
                throw new Exception("ExportToExcel: Null or empty input table!\n");

                // create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add(System.Reflection.Missing.Value);

                object misValue = System.Reflection.Missing.Value;

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = (Microsoft.Office.Interop.Excel._Worksheet)Excel.ActiveSheet;

                object[] Header = new object[ColumnsCount];
                // column headings
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = dataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value2 = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;
                // DataCells
                int RowsCount = dataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = dataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value2 = Cells;
                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                try
                {
                Worksheet.SaveAs(ExcelFilePath, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);

                Excel.Visible = true;
                }
                catch (Exception ex)
                {
                throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n" + ex.Message);
                }
                }
                else // no filepath is given
                {
                Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    }
}
