namespace ComparateurArticle.ModeleDeVue
{
    internal class Emplacement
    {
        private int colonneNo;
        private string? colonneLibelle;

        public int ColonneNo { get => colonneNo; set => colonneNo = value; }
        public string ColonneLibelle { get => colonneLibelle ?? string.Empty; set => colonneLibelle = value; }
    }
}
