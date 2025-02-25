using ComparateurArticle.Logger;
using System.Data;
using System.Data.Odbc;

namespace ComparateurArticle.Query
{
    internal static class IbmAs400
    {
        public static string? ConnexionString { get; } = Environment.GetEnvironmentVariable("AS400_CONNECTION_STRING");

        static IbmAs400()
        {
            if (string.IsNullOrEmpty(ConnexionString))
            {
                throw new InvalidOperationException("The connection string environment variable 'AS400_CONNECTION_STRING' is not set.");
            }
        }

        public static DataTable GetDataFromAS400(string query)
        {
            DataTable dataTable = new DataTable();

            using (OdbcConnection connection = new OdbcConnection(ConnexionString))
            {
                try
                {
                    connection.Open();
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        command.CommandTimeout = 0;
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new AdHocLogger().LogError($@"{ex.Message}
{ex.StackTrace}

query = 
{query}");
                }
            }

            return dataTable;
        }

        public static IEnumerable<IEnumerable<object>> GetEnumerableFromAS400(string query)
        {
            try
            {
                return GetRows(query);
            }
            catch (Exception ex)
            {
                new AdHocLogger().LogError($@"{ex.Message}
{ex.StackTrace}

query = 
{query}");
                return Enumerable.Empty<IEnumerable<IEnumerable<string>>> ();
            }
        }

        private static IEnumerable<IEnumerable<object>> GetRows(string query)
        {
            using (OdbcConnection connection = new OdbcConnection(ConnexionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Récupère une ligne comme IEnumerable<object>
                            yield return GetRowData(reader);
                        }
                    }
                }
            }
        }

        private static IEnumerable<object> GetRowData(OdbcDataReader reader)
        {
            // Crée une collection pour les valeurs de la ligne
            var values = new object[reader.FieldCount];
            reader.GetValues(values);
            return values;
        }

        public static Task<DataTable> GetDataFromAS400Async(string query)
            => Task.Run(() => GetDataFromAS400(query));

    }//classe
}//namespace
