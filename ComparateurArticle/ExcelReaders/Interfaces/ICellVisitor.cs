using ClosedXML.Excel;

namespace ComparateurArticle.ExcelReaders.Interfaces
{
    internal interface ICellVisitor<T>
    {
        T Visit(IXLCell cell);
    }
}
