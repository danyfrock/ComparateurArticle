using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    internal class TextVisitor : ICellVisitor<string>
    {
        public string Visit(IXLCell cell)
        {
            return cell.Value.ToString() ?? string.Empty;
        }
    } // classe
} // namespace
