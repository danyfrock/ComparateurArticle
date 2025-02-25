using ComparateurArticle.ExcelReaders;
using ComparateurArticle.Extensions;
using ComparateurArticle.Query;
using System.Data;
using System.Text.RegularExpressions;

namespace ComparateurArticle.ModeleDeVue
{
    internal class Controleur
    {
        private const int TailleEchantillons = 200;
        private ChoixUtilisateur choixUtilisateur = new ChoixUtilisateur();
        private ExcelToolsHelper excelTools = new ExcelToolsHelper();
        private ExcelExport excelExport = new ExcelExport();
        private int chunkSize = 500;

        public ExcelToolsHelper ExcelTools { get => excelTools; }
        internal ChoixUtilisateur ChoixUtilisateur { get => choixUtilisateur; }

        public Controleur() { }

        public Controleur WithChunkSize(int chunkSize)
        {
            this.chunkSize = chunkSize;
            return this;
        }

        public DataTable GetDataTable(IEnumerable<string> columns, IEnumerable<IEnumerable<string>> rows)
        {
            DataTable table = new DataTable();

            foreach (string column in columns)
            {
                table.Columns.Add(column);
            }

            foreach (IEnumerable<string> cells in rows)
            {
                table.Rows.Add(cells.ToArray());
            }

            return table;
        }

        public void SetFilePath(string filePath)
        {
            ChoixUtilisateur.SetFilePath(filePath);
            ExcelTools.ExcelTools.DefinirWorkBook(filePath);
        }

        public IEnumerable<string> ListerWorkSheets() => this.ExcelTools.ExcelTools.ListerWorkSheets();

        internal void SetWorkSheet(string? nomFeuille)
        {
            if (!string.IsNullOrEmpty(nomFeuille))
            {
                ExcelTools.ExcelTools.DefinirWorkSheet(nomFeuille);
                ChoixUtilisateur.SetNomFeuille(nomFeuille);
            }
        }

        internal void ConfirmerUnChoix(ProductFields fields ,TextBox indexe, TextBox nomColonne)
        {
            int i = (!string.IsNullOrEmpty(indexe.Text) &&
                    Regex.Match(indexe.Text, @"^\d+$").Success)
                    ? int.Parse(indexe.Text)
                    : 0;

            ChoixUtilisateur.Emplacements[fields].ColonneNo = i;
            ChoixUtilisateur.Emplacements[fields].ColonneLibelle = nomColonne.Text;
        }

        internal string GetSampleQuery()
        {
            return new QueryBuilder(choixUtilisateur.Fournisseur).GetQuerySociete(GetSocieteDataSample());
        }

        private IEnumerable<IEnumerable<string>> GetSocieteDataSample()
        {
            return this.excelTools.GetXRowsForcolumns(TailleEchantillons,
                                new List<int>()
                                {
                        ChoixUtilisateur.Emplacements[ProductFields.Reference].ColonneNo,
                        ChoixUtilisateur.Emplacements[ProductFields.Gencode].ColonneNo
                                });
        }

        private IEnumerable<IEnumerable<string>> GetAllSocieteDatas()
        {
            return this.excelTools.GetAllDataForColumns(
                                new List<int>()
                                {
                        ChoixUtilisateur.Emplacements[ProductFields.Reference].ColonneNo,
                        ChoixUtilisateur.Emplacements[ProductFields.Gencode].ColonneNo
                                });
        }

        internal IEnumerable<string> GetSocieteQueries()
        {
            QueryBuilder queryBuilder =  new QueryBuilder(choixUtilisateur.Fournisseur);
            return GetAllSocieteDatas().Chunk(this.chunkSize).Select(c => queryBuilder.GetQuerySociete(c));
        }

        internal string GetGroupeQuery()
        {
            return new QueryBuilder(choixUtilisateur.Fournisseur).GetQueryGroupe(
                GetSampleGroupeDatas());
        }

        private IEnumerable<IEnumerable<string>> GetSampleGroupeDatas()
        {
            return this.excelTools.GetXRowsForcolumns(TailleEchantillons,
                                new List<int>()
                                {
                        ChoixUtilisateur.Emplacements[ProductFields.Reference].ColonneNo,
                        ChoixUtilisateur.Emplacements[ProductFields.Gencode].ColonneNo
                                });
        }

        private IEnumerable<IEnumerable<string>> GetAllGroupeDatas()
        {
            return this.excelTools.GetAllDataForColumns(
                                new List<int>()
                                {
                        ChoixUtilisateur.Emplacements[ProductFields.Reference].ColonneNo,
                        ChoixUtilisateur.Emplacements[ProductFields.Gencode].ColonneNo
                                });
        }

        internal IEnumerable<string> GetGroupeQueries()
        {
            QueryBuilder queryBuilder = new QueryBuilder(choixUtilisateur.Fournisseur);
            return GetAllGroupeDatas().Chunk(this.chunkSize).Select(c => queryBuilder.GetQueryGroupe(c));
        }

        internal string GetFourQuery()
        {
            return new QueryBuilder(choixUtilisateur.Fournisseur).GetQueryFour(
                this.excelTools.GetXRowsForcolumns(
                    500,
                    new List<int>()
                    {
                        ChoixUtilisateur.Emplacements[ProductFields.Reference].ColonneNo,
                        ChoixUtilisateur.Emplacements[ProductFields.Gencode].ColonneNo
                    }));
        }

        public void ExporterVersExcel(DataGridView dataVue, string filePath)
        {
            excelExport.ExporterVersExcel((DataTable)dataVue.DataSource, filePath);
        }

        public async Task ExporterVersExcelAsync(DataGridView dataVue, string filePath)
        {
            await Task.Run(() => excelExport.ExporterVersExcel((DataTable)dataVue.DataSource, filePath));
        }

        public string ObtenirSocietePath() =>
            CompletePathWithSuffixe(choixUtilisateur?.Filepath?? string.Empty, "Societe");

        public string ObtenirInsertionPath() =>
            CompletePathWithSuffixe(choixUtilisateur?.Filepath ?? string.Empty, "Insertion");

        internal string ObtenirGroupePath() =>
            CompletePathWithSuffixe(choixUtilisateur?.Filepath ?? string.Empty, "Groupe");

        private string CompletePathWithSuffixe(string path, string suffixe)
        {
            // Sépare le chemin en répertoire et nom de fichier
            string directory = Path.GetDirectoryName(path)?? string.Empty;
            string fileName = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);

            // Crée le nouveau nom de fichier avec le suffixe
            string newFileName = $"{fileName}{suffixe}{extension}";

            // Combine le répertoire et le nouveau nom de fichier pour obtenir le chemin complet
            return System.IO.Path.Combine(directory, newFileName);
        }

        internal async Task FillData(DataGridView dataGrid, string query)
        {
            dataGrid.DataSource = new DataTable();
            DataTable data = await IbmAs400.GetDataFromAS400Async(query);
            dataGrid.DataSource = data;
        }

        internal async Task FillDatas(DataGridView dataGrid, IEnumerable<string> queries, ProgressBar progressBar)
        {
            dataGrid.DataSource = new DataTable();

            if (queries.Any())
            {
                int totalQueries = queries.Count();
                int progress = 0;

                progressBar.Value = 0;
                DataTable data = new DataTable();

                foreach (var query in queries)
                {
                    DataTable dt = await IbmAs400.GetDataFromAS400Async(query);
                    data.Merge(dt);

                    // Mise à jour de la progression
                    progress++;
                    int percentComplete = (progress * 100) / totalQueries;

                    // Met à jour la barre de progression sur le thread UI
                    progressBar.Invoke(new Action(() => progressBar.Value = percentComplete));
                }

                dataGrid.DataSource = data;
            }
        }
    } // classe
} // namespace
