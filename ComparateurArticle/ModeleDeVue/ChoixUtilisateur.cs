
namespace ComparateurArticle.ModeleDeVue
{
    internal class ChoixUtilisateur
    {
        private string? _filepath;
        private string? _nomFeuille;
        private Dictionary<ProductFields, Emplacement> _emplacements =
            new Dictionary<ProductFields, Emplacement>()
            {
                { ProductFields.Reference, new Emplacement() },
                { ProductFields.Gencode, new Emplacement() },
                { ProductFields.Brut, new Emplacement() },
                { ProductFields.Net, new Emplacement() }
            };
        private string fournisseur = string.Empty;

        public string? Filepath { get => _filepath; set => _filepath = value; }
        public string? NomFeuille { get => _nomFeuille; set => _nomFeuille = value; }
        public Dictionary<ProductFields, Emplacement> Emplacements { get => _emplacements; }
        public string Fournisseur { get => fournisseur; set => fournisseur = value; }

        internal void SetFilePath(string fileName)
        {
            Filepath = fileName;
        }

        internal void SetNomFeuille(string nomFeuille)
        {
            NomFeuille = nomFeuille;
        }
    } // classe
} //namespace
