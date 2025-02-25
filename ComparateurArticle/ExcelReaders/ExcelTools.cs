using ClosedXML.Excel;
using ComparateurArticle.ExcelReaders.Interfaces;

namespace ComparateurArticle.ExcelReaders
{
    public class ExcelTools<T>
    {
        private XLWorkbook? _workbook; // Pour stocker le classeur
        private IXLWorksheet? _worksheet; // Pour stocker la feuille de calcul
        private IColumnStrategy? columnStrategy;
        private IRowStrategy? rowStrategy;
        private ICellVisitor<T>? cellVisitor;

        internal IColumnStrategy? ColumnStrategy 
        {
            get => columnStrategy;
            set => columnStrategy = value;
        }
        internal IRowStrategy? RowStrategy { get => rowStrategy; set => rowStrategy = value; }
        internal ICellVisitor<T>? CellVisitor { get => cellVisitor; set => cellVisitor = value; }

        // Définir le classeur
        public ExcelTools<T> DefinirWorkBook(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Le fichier {path} n'a pas été trouvé.");

            _workbook = new XLWorkbook(path);
            return this; // Retourne l'instance actuelle pour le chaînage fluent
        }

        public IEnumerable<string> ListerWorkSheets()
        {
            if (_workbook == null)
                yield break;

            foreach (var worksheet in _workbook.Worksheets)
            {
                yield return worksheet.Name;
            }
        }

        // Définir la feuille de calcul
        public ExcelTools<T> DefinirWorkSheet(string sheetName)
        {
            if (_workbook is null)
            {
                return this;
            }

            _worksheet = _workbook.Worksheet(sheetName);
            if (_worksheet == null)
                throw new ArgumentException($"La feuille {sheetName} n'existe pas dans le fichier Excel.");

            return this; // Retourne l'instance actuelle pour le chaînage fluent
        }

        public IEnumerable<IEnumerable<T>> GetData()
        {
            //check
            if(_worksheet is null)
            {
                return Enumerable.Empty<IEnumerable<T>>();
            }
            if(ColumnStrategy is  null)
            {
                return Enumerable.Empty<IEnumerable<T>>();
            }
            if (RowStrategy is null)
            {
                return Enumerable.Empty<IEnumerable<T>>();
            }
            if (CellVisitor is null)
            {
                return Enumerable.Empty<IEnumerable<T>>();
            }

            return GetData(_worksheet, ColumnStrategy, RowStrategy, CellVisitor) ??
                Enumerable.Empty<IEnumerable<T>>();
        }

        internal ExcelTools<T> DefinirColumnStrategy(IColumnStrategy columnStrategy)
        {
            this.ColumnStrategy = columnStrategy;
            return this;
        }

        internal ExcelTools<T> DefinirRowStrategy(IRowStrategy rowStrategy)
        {
            this.RowStrategy = rowStrategy;
            return this;
        }

        internal ExcelTools<T> DefinirCellVisitor(ICellVisitor<T> cellVisitor)
        {
            this.CellVisitor = cellVisitor;
            return this;
        }

        private IEnumerable<IEnumerable<T>>? GetData(
            IXLWorksheet worksheet,
            IColumnStrategy columnStrategy,
            IRowStrategy rowStrategy,
            ICellVisitor<T> visitor)
        {
            foreach (var row in rowStrategy.GetRows(worksheet))
            {
                yield return columnStrategy.GetColumnIndexes(worksheet)
                    .Select(index => visitor.Visit(row.Cell(index)));
            }
        }

    }//classe
} // namespace
