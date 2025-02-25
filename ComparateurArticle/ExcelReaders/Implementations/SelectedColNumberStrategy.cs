using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    internal class SelectedColNumberStrategy : IColumnStrategy
    {
        private readonly IEnumerable<int> _headers;
        public SelectedColNumberStrategy(IEnumerable<int> headers)
        {
            _headers = headers;
        }

        public IEnumerable<int> GetColumnIndexes(IXLWorksheet worksheet)
        {
            return _headers;
        }
    }
}
