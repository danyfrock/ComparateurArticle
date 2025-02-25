using ComparateurArticle.IHM;
using ComparateurArticle.ModeleDeVue;
using WinFormAnimation;

namespace ComparateurArticle
{
    public partial class AcceuilForm : Form
    {
        private Controleur filler = new Controleur();

        public AcceuilForm()
        {
            InitializeComponent();
        }

        private void SetFilePath(string filePath)
        {
            filler.SetFilePath(filePath);
            FichierInsertionPath.Text = filePath;
            comboBoxFeuillesExcel.Items.Clear();
            comboBoxFeuillesExcel.Text = string.Empty;
            comboBoxFeuillesExcel.Items.AddRange(filler.ListerWorkSheets().ToArray());
            dataGridExcelPreview.DataSource = null;
        }

        private void comboBoxFeuillesExcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            filler.SetWorkSheet(((ComboBox)sender).SelectedItem?.ToString() ?? string.Empty);

            dataGridExcelPreview.DataSource =
                filler.GetDataTable(filler.ExcelTools.GetAllHedersText(), filler.ExcelTools.GetAllRowAllColumnsText());
        }

        private void choixFichierButton_Click(object sender, MouseEventArgs e)
        {
            // Créer une boîte de dialogue de fichier
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Filtrer pour les fichiers Excel uniquement
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Sélectionner un fichier Excel"
            };

            // Afficher la boîte de dialogue
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Récupérer le chemin du fichier sélectionné
                this.SetFilePath(openFileDialog.FileName);
            }
        }

        private int _curseur = 0;
        private Dictionary<int, EmplacementIHM> Emplacements() => new Dictionary<int, EmplacementIHM>()
        {
            {0, new EmplacementIHM(textBoxRefNum, textBoxRefLib, labelCurseur1) },
            {1, new EmplacementIHM(textBoxGenNum, textBoxGenLib, labelCurseur2) },
            {2, new EmplacementIHM(textBoxBrutNum, textBoxBrutLib, labelCurseur3) },
            {3, new EmplacementIHM(textBoxNetNum, textBoxNetLib, labelCurseur4) },
        };

        private void dataGridExcelPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChoixDeColonne();
        }

        private void dataGridExcelPreview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ////ChoixDeColonne();
        }

        private void ChoixDeColonne()
        {
            Dictionary<int, EmplacementIHM> dictionary = Emplacements();
            int placeCurseur = _curseur++ % dictionary.Count;
            int selectedColumnIndex = dataGridExcelPreview.CurrentCell.ColumnIndex + 1;
            string selectedColumnName = dataGridExcelPreview.CurrentCell.OwningColumn.Name;
            dictionary.AsEnumerable().ToList().ForEach(e => e.Value.Curseur.Visible = false);

            dictionary[placeCurseur].Nummero.Text = selectedColumnIndex.ToString();
            dictionary[placeCurseur].Nom.Text = selectedColumnName;
            dictionary[placeCurseur].Curseur.Visible = true;
        }

        private void panelVueSql_VisibleChanged(object sender, EventArgs e)
        {
            ConfirmationChoix();
        }

        private void ConfirmationChoix()
        {
            filler.ConfirmerUnChoix(ProductFields.Reference, textBoxRefNum, textBoxRefLib);
            filler.ConfirmerUnChoix(ProductFields.Gencode, textBoxGenNum, textBoxGenLib);
            filler.ConfirmerUnChoix(ProductFields.Brut, textBoxBrutNum, textBoxBrutLib);
            filler.ConfirmerUnChoix(ProductFields.Brut, textBoxNetNum, textBoxNetLib);
        }

        private void buttonTestCs_Click(object sender, EventArgs e)
        {
            richTextBoxQuery.Text = filler.GetSampleQuery();
        }

        private async void buttonEchantillonQuery_Click(object sender, EventArgs e)
        {
            await filler.FillData(dataGridDBView, richTextBoxQuery.Text);
        }

        private void buttonMakeFournQuery_Click(object sender, EventArgs e)
        {
            richTextBoxQueryFour.Text = filler.GetFourQuery();
        }
        private void buttonGroupe_Click(object sender, EventArgs e)
        {
            richTextGroupe.Text = filler.GetGroupeQuery();
        }

        private void panelFour_VisibleChanged(object sender, EventArgs e)
        {
            ConfirmationChoix();
        }

        private async void buttonSearchFour_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                buttonSearchFour.Enabled = false;
                await filler.FillData(dataGridFournisseur, richTextBoxQueryFour.Text);
            }
            finally
            {
                buttonSearchFour.Enabled = true;
            }
        }

        private void panelExport_VisibleChanged(object sender, EventArgs e)
        {
            textBoxDonneesSocietePath.Text = filler.ObtenirSocietePath();
            textBoxInsertionPath.Text = filler.ObtenirInsertionPath();
            textBoxDonneesGroupe.Text = filler.ObtenirGroupePath();
        }

        private void buttonExportExportDonneesSociete_Click(object sender, EventArgs e)
        {
            filler.ExporterVersExcel(dataGridDBView, textBoxDonneesSocietePath.Text);
        }

        private void buttonExportInsertion_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportDonneesGroupe_Click(object sender, EventArgs e)
        {
            filler.ExporterVersExcel(dataGridGroupe, textBoxDonneesGroupe.Text);
        }

        private async void buttonEchantillonGroupe_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                buttonEchantillonGroupe.Enabled = false;
                await filler.FillData(dataGridGroupe, richTextGroupe.Text);
            }
            finally
            {
                buttonEchantillonGroupe.Enabled = true;
            }
        }

        private void dataGridFournisseur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            filler.ChoixUtilisateur.Fournisseur = dataGridFournisseur?.CurrentCell?.Value?.ToString() ?? string.Empty;
            textBoxFourn.Text = filler.ChoixUtilisateur.Fournisseur;
        }

        private async void buttonExeAllSociete_Click(object sender, EventArgs e)
        {
            try
            {
                buttonExeAllSociete.Enabled = false;
                await filler.FillDatas(dataGridDBView, filler.GetSocieteQueries(), progressBarScte);
            }
            finally
            {
                buttonExeAllSociete.Enabled = true;
            }
        }

        private async void buttonGetAllGroupData_Click(object sender, EventArgs e)
        {
            try
            {
                buttonGetAllGroupData.Enabled = false;
                await filler.FillDatas(dataGridGroupe, filler.GetGroupeQueries(), progressBarGroupe);
            }
            finally
            {
                buttonGetAllGroupData.Enabled = true;
            }
        }
    } // classe
} // namespace
