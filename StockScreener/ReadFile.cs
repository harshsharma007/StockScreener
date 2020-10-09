using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using System.Linq;

namespace StockScreener
{
    class ReadFile
    {
        private readonly IConfiguration _configuration;

        public ReadFile(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Read(string[] Symbol)
        {
            string FilePath = _configuration["AppSettings:FilePath"];
            using(ExcelPackage ExcelPackage = new ExcelPackage(new System.IO.FileInfo(FilePath)))
            {
                var Worksheet = ExcelPackage.Workbook.Worksheets.First();
                var TotalRows = Worksheet.Dimension.End.Row;
                var TotalColumns = Worksheet.Dimension.End.Column;
            }
        }
    }
}
