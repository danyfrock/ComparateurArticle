namespace ComparateurArticle
{
    partial class AcceuilForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            mainTableLayoutPanel = new TableLayoutPanel();
            mainTabControl = new TabControl();
            tabExcelSource = new TabPage();
            page1LayoutPanel = new TableLayoutPanel();
            comboBoxFeuillesExcel = new ComboBox();
            dataGridExcelPreview = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxNetLib = new TextBox();
            textBoxBrutLib = new TextBox();
            textBoxGenLib = new TextBox();
            textBoxNetNum = new TextBox();
            textBoxBrutNum = new TextBox();
            textBoxGenNum = new TextBox();
            labelRef = new Label();
            gencode = new Label();
            labelPrixBrut = new Label();
            labelPrixNet = new Label();
            textBoxRefNum = new TextBox();
            textBoxRefLib = new TextBox();
            flowLayoutPanelFichier = new FlowLayoutPanel();
            FichierInsertionPath = new TextBox();
            choixFichierButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelCurseur4 = new Label();
            labelCurseur3 = new Label();
            labelCurseur2 = new Label();
            labelCurseur1 = new Label();
            tabPageFournisseur = new TabPage();
            panelFour = new Panel();
            tableLayoutFour = new TableLayoutPanel();
            buttonMakeQuery = new Button();
            richTextBoxQueryFour = new RichTextBox();
            dataGridFournisseur = new DataGridView();
            buttonSearchFour = new Button();
            textBoxFourn = new TextBox();
            tabVueSql = new TabPage();
            surPanel1VueSql = new Panel();
            panelVueSql = new Panel();
            tableLayoutPanelVueDb = new TableLayoutPanel();
            dataGridDBView = new DataGridView();
            buttonTestCs = new Button();
            richTextBoxQuery = new RichTextBox();
            buttonEchantillonQuery = new Button();
            buttonExeAllSociete = new Button();
            progressBarScte = new ProgressBar();
            tabGroupe = new TabPage();
            panelGroupe = new Panel();
            tableLayoutGroupe = new TableLayoutPanel();
            buttonGroupe = new Button();
            buttonEchantillonGroupe = new Button();
            richTextGroupe = new RichTextBox();
            dataGridGroupe = new DataGridView();
            buttonGetAllGroupData = new Button();
            progressBarGroupe = new ProgressBar();
            tabPageExport = new TabPage();
            panelExport = new Panel();
            tableLayoutPanelExport = new TableLayoutPanel();
            textBoxRapportPath = new TextBox();
            textBoxDonneesGroupe = new TextBox();
            buttonExportDonneesGroupe = new Button();
            textBoxDonneesSocietePath = new TextBox();
            buttonExportExportDonneesSociete = new Button();
            textBoxInsertionPath = new TextBox();
            buttonSpeederMaj = new Button();
            imageList1 = new ImageList(components);
            mainPanel.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            mainTabControl.SuspendLayout();
            tabExcelSource.SuspendLayout();
            page1LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExcelPreview).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanelFichier.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPageFournisseur.SuspendLayout();
            panelFour.SuspendLayout();
            tableLayoutFour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFournisseur).BeginInit();
            tabVueSql.SuspendLayout();
            surPanel1VueSql.SuspendLayout();
            panelVueSql.SuspendLayout();
            tableLayoutPanelVueDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDBView).BeginInit();
            tabGroupe.SuspendLayout();
            panelGroupe.SuspendLayout();
            tableLayoutGroupe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridGroupe).BeginInit();
            tabPageExport.SuspendLayout();
            panelExport.SuspendLayout();
            tableLayoutPanelExport.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainPanel.Controls.Add(mainTableLayoutPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(962, 741);
            mainPanel.TabIndex = 4;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.13233F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.86766529F));
            mainTableLayoutPanel.Controls.Add(mainTabControl, 0, 2);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 4;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            mainTableLayoutPanel.Size = new Size(962, 741);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // mainTabControl
            // 
            mainTableLayoutPanel.SetColumnSpan(mainTabControl, 2);
            mainTabControl.Controls.Add(tabExcelSource);
            mainTabControl.Controls.Add(tabPageFournisseur);
            mainTabControl.Controls.Add(tabVueSql);
            mainTabControl.Controls.Add(tabGroupe);
            mainTabControl.Controls.Add(tabPageExport);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(3, 18);
            mainTabControl.Margin = new Padding(3, 4, 3, 4);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(956, 712);
            mainTabControl.TabIndex = 6;
            // 
            // tabExcelSource
            // 
            tabExcelSource.Controls.Add(page1LayoutPanel);
            tabExcelSource.Location = new Point(4, 29);
            tabExcelSource.Margin = new Padding(3, 4, 3, 4);
            tabExcelSource.Name = "tabExcelSource";
            tabExcelSource.Padding = new Padding(3, 4, 3, 4);
            tabExcelSource.Size = new Size(948, 679);
            tabExcelSource.TabIndex = 0;
            tabExcelSource.Text = "source Excel";
            tabExcelSource.UseVisualStyleBackColor = true;
            // 
            // page1LayoutPanel
            // 
            page1LayoutPanel.ColumnCount = 2;
            page1LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            page1LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            page1LayoutPanel.Controls.Add(comboBoxFeuillesExcel, 0, 1);
            page1LayoutPanel.Controls.Add(dataGridExcelPreview, 0, 2);
            page1LayoutPanel.Controls.Add(tableLayoutPanel1, 0, 3);
            page1LayoutPanel.Controls.Add(flowLayoutPanelFichier, 0, 0);
            page1LayoutPanel.Controls.Add(tableLayoutPanel2, 1, 3);
            page1LayoutPanel.Dock = DockStyle.Fill;
            page1LayoutPanel.Location = new Point(3, 4);
            page1LayoutPanel.Margin = new Padding(3, 4, 3, 4);
            page1LayoutPanel.Name = "page1LayoutPanel";
            page1LayoutPanel.RowCount = 4;
            page1LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            page1LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            page1LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            page1LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            page1LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            page1LayoutPanel.Size = new Size(942, 671);
            page1LayoutPanel.TabIndex = 0;
            // 
            // comboBoxFeuillesExcel
            // 
            comboBoxFeuillesExcel.Dock = DockStyle.Fill;
            comboBoxFeuillesExcel.FormattingEnabled = true;
            comboBoxFeuillesExcel.Location = new Point(3, 71);
            comboBoxFeuillesExcel.Margin = new Padding(3, 4, 3, 4);
            comboBoxFeuillesExcel.Name = "comboBoxFeuillesExcel";
            comboBoxFeuillesExcel.Size = new Size(465, 28);
            comboBoxFeuillesExcel.TabIndex = 6;
            comboBoxFeuillesExcel.SelectedIndexChanged += comboBoxFeuillesExcel_SelectedIndexChanged;
            // 
            // dataGridExcelPreview
            // 
            dataGridExcelPreview.AllowUserToAddRows = false;
            dataGridExcelPreview.AllowUserToDeleteRows = false;
            dataGridExcelPreview.AllowUserToOrderColumns = true;
            dataGridExcelPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            page1LayoutPanel.SetColumnSpan(dataGridExcelPreview, 2);
            dataGridExcelPreview.Dock = DockStyle.Fill;
            dataGridExcelPreview.Location = new Point(3, 138);
            dataGridExcelPreview.Margin = new Padding(3, 4, 3, 4);
            dataGridExcelPreview.Name = "dataGridExcelPreview";
            dataGridExcelPreview.ReadOnly = true;
            dataGridExcelPreview.RowHeadersWidth = 51;
            dataGridExcelPreview.Size = new Size(936, 260);
            dataGridExcelPreview.TabIndex = 4;
            dataGridExcelPreview.CellDoubleClick += dataGridExcelPreview_CellDoubleClick;
            dataGridExcelPreview.CellEnter += dataGridExcelPreview_CellEnter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(textBoxNetLib, 2, 3);
            tableLayoutPanel1.Controls.Add(textBoxBrutLib, 2, 2);
            tableLayoutPanel1.Controls.Add(textBoxGenLib, 2, 1);
            tableLayoutPanel1.Controls.Add(textBoxNetNum, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxBrutNum, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxGenNum, 1, 1);
            tableLayoutPanel1.Controls.Add(labelRef, 0, 0);
            tableLayoutPanel1.Controls.Add(gencode, 0, 1);
            tableLayoutPanel1.Controls.Add(labelPrixBrut, 0, 2);
            tableLayoutPanel1.Controls.Add(labelPrixNet, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxRefNum, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxRefLib, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 406);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(465, 261);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // textBoxNetLib
            // 
            textBoxNetLib.Location = new Point(313, 199);
            textBoxNetLib.Margin = new Padding(3, 4, 3, 4);
            textBoxNetLib.Name = "textBoxNetLib";
            textBoxNetLib.ReadOnly = true;
            textBoxNetLib.Size = new Size(114, 27);
            textBoxNetLib.TabIndex = 11;
            // 
            // textBoxBrutLib
            // 
            textBoxBrutLib.Location = new Point(313, 134);
            textBoxBrutLib.Margin = new Padding(3, 4, 3, 4);
            textBoxBrutLib.Name = "textBoxBrutLib";
            textBoxBrutLib.ReadOnly = true;
            textBoxBrutLib.Size = new Size(114, 27);
            textBoxBrutLib.TabIndex = 9;
            // 
            // textBoxGenLib
            // 
            textBoxGenLib.Location = new Point(313, 69);
            textBoxGenLib.Margin = new Padding(3, 4, 3, 4);
            textBoxGenLib.Name = "textBoxGenLib";
            textBoxGenLib.ReadOnly = true;
            textBoxGenLib.Size = new Size(114, 27);
            textBoxGenLib.TabIndex = 7;
            // 
            // textBoxNetNum
            // 
            textBoxNetNum.Location = new Point(158, 199);
            textBoxNetNum.Margin = new Padding(3, 4, 3, 4);
            textBoxNetNum.Name = "textBoxNetNum";
            textBoxNetNum.ReadOnly = true;
            textBoxNetNum.Size = new Size(114, 27);
            textBoxNetNum.TabIndex = 10;
            // 
            // textBoxBrutNum
            // 
            textBoxBrutNum.Location = new Point(158, 134);
            textBoxBrutNum.Margin = new Padding(3, 4, 3, 4);
            textBoxBrutNum.Name = "textBoxBrutNum";
            textBoxBrutNum.ReadOnly = true;
            textBoxBrutNum.Size = new Size(114, 27);
            textBoxBrutNum.TabIndex = 8;
            // 
            // textBoxGenNum
            // 
            textBoxGenNum.Location = new Point(158, 69);
            textBoxGenNum.Margin = new Padding(3, 4, 3, 4);
            textBoxGenNum.Name = "textBoxGenNum";
            textBoxGenNum.ReadOnly = true;
            textBoxGenNum.Size = new Size(114, 27);
            textBoxGenNum.TabIndex = 6;
            // 
            // labelRef
            // 
            labelRef.AutoSize = true;
            labelRef.Location = new Point(3, 0);
            labelRef.Name = "labelRef";
            labelRef.Size = new Size(71, 20);
            labelRef.TabIndex = 0;
            labelRef.Text = "reference";
            // 
            // gencode
            // 
            gencode.AutoSize = true;
            gencode.Location = new Point(3, 65);
            gencode.Name = "gencode";
            gencode.Size = new Size(101, 20);
            gencode.TabIndex = 1;
            gencode.Text = "labelGencode";
            // 
            // labelPrixBrut
            // 
            labelPrixBrut.AutoSize = true;
            labelPrixBrut.Location = new Point(3, 130);
            labelPrixBrut.Name = "labelPrixBrut";
            labelPrixBrut.Size = new Size(65, 20);
            labelPrixBrut.TabIndex = 2;
            labelPrixBrut.Text = "prix brut";
            // 
            // labelPrixNet
            // 
            labelPrixNet.AutoSize = true;
            labelPrixNet.Location = new Point(3, 195);
            labelPrixNet.Name = "labelPrixNet";
            labelPrixNet.Size = new Size(59, 20);
            labelPrixNet.TabIndex = 3;
            labelPrixNet.Text = "prix net";
            // 
            // textBoxRefNum
            // 
            textBoxRefNum.Location = new Point(158, 4);
            textBoxRefNum.Margin = new Padding(3, 4, 3, 4);
            textBoxRefNum.Name = "textBoxRefNum";
            textBoxRefNum.ReadOnly = true;
            textBoxRefNum.Size = new Size(114, 27);
            textBoxRefNum.TabIndex = 4;
            // 
            // textBoxRefLib
            // 
            textBoxRefLib.Location = new Point(313, 4);
            textBoxRefLib.Margin = new Padding(3, 4, 3, 4);
            textBoxRefLib.Name = "textBoxRefLib";
            textBoxRefLib.ReadOnly = true;
            textBoxRefLib.Size = new Size(114, 27);
            textBoxRefLib.TabIndex = 5;
            // 
            // flowLayoutPanelFichier
            // 
            page1LayoutPanel.SetColumnSpan(flowLayoutPanelFichier, 2);
            flowLayoutPanelFichier.Controls.Add(FichierInsertionPath);
            flowLayoutPanelFichier.Controls.Add(choixFichierButton);
            flowLayoutPanelFichier.Dock = DockStyle.Fill;
            flowLayoutPanelFichier.Location = new Point(3, 4);
            flowLayoutPanelFichier.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelFichier.Name = "flowLayoutPanelFichier";
            flowLayoutPanelFichier.Size = new Size(936, 59);
            flowLayoutPanelFichier.TabIndex = 7;
            // 
            // FichierInsertionPath
            // 
            FichierInsertionPath.Dock = DockStyle.Left;
            FichierInsertionPath.Location = new Point(3, 4);
            FichierInsertionPath.Margin = new Padding(3, 4, 3, 4);
            FichierInsertionPath.Name = "FichierInsertionPath";
            FichierInsertionPath.ReadOnly = true;
            FichierInsertionPath.Size = new Size(855, 27);
            FichierInsertionPath.TabIndex = 2;
            // 
            // choixFichierButton
            // 
            choixFichierButton.Location = new Point(864, 4);
            choixFichierButton.Margin = new Padding(3, 4, 3, 4);
            choixFichierButton.Name = "choixFichierButton";
            choixFichierButton.Size = new Size(50, 31);
            choixFichierButton.TabIndex = 2;
            choixFichierButton.Text = "...";
            choixFichierButton.UseVisualStyleBackColor = true;
            choixFichierButton.MouseClick += choixFichierButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(labelCurseur4, 0, 3);
            tableLayoutPanel2.Controls.Add(labelCurseur3, 0, 2);
            tableLayoutPanel2.Controls.Add(labelCurseur2, 0, 1);
            tableLayoutPanel2.Controls.Add(labelCurseur1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(474, 405);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(465, 263);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // labelCurseur4
            // 
            labelCurseur4.AutoSize = true;
            labelCurseur4.Dock = DockStyle.Fill;
            labelCurseur4.Location = new Point(3, 195);
            labelCurseur4.Name = "labelCurseur4";
            labelCurseur4.Size = new Size(148, 68);
            labelCurseur4.TabIndex = 3;
            labelCurseur4.Text = "<=";
            labelCurseur4.Visible = false;
            // 
            // labelCurseur3
            // 
            labelCurseur3.AutoSize = true;
            labelCurseur3.Dock = DockStyle.Fill;
            labelCurseur3.Location = new Point(3, 130);
            labelCurseur3.Name = "labelCurseur3";
            labelCurseur3.Size = new Size(148, 65);
            labelCurseur3.TabIndex = 2;
            labelCurseur3.Text = "<=";
            labelCurseur3.Visible = false;
            // 
            // labelCurseur2
            // 
            labelCurseur2.AutoSize = true;
            labelCurseur2.Dock = DockStyle.Fill;
            labelCurseur2.Location = new Point(3, 65);
            labelCurseur2.Name = "labelCurseur2";
            labelCurseur2.Size = new Size(148, 65);
            labelCurseur2.TabIndex = 1;
            labelCurseur2.Text = "<=";
            labelCurseur2.Visible = false;
            // 
            // labelCurseur1
            // 
            labelCurseur1.AutoSize = true;
            labelCurseur1.Dock = DockStyle.Fill;
            labelCurseur1.Location = new Point(3, 0);
            labelCurseur1.Name = "labelCurseur1";
            labelCurseur1.Size = new Size(148, 65);
            labelCurseur1.TabIndex = 0;
            labelCurseur1.Text = "<=";
            labelCurseur1.Visible = false;
            // 
            // tabPageFournisseur
            // 
            tabPageFournisseur.Controls.Add(panelFour);
            tabPageFournisseur.Location = new Point(4, 29);
            tabPageFournisseur.Margin = new Padding(3, 4, 3, 4);
            tabPageFournisseur.Name = "tabPageFournisseur";
            tabPageFournisseur.Size = new Size(948, 679);
            tabPageFournisseur.TabIndex = 2;
            tabPageFournisseur.Text = "Fournisseur";
            tabPageFournisseur.UseVisualStyleBackColor = true;
            // 
            // panelFour
            // 
            panelFour.Controls.Add(tableLayoutFour);
            panelFour.Dock = DockStyle.Fill;
            panelFour.Location = new Point(0, 0);
            panelFour.Margin = new Padding(3, 4, 3, 4);
            panelFour.Name = "panelFour";
            panelFour.Size = new Size(948, 679);
            panelFour.TabIndex = 1;
            panelFour.VisibleChanged += panelFour_VisibleChanged;
            // 
            // tableLayoutFour
            // 
            tableLayoutFour.ColumnCount = 3;
            tableLayoutFour.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutFour.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutFour.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutFour.Controls.Add(buttonMakeQuery, 0, 0);
            tableLayoutFour.Controls.Add(richTextBoxQueryFour, 1, 0);
            tableLayoutFour.Controls.Add(dataGridFournisseur, 0, 2);
            tableLayoutFour.Controls.Add(buttonSearchFour, 0, 1);
            tableLayoutFour.Controls.Add(textBoxFourn, 2, 2);
            tableLayoutFour.Dock = DockStyle.Fill;
            tableLayoutFour.Location = new Point(0, 0);
            tableLayoutFour.Margin = new Padding(3, 4, 3, 4);
            tableLayoutFour.Name = "tableLayoutFour";
            tableLayoutFour.RowCount = 3;
            tableLayoutFour.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutFour.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutFour.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutFour.Size = new Size(948, 679);
            tableLayoutFour.TabIndex = 0;
            // 
            // buttonMakeQuery
            // 
            buttonMakeQuery.Location = new Point(3, 4);
            buttonMakeQuery.Margin = new Padding(3, 4, 3, 4);
            buttonMakeQuery.Name = "buttonMakeQuery";
            buttonMakeQuery.Size = new Size(86, 76);
            buttonMakeQuery.TabIndex = 1;
            buttonMakeQuery.Text = "construire la requete";
            buttonMakeQuery.UseVisualStyleBackColor = true;
            buttonMakeQuery.Click += buttonMakeFournQuery_Click;
            // 
            // richTextBoxQueryFour
            // 
            tableLayoutFour.SetColumnSpan(richTextBoxQueryFour, 2);
            richTextBoxQueryFour.Dock = DockStyle.Fill;
            richTextBoxQueryFour.Location = new Point(318, 4);
            richTextBoxQueryFour.Margin = new Padding(3, 4, 3, 4);
            richTextBoxQueryFour.Name = "richTextBoxQueryFour";
            tableLayoutFour.SetRowSpan(richTextBoxQueryFour, 2);
            richTextBoxQueryFour.Size = new Size(627, 444);
            richTextBoxQueryFour.TabIndex = 2;
            richTextBoxQueryFour.Text = "";
            // 
            // dataGridFournisseur
            // 
            dataGridFournisseur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutFour.SetColumnSpan(dataGridFournisseur, 2);
            dataGridFournisseur.Dock = DockStyle.Fill;
            dataGridFournisseur.Location = new Point(3, 456);
            dataGridFournisseur.Margin = new Padding(3, 4, 3, 4);
            dataGridFournisseur.Name = "dataGridFournisseur";
            dataGridFournisseur.RowHeadersWidth = 51;
            dataGridFournisseur.Size = new Size(624, 219);
            dataGridFournisseur.TabIndex = 3;
            dataGridFournisseur.VirtualMode = true;
            dataGridFournisseur.CellDoubleClick += dataGridFournisseur_CellDoubleClick;
            // 
            // buttonSearchFour
            // 
            buttonSearchFour.Location = new Point(3, 230);
            buttonSearchFour.Margin = new Padding(3, 4, 3, 4);
            buttonSearchFour.Name = "buttonSearchFour";
            buttonSearchFour.Size = new Size(86, 83);
            buttonSearchFour.TabIndex = 4;
            buttonSearchFour.Text = "faire la recherche";
            buttonSearchFour.UseVisualStyleBackColor = true;
            buttonSearchFour.Click += buttonSearchFour_ClickAsync;
            // 
            // textBoxFourn
            // 
            textBoxFourn.Dock = DockStyle.Top;
            textBoxFourn.Location = new Point(633, 456);
            textBoxFourn.Margin = new Padding(3, 4, 3, 4);
            textBoxFourn.Name = "textBoxFourn";
            textBoxFourn.Size = new Size(312, 27);
            textBoxFourn.TabIndex = 5;
            // 
            // tabVueSql
            // 
            tabVueSql.Controls.Add(surPanel1VueSql);
            tabVueSql.Location = new Point(4, 29);
            tabVueSql.Margin = new Padding(3, 4, 3, 4);
            tabVueSql.Name = "tabVueSql";
            tabVueSql.Padding = new Padding(3, 4, 3, 4);
            tabVueSql.Size = new Size(948, 679);
            tabVueSql.TabIndex = 1;
            tabVueSql.Text = "vue societe";
            tabVueSql.UseVisualStyleBackColor = true;
            // 
            // surPanel1VueSql
            // 
            surPanel1VueSql.Controls.Add(panelVueSql);
            surPanel1VueSql.Dock = DockStyle.Fill;
            surPanel1VueSql.Location = new Point(3, 4);
            surPanel1VueSql.Name = "surPanel1VueSql";
            surPanel1VueSql.Size = new Size(942, 671);
            surPanel1VueSql.TabIndex = 0;
            // 
            // panelVueSql
            // 
            panelVueSql.Controls.Add(tableLayoutPanelVueDb);
            panelVueSql.Dock = DockStyle.Fill;
            panelVueSql.Location = new Point(0, 0);
            panelVueSql.Margin = new Padding(3, 4, 3, 4);
            panelVueSql.Name = "panelVueSql";
            panelVueSql.Size = new Size(942, 671);
            panelVueSql.TabIndex = 0;
            panelVueSql.VisibleChanged += panelVueSql_VisibleChanged;
            // 
            // tableLayoutPanelVueDb
            // 
            tableLayoutPanelVueDb.ColumnCount = 2;
            tableLayoutPanelVueDb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanelVueDb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelVueDb.Controls.Add(dataGridDBView, 0, 2);
            tableLayoutPanelVueDb.Controls.Add(buttonTestCs, 1, 0);
            tableLayoutPanelVueDb.Controls.Add(richTextBoxQuery, 0, 0);
            tableLayoutPanelVueDb.Controls.Add(buttonEchantillonQuery, 1, 1);
            tableLayoutPanelVueDb.Controls.Add(buttonExeAllSociete, 1, 2);
            tableLayoutPanelVueDb.Controls.Add(progressBarScte, 0, 1);
            tableLayoutPanelVueDb.Dock = DockStyle.Fill;
            tableLayoutPanelVueDb.Location = new Point(0, 0);
            tableLayoutPanelVueDb.Name = "tableLayoutPanelVueDb";
            tableLayoutPanelVueDb.RowCount = 3;
            tableLayoutPanelVueDb.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanelVueDb.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanelVueDb.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanelVueDb.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelVueDb.Size = new Size(942, 671);
            tableLayoutPanelVueDb.TabIndex = 2;
            // 
            // dataGridDBView
            // 
            dataGridDBView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDBView.Dock = DockStyle.Fill;
            dataGridDBView.Location = new Point(3, 254);
            dataGridDBView.Margin = new Padding(3, 4, 3, 4);
            dataGridDBView.Name = "dataGridDBView";
            dataGridDBView.RowHeadersWidth = 51;
            dataGridDBView.Size = new Size(794, 413);
            dataGridDBView.TabIndex = 1;
            dataGridDBView.VirtualMode = true;
            // 
            // buttonTestCs
            // 
            buttonTestCs.Dock = DockStyle.Fill;
            buttonTestCs.Location = new Point(803, 3);
            buttonTestCs.Name = "buttonTestCs";
            buttonTestCs.Size = new Size(136, 119);
            buttonTestCs.TabIndex = 2;
            buttonTestCs.Text = "construire la requete";
            buttonTestCs.UseVisualStyleBackColor = true;
            buttonTestCs.Click += buttonTestCs_Click;
            // 
            // richTextBoxQuery
            // 
            richTextBoxQuery.Dock = DockStyle.Fill;
            richTextBoxQuery.Location = new Point(3, 3);
            richTextBoxQuery.Name = "richTextBoxQuery";
            richTextBoxQuery.Size = new Size(794, 119);
            richTextBoxQuery.TabIndex = 3;
            richTextBoxQuery.Text = "";
            // 
            // buttonEchantillonQuery
            // 
            buttonEchantillonQuery.Dock = DockStyle.Fill;
            buttonEchantillonQuery.Location = new Point(803, 128);
            buttonEchantillonQuery.Name = "buttonEchantillonQuery";
            buttonEchantillonQuery.Size = new Size(136, 119);
            buttonEchantillonQuery.TabIndex = 4;
            buttonEchantillonQuery.Text = "Échantillon";
            buttonEchantillonQuery.UseVisualStyleBackColor = true;
            buttonEchantillonQuery.Click += buttonEchantillonQuery_Click;
            // 
            // buttonExeAllSociete
            // 
            buttonExeAllSociete.Dock = DockStyle.Fill;
            buttonExeAllSociete.Location = new Point(803, 253);
            buttonExeAllSociete.Name = "buttonExeAllSociete";
            buttonExeAllSociete.Size = new Size(136, 415);
            buttonExeAllSociete.TabIndex = 5;
            buttonExeAllSociete.Text = "tout réupérer";
            buttonExeAllSociete.UseVisualStyleBackColor = true;
            buttonExeAllSociete.Click += buttonExeAllSociete_Click;
            // 
            // progressBarScte
            // 
            progressBarScte.Dock = DockStyle.Fill;
            progressBarScte.Location = new Point(3, 128);
            progressBarScte.Name = "progressBarScte";
            progressBarScte.Size = new Size(794, 119);
            progressBarScte.TabIndex = 6;
            // 
            // tabGroupe
            // 
            tabGroupe.Controls.Add(panelGroupe);
            tabGroupe.Location = new Point(4, 29);
            tabGroupe.Margin = new Padding(3, 4, 3, 4);
            tabGroupe.Name = "tabGroupe";
            tabGroupe.Size = new Size(948, 679);
            tabGroupe.TabIndex = 4;
            tabGroupe.Text = "vue groupe";
            tabGroupe.UseVisualStyleBackColor = true;
            // 
            // panelGroupe
            // 
            panelGroupe.Controls.Add(tableLayoutGroupe);
            panelGroupe.Dock = DockStyle.Fill;
            panelGroupe.Location = new Point(0, 0);
            panelGroupe.Margin = new Padding(3, 4, 3, 4);
            panelGroupe.Name = "panelGroupe";
            panelGroupe.Size = new Size(948, 679);
            panelGroupe.TabIndex = 0;
            // 
            // tableLayoutGroupe
            // 
            tableLayoutGroupe.ColumnCount = 2;
            tableLayoutGroupe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutGroupe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutGroupe.Controls.Add(buttonGroupe, 1, 0);
            tableLayoutGroupe.Controls.Add(buttonEchantillonGroupe, 1, 1);
            tableLayoutGroupe.Controls.Add(richTextGroupe, 0, 0);
            tableLayoutGroupe.Controls.Add(dataGridGroupe, 0, 2);
            tableLayoutGroupe.Controls.Add(buttonGetAllGroupData, 1, 2);
            tableLayoutGroupe.Controls.Add(progressBarGroupe, 0, 1);
            tableLayoutGroupe.Dock = DockStyle.Fill;
            tableLayoutGroupe.Location = new Point(0, 0);
            tableLayoutGroupe.Margin = new Padding(3, 4, 3, 4);
            tableLayoutGroupe.Name = "tableLayoutGroupe";
            tableLayoutGroupe.RowCount = 3;
            tableLayoutGroupe.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutGroupe.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutGroupe.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutGroupe.Size = new Size(948, 679);
            tableLayoutGroupe.TabIndex = 0;
            // 
            // buttonGroupe
            // 
            buttonGroupe.Dock = DockStyle.Fill;
            buttonGroupe.Location = new Point(808, 4);
            buttonGroupe.Margin = new Padding(3, 4, 3, 4);
            buttonGroupe.Name = "buttonGroupe";
            buttonGroupe.Size = new Size(137, 119);
            buttonGroupe.TabIndex = 0;
            buttonGroupe.Text = "generer requete";
            buttonGroupe.UseVisualStyleBackColor = true;
            buttonGroupe.Click += buttonGroupe_Click;
            // 
            // buttonEchantillonGroupe
            // 
            buttonEchantillonGroupe.Dock = DockStyle.Fill;
            buttonEchantillonGroupe.Location = new Point(808, 131);
            buttonEchantillonGroupe.Margin = new Padding(3, 4, 3, 4);
            buttonEchantillonGroupe.Name = "buttonEchantillonGroupe";
            buttonEchantillonGroupe.Size = new Size(137, 119);
            buttonEchantillonGroupe.TabIndex = 1;
            buttonEchantillonGroupe.Text = "Échantillon";
            buttonEchantillonGroupe.UseVisualStyleBackColor = true;
            buttonEchantillonGroupe.Click += buttonEchantillonGroupe_ClickAsync;
            // 
            // richTextGroupe
            // 
            richTextGroupe.Dock = DockStyle.Fill;
            richTextGroupe.Location = new Point(3, 4);
            richTextGroupe.Margin = new Padding(3, 4, 3, 4);
            richTextGroupe.Name = "richTextGroupe";
            richTextGroupe.Size = new Size(799, 119);
            richTextGroupe.TabIndex = 2;
            richTextGroupe.Text = "";
            // 
            // dataGridGroupe
            // 
            dataGridGroupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGroupe.Dock = DockStyle.Fill;
            dataGridGroupe.Location = new Point(3, 258);
            dataGridGroupe.Margin = new Padding(3, 4, 3, 4);
            dataGridGroupe.Name = "dataGridGroupe";
            dataGridGroupe.RowHeadersWidth = 51;
            dataGridGroupe.Size = new Size(799, 417);
            dataGridGroupe.TabIndex = 3;
            dataGridGroupe.VirtualMode = true;
            // 
            // buttonGetAllGroupData
            // 
            buttonGetAllGroupData.Dock = DockStyle.Fill;
            buttonGetAllGroupData.Location = new Point(808, 257);
            buttonGetAllGroupData.Name = "buttonGetAllGroupData";
            buttonGetAllGroupData.Size = new Size(137, 419);
            buttonGetAllGroupData.TabIndex = 4;
            buttonGetAllGroupData.Text = "tout récupérer";
            buttonGetAllGroupData.UseVisualStyleBackColor = true;
            buttonGetAllGroupData.Click += buttonGetAllGroupData_Click;
            // 
            // progressBarGroupe
            // 
            progressBarGroupe.Dock = DockStyle.Fill;
            progressBarGroupe.Location = new Point(3, 130);
            progressBarGroupe.Name = "progressBarGroupe";
            progressBarGroupe.Size = new Size(799, 121);
            progressBarGroupe.TabIndex = 5;
            // 
            // tabPageExport
            // 
            tabPageExport.Controls.Add(panelExport);
            tabPageExport.Location = new Point(4, 29);
            tabPageExport.Margin = new Padding(3, 4, 3, 4);
            tabPageExport.Name = "tabPageExport";
            tabPageExport.Size = new Size(948, 679);
            tabPageExport.TabIndex = 3;
            tabPageExport.Text = "tabExport";
            tabPageExport.UseVisualStyleBackColor = true;
            // 
            // panelExport
            // 
            panelExport.Controls.Add(tableLayoutPanelExport);
            panelExport.Dock = DockStyle.Fill;
            panelExport.Location = new Point(0, 0);
            panelExport.Margin = new Padding(3, 4, 3, 4);
            panelExport.Name = "panelExport";
            panelExport.Size = new Size(948, 679);
            panelExport.TabIndex = 1;
            panelExport.VisibleChanged += panelExport_VisibleChanged;
            // 
            // tableLayoutPanelExport
            // 
            tableLayoutPanelExport.ColumnCount = 3;
            tableLayoutPanelExport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelExport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelExport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelExport.Controls.Add(textBoxRapportPath, 0, 2);
            tableLayoutPanelExport.Controls.Add(textBoxDonneesGroupe, 0, 1);
            tableLayoutPanelExport.Controls.Add(buttonExportDonneesGroupe, 2, 1);
            tableLayoutPanelExport.Controls.Add(textBoxDonneesSocietePath, 0, 0);
            tableLayoutPanelExport.Controls.Add(buttonExportExportDonneesSociete, 2, 0);
            tableLayoutPanelExport.Controls.Add(textBoxInsertionPath, 0, 3);
            tableLayoutPanelExport.Controls.Add(buttonSpeederMaj, 2, 3);
            tableLayoutPanelExport.Dock = DockStyle.Fill;
            tableLayoutPanelExport.Location = new Point(0, 0);
            tableLayoutPanelExport.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelExport.Name = "tableLayoutPanelExport";
            tableLayoutPanelExport.RowCount = 5;
            tableLayoutPanelExport.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelExport.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelExport.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelExport.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelExport.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelExport.Size = new Size(948, 679);
            tableLayoutPanelExport.TabIndex = 0;
            // 
            // textBoxRapportPath
            // 
            tableLayoutPanelExport.SetColumnSpan(textBoxRapportPath, 2);
            textBoxRapportPath.Dock = DockStyle.Fill;
            textBoxRapportPath.Location = new Point(3, 274);
            textBoxRapportPath.Margin = new Padding(3, 4, 3, 4);
            textBoxRapportPath.Name = "textBoxRapportPath";
            textBoxRapportPath.Size = new Size(624, 27);
            textBoxRapportPath.TabIndex = 6;
            // 
            // textBoxDonneesGroupe
            // 
            tableLayoutPanelExport.SetColumnSpan(textBoxDonneesGroupe, 2);
            textBoxDonneesGroupe.Dock = DockStyle.Fill;
            textBoxDonneesGroupe.Location = new Point(3, 139);
            textBoxDonneesGroupe.Margin = new Padding(3, 4, 3, 4);
            textBoxDonneesGroupe.Name = "textBoxDonneesGroupe";
            textBoxDonneesGroupe.Size = new Size(624, 27);
            textBoxDonneesGroupe.TabIndex = 4;
            // 
            // buttonExportDonneesGroupe
            // 
            buttonExportDonneesGroupe.Dock = DockStyle.Top;
            buttonExportDonneesGroupe.Location = new Point(633, 139);
            buttonExportDonneesGroupe.Margin = new Padding(3, 4, 3, 4);
            buttonExportDonneesGroupe.Name = "buttonExportDonneesGroupe";
            buttonExportDonneesGroupe.Size = new Size(312, 31);
            buttonExportDonneesGroupe.TabIndex = 5;
            buttonExportDonneesGroupe.Text = "groupe";
            buttonExportDonneesGroupe.UseVisualStyleBackColor = true;
            buttonExportDonneesGroupe.Click += buttonExportDonneesGroupe_Click;
            // 
            // textBoxDonneesSocietePath
            // 
            tableLayoutPanelExport.SetColumnSpan(textBoxDonneesSocietePath, 2);
            textBoxDonneesSocietePath.Dock = DockStyle.Fill;
            textBoxDonneesSocietePath.Location = new Point(3, 4);
            textBoxDonneesSocietePath.Margin = new Padding(3, 4, 3, 4);
            textBoxDonneesSocietePath.Name = "textBoxDonneesSocietePath";
            textBoxDonneesSocietePath.Size = new Size(624, 27);
            textBoxDonneesSocietePath.TabIndex = 0;
            // 
            // buttonExportExportDonneesSociete
            // 
            buttonExportExportDonneesSociete.Dock = DockStyle.Top;
            buttonExportExportDonneesSociete.Location = new Point(633, 4);
            buttonExportExportDonneesSociete.Margin = new Padding(3, 4, 3, 4);
            buttonExportExportDonneesSociete.Name = "buttonExportExportDonneesSociete";
            buttonExportExportDonneesSociete.Size = new Size(312, 31);
            buttonExportExportDonneesSociete.TabIndex = 1;
            buttonExportExportDonneesSociete.Text = "société";
            buttonExportExportDonneesSociete.UseVisualStyleBackColor = true;
            buttonExportExportDonneesSociete.Click += buttonExportExportDonneesSociete_Click;
            // 
            // textBoxInsertionPath
            // 
            tableLayoutPanelExport.SetColumnSpan(textBoxInsertionPath, 2);
            textBoxInsertionPath.Dock = DockStyle.Fill;
            textBoxInsertionPath.Location = new Point(3, 409);
            textBoxInsertionPath.Margin = new Padding(3, 4, 3, 4);
            textBoxInsertionPath.Name = "textBoxInsertionPath";
            textBoxInsertionPath.Size = new Size(624, 27);
            textBoxInsertionPath.TabIndex = 2;
            // 
            // buttonSpeederMaj
            // 
            buttonSpeederMaj.Dock = DockStyle.Top;
            buttonSpeederMaj.Location = new Point(633, 409);
            buttonSpeederMaj.Margin = new Padding(3, 4, 3, 4);
            buttonSpeederMaj.Name = "buttonSpeederMaj";
            buttonSpeederMaj.Size = new Size(312, 31);
            buttonSpeederMaj.TabIndex = 3;
            buttonSpeederMaj.Text = "speeder maj";
            buttonSpeederMaj.UseVisualStyleBackColor = true;
            buttonSpeederMaj.Click += buttonExportInsertion_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // AcceuilForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 741);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AcceuilForm";
            Text = "Comparateur d'articles";
            MouseClick += choixFichierButton_Click;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            mainTabControl.ResumeLayout(false);
            tabExcelSource.ResumeLayout(false);
            page1LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExcelPreview).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanelFichier.ResumeLayout(false);
            flowLayoutPanelFichier.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPageFournisseur.ResumeLayout(false);
            panelFour.ResumeLayout(false);
            tableLayoutFour.ResumeLayout(false);
            tableLayoutFour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFournisseur).EndInit();
            tabVueSql.ResumeLayout(false);
            surPanel1VueSql.ResumeLayout(false);
            panelVueSql.ResumeLayout(false);
            tableLayoutPanelVueDb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDBView).EndInit();
            tabGroupe.ResumeLayout(false);
            panelGroupe.ResumeLayout(false);
            tableLayoutGroupe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridGroupe).EndInit();
            tabPageExport.ResumeLayout(false);
            panelExport.ResumeLayout(false);
            tableLayoutPanelExport.ResumeLayout(false);
            tableLayoutPanelExport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel mainPanel;
        private TableLayoutPanel mainTableLayoutPanel;
        private TabControl mainTabControl;
        private TabPage tabExcelSource;
        private TabPage tabVueSql;
        private TableLayoutPanel page1LayoutPanel;
        private DataGridView dataGridExcelPreview;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelRef;
        private Label gencode;
        private Label labelPrixBrut;
        private Label labelPrixNet;
        private TextBox textBoxRefNum;
        private TextBox textBoxRefLib;
        private TextBox textBoxGenNum;
        private TextBox textBoxBrutNum;
        private TextBox textBoxNetNum;
        private TextBox textBoxNetLib;
        private TextBox textBoxBrutLib;
        private TextBox textBoxGenLib;
        private Panel surPanel1VueSql;
        private Panel panelVueSql;
        private TableLayoutPanel tableLayoutPanelVueDb;
        private DataGridView dataGridDBView;
        private Button buttonTestCs;
        private RichTextBox richTextBoxQuery;
        private Button buttonEchantillonQuery;
        private ComboBox comboBoxFeuillesExcel;
        private FlowLayoutPanel flowLayoutPanelFichier;
        private TextBox FichierInsertionPath;
        private Button choixFichierButton;
        private TabPage tabPageFournisseur;
        private TableLayoutPanel tableLayoutFour;
        private Button buttonMakeQuery;
        private RichTextBox richTextBoxQueryFour;
        private Panel panelFour;
        private DataGridView dataGridFournisseur;
        private Button buttonSearchFour;
        private TabPage tabPageExport;
        private Panel panelExport;
        private TableLayoutPanel tableLayoutPanelExport;
        private TextBox textBoxDonneesSocietePath;
        private Button buttonExportExportDonneesSociete;
        private TextBox textBoxInsertionPath;
        private Button buttonSpeederMaj;
        private TabPage tabGroupe;
        private TextBox textBoxDonneesGroupe;
        private Button buttonExportDonneesGroupe;
        private Panel panelGroupe;
        private TableLayoutPanel tableLayoutGroupe;
        private Button buttonGroupe;
        private Button buttonEchantillonGroupe;
        private RichTextBox richTextGroupe;
        private DataGridView dataGridGroupe;
        private TextBox textBoxFourn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelCurseur1;
        private ImageList imageList1;
        private Label labelCurseur2;
        private Label labelCurseur3;
        private Label labelCurseur4;
        private Button buttonExeAllSociete;
        private Button buttonGetAllGroupData;
        private ProgressBar progressBarScte;
        private ProgressBar progressBarGroupe;
        private TextBox textBoxRapportPath;
    }
}
