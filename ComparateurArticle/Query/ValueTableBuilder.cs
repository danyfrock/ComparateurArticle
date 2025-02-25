namespace ComparateurArticle.Query
{
    public static class ValueTableBuilder
    {
        /// <summary>
        /// Build an expression simale to (VALUES (...) as t(col1,col2... that can be used in a CTE
        /// </summary>
        /// <param name="values">values to build vaules table</param>
        /// <returns>a string to use in a SQL CTE (Common Expression Expression)</returns>
        public static string BuildValuesTableForCTE(IEnumerable<IEnumerable<string>> values)
        {
            int maxLength = GetMaxLength(values);
            IEnumerable<IEnumerable<string>> complete = CompleteReccords(values, maxLength);
            IEnumerable<string> cteLines = complete.Select(l => BuildValueOfTableWith(l));
            string retour = BuildValuesTableWith(cteLines, maxLength);

            return retour;
        }

        private static IEnumerable<IEnumerable<string>> CompleteReccords(IEnumerable<IEnumerable<string>> values, int toLength)
            => values.Select(line => CompleteReccord(line, toLength));

        private static IEnumerable<string> CompleteReccord(IEnumerable<string> items, int toLength) =>
            items.Concat(Enumerable.Repeat(string.Empty, toLength - items.Count()));

        private static int GetMaxLength(IEnumerable<IEnumerable<string>> values) =>
            values.Select(x => x.Count()).Max();

        /// <summary>
        /// build an expression that can be used into a CTE and that represent a value table
        /// </summary>
        /// <param name="lines">list of line of vaues</param>
        /// <param name="reccordPerLine">give the number of columns in the value table</param>
        /// <returns>a string that can be used in a Common Transaction Expression as a value table</returns>
        private static string BuildValuesTableWith(IEnumerable<string> lines, int reccordPerLine) =>
            $@"(VALUES
{string.Join($@",{Environment.NewLine}", lines)}) as t ({string.Join(", ", Enumerable.Range(0, reccordPerLine).Select(i => $@"col{i + 1}"))})";

        /// <summary>
        /// build one reccords line of a values table
        /// </summary>
        /// <param name="values">list of values of a line</param>
        /// <returns>a string that represent one line of a valie table</returns>
        private static string BuildValueOfTableWith(IEnumerable<string> values) =>
            $@"({string.Join(", ", values.Select(v => $@"'{v.Replace("'","\"")}'"))})";

    }// classe
}// namespace
