using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    internal class AllHeadersStrategy : IColumnStrategy
    {
        public IEnumerable<int> GetColumnIndexes(IXLWorksheet worksheet)
            => worksheet?.FirstRowUsed()?
                        .CellsUsed()
                        .Select(c => c.Address.ColumnNumber) ?? Enumerable.Empty<int>();
    }
}
