using ClosedXML.Excel;

namespace ComparateurArticle.ExcelReaders.Interfaces
{
    internal interface IRowStrategy
    {
        IEnumerable<IXLRow> GetRows(IXLWorksheet worksheet);
    }
}
