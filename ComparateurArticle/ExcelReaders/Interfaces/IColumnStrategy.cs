using ClosedXML.Excel;

namespace ComparateurArticle.ExcelReaders.Interfaces
{
    internal interface IColumnStrategy
    {
        IEnumerable<int> GetColumnIndexes(IXLWorksheet worksheet);
    }
}
