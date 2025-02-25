using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders.Implementations
{
    internal class SecureTextVisitor : ICellVisitor<string>
    {
        public string Visit(IXLCell cell)
        {
            return cell.Value.ToString().Replace("'","\"") ?? string.Empty;
        }
    } // classe
} // namespace
