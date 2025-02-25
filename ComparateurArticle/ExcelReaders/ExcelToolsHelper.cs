using ComparateurArticle.ExcelReaders.Implementations;

namespace ComparateurArticle.ExcelReaders
{
    public class ExcelToolsHelper
    {
        private ExcelTools<string> _excelTools = new ExcelTools<string>();

        public ExcelTools<string> ExcelTools => _excelTools;

        internal IEnumerable<IEnumerable<string>> GetAllDataForColumns(List<int> list)
        {
            return ExcelTools
                .DefinirColumnStrategy(new SelectedColNumberStrategy(list))
                .DefinirRowStrategy(new AllDataRowsStrategy())
                .DefinirCellVisitor(new SecureTextVisitor())
                .GetData();
        }

        internal IEnumerable<string> GetAllHedersText()
        {
            return
                RemoveDuplicatesAndRename(
                ExcelTools
                .DefinirColumnStrategy(new AllHeadersStrategy())
                .DefinirRowStrategy(new FirstRowStrategy())
                .DefinirCellVisitor(new TextVisitor())
                .GetData().FirstOrDefault()??
                Enumerable.Empty<string>());
        }

        internal IEnumerable<IEnumerable<string>> GetAllRowAllColumnsText()
        {
            return ExcelTools
                .DefinirColumnStrategy(new AllHeadersStrategy())
                .DefinirRowStrategy(new AllDataRowsStrategy())
                .DefinirCellVisitor(new SecureTextVisitor())
                .GetData();
        }

        internal IEnumerable<IEnumerable<string>> GetXRowAllColumnsText(int v)
        {
            return ExcelTools
                .DefinirColumnStrategy(new AllHeadersStrategy())
                .DefinirRowStrategy(new XFirstDataRowsStrategy(v))
                .DefinirCellVisitor(new SecureTextVisitor())
                .GetData();
        }

        internal IEnumerable<IEnumerable<string>> GetXRowsForcolumns(int v, List<int> list)
        {
            return ExcelTools
                .DefinirColumnStrategy(new SelectedColNumberStrategy(list))
                .DefinirRowStrategy(new XFirstDataRowsStrategy(v))
                .DefinirCellVisitor(new SecureTextVisitor())
                .GetData();
        }

        internal IEnumerable<string> RemoveDuplicatesAndRenameOld(IEnumerable<string> input)
        {
            return input
                .Select((str, index) => (str, index))
                .GroupBy(item => item.str)
                .SelectMany(grp => grp.Select((item, i) => (str: $"{item.str}{(i == 0 ? string.Empty : i)}", item.index)))
                .OrderBy(item => item.index)
                .Select(item => item.str);
        }

        internal IEnumerable<string> RemoveDuplicatesAndRename(IEnumerable<string> input)
        {
            var lookup = input
                .Select((str, index) => (str, index))
                .ToLookup(item => item.str);

            return lookup
                .SelectMany(grp => grp.Select((item, i) => (str: $"{item.str}{(i == 0 ? string.Empty : i)}", item.index)))
                .OrderBy(item => item.index)
                .Select(item => item.str);
        }

    }//clsasse
}//namespace
