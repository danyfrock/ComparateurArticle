using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    internal class XFirstDataRowsStrategy : IRowStrategy
    {
        private int _numberOfRowsToSelect;

        public XFirstDataRowsStrategy(int numberOfRowsToSelect)
        {
            _numberOfRowsToSelect = numberOfRowsToSelect;
        }

        public IEnumerable<IXLRow> GetRows(IXLWorksheet worksheet) =>
            worksheet.RowsUsed().Skip(1).Take(_numberOfRowsToSelect);
    }
}
