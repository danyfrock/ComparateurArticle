
using ComparateurArticle.ModeleDeVue;

namespace ComparateurArticle.IHM
{
    internal class EmplacementIHM
    {
        private TextBox nummero;
        private TextBox nom;
        private Label curseur;

        public EmplacementIHM(TextBox nummero, TextBox nom, Label curseur)
        {
            this.nummero = nummero;
            this.nom = nom;
            this.curseur = curseur;
        }


        public TextBox Nummero { get => nummero; set => nummero = value; }
        public TextBox Nom { get => nom; set => nom = value; }
        public Label Curseur { get => curseur; set => curseur = value; }

        public Emplacement Extraire() =>
            new Emplacement()
            {
                ColonneNo = Int32.Parse(this.nummero.Text),
                ColonneLibelle = this.nom.Text,
            };
    }
}
