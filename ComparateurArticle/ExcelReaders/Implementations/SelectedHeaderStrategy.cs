using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    internal class SelectedHeaderStrategy : IColumnStrategy
    {
        private readonly IEnumerable<string> _headers;
        public SelectedHeaderStrategy(IEnumerable<string> headers)
        {
            _headers = headers;
        }

        public IEnumerable<int> GetColumnIndexes(IXLWorksheet worksheet)
        {
            return _headers.Select(header => worksheet.FirstRowUsed()?
                .Cells()?.FirstOrDefault(c => c.GetString() == header)?.Address?.ColumnNumber?? -1);
        }
    }
}
