using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    internal class DataVisitor : ICellVisitor<object>
    {
        public object Visit(IXLCell cell)
        {
            return cell.Value;
        }
    } // classe
} // namespace
