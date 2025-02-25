using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    /// <summary>
    /// Take only the header row
    /// </summary>
    internal class FirstRowStrategy : IRowStrategy
    {
        public IEnumerable<IXLRow> GetRows(IXLWorksheet worksheet) =>
            worksheet.RowsUsed().Take(1);
    }
}
