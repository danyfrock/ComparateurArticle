using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    /// <summary>
    /// All rows but the first
    /// </summary>
    internal class AllDataRowsStrategy : IRowStrategy
    {
        public IEnumerable<IXLRow> GetRows(IXLWorksheet worksheet) =>
            worksheet.RowsUsed().Skip(1);
    }
}
