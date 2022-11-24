using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClosedXML.Excel;
using ExcelDataReader;
using amogus.MVVM.View;
using amogus.MVVM.ViewModel;

namespace amogus.MVVM.Model
{
    class ExcelCalculationModel
    {
        public static string excelFilename = "";

        IExcelDataReader edr;

        public DataView ReadFile(string fileNames)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var extension = fileNames.Substring(fileNames.LastIndexOf('.'));
            FileStream stream = File.Open(fileNames, FileMode.Open, FileAccess.Read);
            
            if (extension == ".xlsx")
                edr = ExcelReaderFactory.CreateOpenXmlReader(stream);
            else if (extension == ".xls")
                edr = ExcelReaderFactory.CreateBinaryReader(stream);

            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    EmptyColumnNamePrefix = "Column",
                    UseHeaderRow = true
                }
            };
            DataSet dataSet = edr.AsDataSet(conf);
            DataView dtView = dataSet.Tables[0].AsDataView();

            edr.Close();
            return dtView;
        }

        public List<double> GetRusultOfCalculations()
        {
            List<double> result = new List<double>();

            if (Input.db == null)
            {
                return result;
            }

            DataTable? table = Input.db.ToTable();

            Int32 index = table.Rows.Count - 1;

            List<double> koef = new List<double>();

            koef.Add(Convert.ToDouble(RatioViewModel.koef1));
            koef.Add(Convert.ToDouble(RatioViewModel.koef2));
            koef.Add(Convert.ToDouble(RatioViewModel.koef3));
            koef.Add(Convert.ToDouble(RatioViewModel.koef4));
            koef.Add(Convert.ToDouble(RatioViewModel.koef5));
            koef.Add(Convert.ToDouble(RatioViewModel.koef6));
            koef.Add(Convert.ToDouble(RatioViewModel.koef7));

            List<double> numbers = new List<double>();
            double num;

            for (Int32 i = 0; i < index; i++)
            {
                for (Int32 j = Convert.ToInt32(DataExcelViewModel.text1) - 1; j <= Convert.ToInt32(DataExcelViewModel.text7) - 1; j++)
                {
                    if (table.Rows[i].ItemArray[j] == null && i > 2)
                        break;

                    if (!(table.Rows[i].ItemArray[j] is DBNull) && double.TryParse(Convert.ToString(table.Rows[i].ItemArray[j]), out num) == true)
                    {

                        if (j == Convert.ToInt32(DataExcelViewModel.text1) - 1)
                        {
                            numbers.Add(Convert.ToDouble(table.Rows[i].ItemArray[j]));
                        }
                        else if (j == Convert.ToInt32(DataExcelViewModel.text2) - 1)
                        {
                            numbers.Add(Convert.ToDouble(table.Rows[i].ItemArray[j]));
                        }
                        else if (j == Convert.ToInt32(DataExcelViewModel.text3) - 1)
                        {
                            numbers.Add(Convert.ToDouble(table.Rows[i].ItemArray[j]));
                        }
                        else if (j == Convert.ToInt32(DataExcelViewModel.text4) - 1)
                        {
                            numbers.Add(Convert.ToDouble(table.Rows[i].ItemArray[j]));
                        }
                        else if (j == Convert.ToInt32(DataExcelViewModel.text5) - 1)
                        {
                            numbers.Add(Convert.ToDouble(table.Rows[i].ItemArray[j]));
                        }
                        else if (j == Convert.ToInt32(DataExcelViewModel.text6) - 1)
                        {
                            numbers.Add(Convert.ToDouble(table.Rows[i].ItemArray[j]));
                        }
                        else if (j == Convert.ToInt32(DataExcelViewModel.text7) - 1)
                        {
                            numbers.Add(Convert.ToDouble(table.Rows[i].ItemArray[j]));
                        }
                    }
                }
                if (numbers.Any())
                {
                    result.Add(numbers[0] * koef[0] + numbers[1] * koef[1] + numbers[2] * koef[2] + numbers[3] * koef[3] +
                                numbers[4] * koef[4] + numbers[5] * koef[5] + numbers[6] * koef[6]);
                }

                numbers.Clear();
            }

            return result;
        }
    }
}
