
namespace Vaja10_SimonPersa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuOpcije = new System.Windows.Forms.MenuStrip();
            this.MenuDatoteka = new System.Windows.Forms.ToolStripMenuItem();
            this.StripNova = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StripOdpri = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.StripIzhod = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUredi = new System.Windows.Forms.ToolStripMenuItem();
            this.StripRazveljavi = new System.Windows.Forms.ToolStripMenuItem();
            this.StripPonovi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.StripKopiraj = new System.Windows.Forms.ToolStripMenuItem();
            this.StripIzrezi = new System.Windows.Forms.ToolStripMenuItem();
            this.StripPrilepi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOblika = new System.Windows.Forms.ToolStripMenuItem();
            this.StripPisava = new System.Windows.Forms.ToolStripMenuItem();
            this.StripBarvaPisave = new System.Windows.Forms.ToolStripMenuItem();
            this.StripBarvaOzadja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StripLevaPoravnava = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSredinskaPoravnava = new System.Windows.Forms.ToolStripMenuItem();
            this.StripDesnaPoravnava = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripOrodnaVrstica = new System.Windows.Forms.ToolStripMenuItem();
            this.StripStatusnaVrstica = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBox = new System.Windows.Forms.ToolStrip();
            this.ToolBoxNova = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBoxOdpri = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxShrani = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBoxRazveljavi = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxPonovi = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxCopy = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxCut = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxPrilepi = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxPisava = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxBarvaPisave = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxBarvaOzadja = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBoxLevaPoravnava = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxSredinskaPoravnava = new System.Windows.Forms.ToolStripButton();
            this.ToolBoxDesnoPoravnajBesedilo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBoxZaklenjeno = new System.Windows.Forms.ToolStripButton();
            this.RichText = new System.Windows.Forms.RichTextBox();
            this.StatusStripInformacije = new System.Windows.Forms.StatusStrip();
            this.StatusSteviloZnakov = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDatum = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColorDialogBarvaOzadja = new System.Windows.Forms.ColorDialog();
            this.ColorDialogBarvaPisave = new System.Windows.Forms.ColorDialog();
            this.FontDialogPisava = new System.Windows.Forms.FontDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuOpcije.SuspendLayout();
            this.ToolBox.SuspendLayout();
            this.StatusStripInformacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOpcije
            // 
            this.MenuOpcije.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuOpcije.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDatoteka,
            this.MenuUredi,
            this.MenuOblika,
            this.pogledToolStripMenuItem});
            this.MenuOpcije.Location = new System.Drawing.Point(0, 0);
            this.MenuOpcije.Name = "MenuOpcije";
            this.MenuOpcije.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuOpcije.Size = new System.Drawing.Size(362, 24);
            this.MenuOpcije.TabIndex = 0;
            this.MenuOpcije.Text = "menuStrip1";
            // 
            // MenuDatoteka
            // 
            this.MenuDatoteka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripNova,
            this.toolStripSeparator1,
            this.StripOdpri,
            this.StripSave,
            this.StripIzhod});
            this.MenuDatoteka.Name = "MenuDatoteka";
            this.MenuDatoteka.Size = new System.Drawing.Size(37, 20);
            this.MenuDatoteka.Text = "File";
            // 
            // StripNova
            // 
            this.StripNova.Image = global::Vaja10_SimonPersa.Properties.Resources.newfile;
            this.StripNova.Name = "StripNova";
            this.StripNova.Size = new System.Drawing.Size(184, 26);
            this.StripNova.Text = "New";
            this.StripNova.Click += new System.EventHandler(this.StripNova_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // StripOdpri
            // 
            this.StripOdpri.Image = global::Vaja10_SimonPersa.Properties.Resources.openfile;
            this.StripOdpri.Name = "StripOdpri";
            this.StripOdpri.Size = new System.Drawing.Size(184, 26);
            this.StripOdpri.Text = "Open";
            this.StripOdpri.Click += new System.EventHandler(this.StripOdpri_Click);
            // 
            // StripSave
            // 
            this.StripSave.Image = global::Vaja10_SimonPersa.Properties.Resources.savefile;
            this.StripSave.Name = "StripSave";
            this.StripSave.Size = new System.Drawing.Size(184, 26);
            this.StripSave.Text = "Save";
            this.StripSave.Click += new System.EventHandler(this.StripSave_Click);
            // 
            // StripIzhod
            // 
            this.StripIzhod.Image = global::Vaja10_SimonPersa.Properties.Resources.exit;
            this.StripIzhod.Name = "StripIzhod";
            this.StripIzhod.Size = new System.Drawing.Size(184, 26);
            this.StripIzhod.Text = "Exit";
            this.StripIzhod.Click += new System.EventHandler(this.StripIzhod_Click);
            // 
            // MenuUredi
            // 
            this.MenuUredi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripRazveljavi,
            this.StripPonovi,
            this.toolStripSeparator7,
            this.StripKopiraj,
            this.StripIzrezi,
            this.StripPrilepi});
            this.MenuUredi.Name = "MenuUredi";
            this.MenuUredi.Size = new System.Drawing.Size(39, 20);
            this.MenuUredi.Text = "Edit";
            // 
            // StripRazveljavi
            // 
            this.StripRazveljavi.Image = global::Vaja10_SimonPersa.Properties.Resources.undo;
            this.StripRazveljavi.Name = "StripRazveljavi";
            this.StripRazveljavi.Size = new System.Drawing.Size(184, 26);
            this.StripRazveljavi.Text = "Undo";
            this.StripRazveljavi.Click += new System.EventHandler(this.StripRazveljavi_Click);
            // 
            // StripPonovi
            // 
            this.StripPonovi.Image = global::Vaja10_SimonPersa.Properties.Resources.redo;
            this.StripPonovi.Name = "StripPonovi";
            this.StripPonovi.Size = new System.Drawing.Size(184, 26);
            this.StripPonovi.Text = "Redo";
            this.StripPonovi.Click += new System.EventHandler(this.StripPonovi_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(181, 6);
            // 
            // StripKopiraj
            // 
            this.StripKopiraj.Image = global::Vaja10_SimonPersa.Properties.Resources.copy;
            this.StripKopiraj.Name = "StripKopiraj";
            this.StripKopiraj.Size = new System.Drawing.Size(184, 26);
            this.StripKopiraj.Text = "Copy";
            this.StripKopiraj.Click += new System.EventHandler(this.StripKopiraj_Click);
            // 
            // StripIzrezi
            // 
            this.StripIzrezi.Image = global::Vaja10_SimonPersa.Properties.Resources.cut;
            this.StripIzrezi.Name = "StripIzrezi";
            this.StripIzrezi.Size = new System.Drawing.Size(184, 26);
            this.StripIzrezi.Text = "Cut";
            this.StripIzrezi.Click += new System.EventHandler(this.StripIzrezi_Click);
            // 
            // StripPrilepi
            // 
            this.StripPrilepi.Image = global::Vaja10_SimonPersa.Properties.Resources.paste;
            this.StripPrilepi.Name = "StripPrilepi";
            this.StripPrilepi.Size = new System.Drawing.Size(184, 26);
            this.StripPrilepi.Text = "Paste";
            this.StripPrilepi.Click += new System.EventHandler(this.StripPrilepi_Click);
            // 
            // MenuOblika
            // 
            this.MenuOblika.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripPisava,
            this.StripBarvaPisave,
            this.StripBarvaOzadja,
            this.toolStripSeparator2,
            this.StripLevaPoravnava,
            this.StripSredinskaPoravnava,
            this.StripDesnaPoravnava});
            this.MenuOblika.Name = "MenuOblika";
            this.MenuOblika.Size = new System.Drawing.Size(51, 20);
            this.MenuOblika.Text = "Shape";
            // 
            // StripPisava
            // 
            this.StripPisava.Image = global::Vaja10_SimonPersa.Properties.Resources.font;
            this.StripPisava.Name = "StripPisava";
            this.StripPisava.Size = new System.Drawing.Size(186, 26);
            this.StripPisava.Text = "Pisava";
            this.StripPisava.Click += new System.EventHandler(this.StripPisava_Click);
            // 
            // StripBarvaPisave
            // 
            this.StripBarvaPisave.Image = global::Vaja10_SimonPersa.Properties.Resources.fontcolor;
            this.StripBarvaPisave.Name = "StripBarvaPisave";
            this.StripBarvaPisave.Size = new System.Drawing.Size(186, 26);
            this.StripBarvaPisave.Text = "Barva Pisave";
            this.StripBarvaPisave.Click += new System.EventHandler(this.StripBarvaPisave_Click);
            // 
            // StripBarvaOzadja
            // 
            this.StripBarvaOzadja.Image = global::Vaja10_SimonPersa.Properties.Resources.bgcolor;
            this.StripBarvaOzadja.Name = "StripBarvaOzadja";
            this.StripBarvaOzadja.Size = new System.Drawing.Size(186, 26);
            this.StripBarvaOzadja.Text = "Barva Ozadja";
            this.StripBarvaOzadja.Click += new System.EventHandler(this.StripBarvaOzadja_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // StripLevaPoravnava
            // 
            this.StripLevaPoravnava.Image = global::Vaja10_SimonPersa.Properties.Resources.alignleft;
            this.StripLevaPoravnava.Name = "StripLevaPoravnava";
            this.StripLevaPoravnava.Size = new System.Drawing.Size(186, 26);
            this.StripLevaPoravnava.Text = "Leva Poravnava";
            this.StripLevaPoravnava.Click += new System.EventHandler(this.StripLevaPoravnava_Click);
            // 
            // StripSredinskaPoravnava
            // 
            this.StripSredinskaPoravnava.Image = global::Vaja10_SimonPersa.Properties.Resources.aligncenter;
            this.StripSredinskaPoravnava.Name = "StripSredinskaPoravnava";
            this.StripSredinskaPoravnava.Size = new System.Drawing.Size(186, 26);
            this.StripSredinskaPoravnava.Text = "Sredinska Poravnava";
            this.StripSredinskaPoravnava.Click += new System.EventHandler(this.StripSredinskaPoravnava_Click);
            // 
            // StripDesnaPoravnava
            // 
            this.StripDesnaPoravnava.Image = global::Vaja10_SimonPersa.Properties.Resources.alignright;
            this.StripDesnaPoravnava.Name = "StripDesnaPoravnava";
            this.StripDesnaPoravnava.Size = new System.Drawing.Size(186, 26);
            this.StripDesnaPoravnava.Text = "Desna Poravnava";
            this.StripDesnaPoravnava.Click += new System.EventHandler(this.StripDesnaPoravnava_Click);
            // 
            // pogledToolStripMenuItem
            // 
            this.pogledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripOrodnaVrstica,
            this.StripStatusnaVrstica});
            this.pogledToolStripMenuItem.Name = "pogledToolStripMenuItem";
            this.pogledToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.pogledToolStripMenuItem.Text = "View";
            // 
            // StripOrodnaVrstica
            // 
            this.StripOrodnaVrstica.Image = global::Vaja10_SimonPersa.Properties.Resources.cross;
            this.StripOrodnaVrstica.Name = "StripOrodnaVrstica";
            this.StripOrodnaVrstica.Size = new System.Drawing.Size(184, 26);
            this.StripOrodnaVrstica.Text = "Orodna Vrstica";
            this.StripOrodnaVrstica.ToolTipText = "Skrij orodno vrstico";
            this.StripOrodnaVrstica.Click += new System.EventHandler(this.StripOrodnaVrstica_Click);
            // 
            // StripStatusnaVrstica
            // 
            this.StripStatusnaVrstica.Image = global::Vaja10_SimonPersa.Properties.Resources.checkmark;
            this.StripStatusnaVrstica.Name = "StripStatusnaVrstica";
            this.StripStatusnaVrstica.Size = new System.Drawing.Size(184, 26);
            this.StripStatusnaVrstica.Text = "Statusna Vrstica";
            this.StripStatusnaVrstica.ToolTipText = "Skrij statusno vrstico";
            this.StripStatusnaVrstica.Click += new System.EventHandler(this.StripStatusnaVrstica_Click);
            // 
            // ToolBox
            // 
            this.ToolBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ToolBox.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBoxNova,
            this.toolStripSeparator3,
            this.ToolBoxOdpri,
            this.ToolBoxShrani,
            this.toolStripSeparator4,
            this.ToolBoxRazveljavi,
            this.ToolBoxPonovi,
            this.ToolBoxCopy,
            this.ToolBoxCut,
            this.ToolBoxPrilepi,
            this.ToolBoxPisava,
            this.ToolBoxBarvaPisave,
            this.ToolBoxBarvaOzadja,
            this.toolStripSeparator5,
            this.ToolBoxLevaPoravnava,
            this.ToolBoxSredinskaPoravnava,
            this.ToolBoxDesnoPoravnajBesedilo,
            this.toolStripSeparator6,
            this.ToolBoxZaklenjeno});
            this.ToolBox.Location = new System.Drawing.Point(0, 24);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Padding = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.ToolBox.Size = new System.Drawing.Size(362, 41);
            this.ToolBox.TabIndex = 1;
            this.ToolBox.Text = "Orodna Vrstica";
            // 
            // ToolBoxNova
            // 
            this.ToolBoxNova.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxNova.Image = global::Vaja10_SimonPersa.Properties.Resources.newfile;
            this.ToolBoxNova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxNova.Name = "ToolBoxNova";
            this.ToolBoxNova.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxNova.Text = "Nova Beležka";
            this.ToolBoxNova.Click += new System.EventHandler(this.ToolBoxNova_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolBoxOdpri
            // 
            this.ToolBoxOdpri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxOdpri.Image = global::Vaja10_SimonPersa.Properties.Resources.openfile;
            this.ToolBoxOdpri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxOdpri.Name = "ToolBoxOdpri";
            this.ToolBoxOdpri.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxOdpri.Text = "Open";
            this.ToolBoxOdpri.Click += new System.EventHandler(this.ToolBoxOdpri_Click);
            // 
            // ToolBoxShrani
            // 
            this.ToolBoxShrani.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxShrani.Image = global::Vaja10_SimonPersa.Properties.Resources.savefile;
            this.ToolBoxShrani.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxShrani.Name = "ToolBoxShrani";
            this.ToolBoxShrani.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxShrani.Text = "Save";
            this.ToolBoxShrani.Click += new System.EventHandler(this.ToolBoxShrani_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolBoxRazveljavi
            // 
            this.ToolBoxRazveljavi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxRazveljavi.Image = ((System.Drawing.Image)(resources.GetObject("ToolBoxRazveljavi.Image")));
            this.ToolBoxRazveljavi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxRazveljavi.Name = "ToolBoxRazveljavi";
            this.ToolBoxRazveljavi.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxRazveljavi.Text = "Undo";
            this.ToolBoxRazveljavi.Click += new System.EventHandler(this.ToolBoxRazveljavi_Click);
            // 
            // ToolBoxPonovi
            // 
            this.ToolBoxPonovi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxPonovi.Image = ((System.Drawing.Image)(resources.GetObject("ToolBoxPonovi.Image")));
            this.ToolBoxPonovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxPonovi.Name = "ToolBoxPonovi";
            this.ToolBoxPonovi.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxPonovi.Text = "Redo";
            this.ToolBoxPonovi.Click += new System.EventHandler(this.ToolBoxPonovi_Click);
            // 
            // ToolBoxCopy
            // 
            this.ToolBoxCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxCopy.Image = ((System.Drawing.Image)(resources.GetObject("ToolBoxCopy.Image")));
            this.ToolBoxCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxCopy.Name = "ToolBoxCopy";
            this.ToolBoxCopy.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxCopy.Text = "Copy";
            this.ToolBoxCopy.Click += new System.EventHandler(this.ToolBoxCopy_Click);
            // 
            // ToolBoxCut
            // 
            this.ToolBoxCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxCut.Image = ((System.Drawing.Image)(resources.GetObject("ToolBoxCut.Image")));
            this.ToolBoxCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxCut.Name = "ToolBoxCut";
            this.ToolBoxCut.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxCut.Text = "Cut";
            this.ToolBoxCut.Click += new System.EventHandler(this.ToolBoxCut_Click);
            // 
            // ToolBoxPrilepi
            // 
            this.ToolBoxPrilepi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxPrilepi.Image = ((System.Drawing.Image)(resources.GetObject("ToolBoxPrilepi.Image")));
            this.ToolBoxPrilepi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxPrilepi.Name = "ToolBoxPrilepi";
            this.ToolBoxPrilepi.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxPrilepi.Text = "Paste";
            this.ToolBoxPrilepi.Click += new System.EventHandler(this.ToolBoxPrilepi_Click);
            // 
            // ToolBoxPisava
            // 
            this.ToolBoxPisava.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxPisava.Image = global::Vaja10_SimonPersa.Properties.Resources.font;
            this.ToolBoxPisava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxPisava.Name = "ToolBoxPisava";
            this.ToolBoxPisava.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxPisava.Text = "Font";
            this.ToolBoxPisava.Click += new System.EventHandler(this.ToolBoxPisava_Click);
            // 
            // ToolBoxBarvaPisave
            // 
            this.ToolBoxBarvaPisave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxBarvaPisave.Image = global::Vaja10_SimonPersa.Properties.Resources.fontcolor;
            this.ToolBoxBarvaPisave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxBarvaPisave.Name = "ToolBoxBarvaPisave";
            this.ToolBoxBarvaPisave.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxBarvaPisave.Text = "Font Color";
            this.ToolBoxBarvaPisave.Click += new System.EventHandler(this.ToolBoxBarvaPisave_Click);
            // 
            // ToolBoxBarvaOzadja
            // 
            this.ToolBoxBarvaOzadja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxBarvaOzadja.Image = global::Vaja10_SimonPersa.Properties.Resources.bgcolor;
            this.ToolBoxBarvaOzadja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxBarvaOzadja.Name = "ToolBoxBarvaOzadja";
            this.ToolBoxBarvaOzadja.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxBarvaOzadja.Text = "Background Color";
            this.ToolBoxBarvaOzadja.Click += new System.EventHandler(this.ToolBoxBarvaOzadja_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolBoxLevaPoravnava
            // 
            this.ToolBoxLevaPoravnava.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxLevaPoravnava.Image = global::Vaja10_SimonPersa.Properties.Resources.alignleft;
            this.ToolBoxLevaPoravnava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxLevaPoravnava.Name = "ToolBoxLevaPoravnava";
            this.ToolBoxLevaPoravnava.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxLevaPoravnava.Text = "Align Left";
            this.ToolBoxLevaPoravnava.Click += new System.EventHandler(this.ToolBoxLevaPoravnava_Click);
            // 
            // ToolBoxSredinskaPoravnava
            // 
            this.ToolBoxSredinskaPoravnava.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxSredinskaPoravnava.Image = global::Vaja10_SimonPersa.Properties.Resources.aligncenter;
            this.ToolBoxSredinskaPoravnava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxSredinskaPoravnava.Name = "ToolBoxSredinskaPoravnava";
            this.ToolBoxSredinskaPoravnava.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxSredinskaPoravnava.Text = "Align Middle";
            this.ToolBoxSredinskaPoravnava.Click += new System.EventHandler(this.ToolBoxSredinskaPoravnava_Click);
            // 
            // ToolBoxDesnoPoravnajBesedilo
            // 
            this.ToolBoxDesnoPoravnajBesedilo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxDesnoPoravnajBesedilo.Image = global::Vaja10_SimonPersa.Properties.Resources.alignright;
            this.ToolBoxDesnoPoravnajBesedilo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxDesnoPoravnajBesedilo.Name = "ToolBoxDesnoPoravnajBesedilo";
            this.ToolBoxDesnoPoravnajBesedilo.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxDesnoPoravnajBesedilo.Text = "Align Right";
            this.ToolBoxDesnoPoravnajBesedilo.Click += new System.EventHandler(this.ToolBoxDesnoPoravnajBesedilo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolBoxZaklenjeno
            // 
            this.ToolBoxZaklenjeno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBoxZaklenjeno.Image = global::Vaja10_SimonPersa.Properties.Resources.locked;
            this.ToolBoxZaklenjeno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBoxZaklenjeno.Name = "ToolBoxZaklenjeno";
            this.ToolBoxZaklenjeno.Size = new System.Drawing.Size(36, 36);
            this.ToolBoxZaklenjeno.Text = "Lock";
            this.ToolBoxZaklenjeno.Click += new System.EventHandler(this.ToolBoxZaklenjeno_Click);
            // 
            // RichText
            // 
            this.RichText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichText.Location = new System.Drawing.Point(0, 65);
            this.RichText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RichText.Name = "RichText";
            this.RichText.Size = new System.Drawing.Size(362, 303);
            this.RichText.TabIndex = 2;
            this.RichText.Text = "";
            this.RichText.TextChanged += new System.EventHandler(this.RichText_TextChanged);
            // 
            // StatusStripInformacije
            // 
            this.StatusStripInformacije.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStripInformacije.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusSteviloZnakov,
            this.StatusDatum});
            this.StatusStripInformacije.Location = new System.Drawing.Point(0, 346);
            this.StatusStripInformacije.Name = "StatusStripInformacije";
            this.StatusStripInformacije.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusStripInformacije.Size = new System.Drawing.Size(362, 22);
            this.StatusStripInformacije.TabIndex = 3;
            this.StatusStripInformacije.Text = "Statusna Vrstica";
            // 
            // StatusSteviloZnakov
            // 
            this.StatusSteviloZnakov.Name = "StatusSteviloZnakov";
            this.StatusSteviloZnakov.Size = new System.Drawing.Size(87, 17);
            this.StatusSteviloZnakov.Text = "Characters: 0 |  ";
            this.StatusSteviloZnakov.Click += new System.EventHandler(this.StatusSteviloZnakov_Click);
            // 
            // StatusDatum
            // 
            this.StatusDatum.Name = "StatusDatum";
            this.StatusDatum.Size = new System.Drawing.Size(0, 17);
            // 
            // ColorDialogBarvaOzadja
            // 
            this.ColorDialogBarvaOzadja.FullOpen = true;
            // 
            // ColorDialogBarvaPisave
            // 
            this.ColorDialogBarvaPisave.FullOpen = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Shrani svojo beležko";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.StatusStripInformacije);
            this.Controls.Add(this.RichText);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.MenuOpcije);
            this.MainMenuStrip = this.MenuOpcije;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyNote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuOpcije.ResumeLayout(false);
            this.MenuOpcije.PerformLayout();
            this.ToolBox.ResumeLayout(false);
            this.ToolBox.PerformLayout();
            this.StatusStripInformacije.ResumeLayout(false);
            this.StatusStripInformacije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOpcije;
        private System.Windows.Forms.ToolStripMenuItem MenuDatoteka;
        private System.Windows.Forms.ToolStripMenuItem StripNova;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem StripOdpri;
        private System.Windows.Forms.ToolStripMenuItem StripSave;
        private System.Windows.Forms.ToolStripMenuItem StripIzhod;
        private System.Windows.Forms.ToolStripMenuItem MenuOblika;
        private System.Windows.Forms.ToolStripMenuItem StripPisava;
        private System.Windows.Forms.ToolStripMenuItem StripBarvaPisave;
        private System.Windows.Forms.ToolStripMenuItem StripBarvaOzadja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem StripLevaPoravnava;
        private System.Windows.Forms.ToolStripMenuItem StripSredinskaPoravnava;
        private System.Windows.Forms.ToolStripMenuItem pogledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripDesnaPoravnava;
        private System.Windows.Forms.ToolStripMenuItem StripOrodnaVrstica;
        private System.Windows.Forms.ToolStripMenuItem StripStatusnaVrstica;
        private System.Windows.Forms.ToolStrip ToolBox;
        private System.Windows.Forms.ToolStripButton ToolBoxNova;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ToolBoxOdpri;
        private System.Windows.Forms.ToolStripButton ToolBoxShrani;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ToolBoxPisava;
        private System.Windows.Forms.ToolStripButton ToolBoxBarvaPisave;
        private System.Windows.Forms.ToolStripButton ToolBoxBarvaOzadja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ToolBoxLevaPoravnava;
        private System.Windows.Forms.ToolStripButton ToolBoxSredinskaPoravnava;
        private System.Windows.Forms.ToolStripButton ToolBoxDesnoPoravnajBesedilo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ToolBoxZaklenjeno;
        private System.Windows.Forms.RichTextBox RichText;
        private System.Windows.Forms.StatusStrip StatusStripInformacije;
        private System.Windows.Forms.ToolStripStatusLabel StatusSteviloZnakov;
        private System.Windows.Forms.ToolStripStatusLabel StatusDatum;
        private System.Windows.Forms.ColorDialog ColorDialogBarvaOzadja;
        private System.Windows.Forms.ColorDialog ColorDialogBarvaPisave;
        private System.Windows.Forms.FontDialog FontDialogPisava;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem MenuUredi;
        private System.Windows.Forms.ToolStripMenuItem StripRazveljavi;
        private System.Windows.Forms.ToolStripMenuItem StripPonovi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem StripKopiraj;
        private System.Windows.Forms.ToolStripMenuItem StripIzrezi;
        private System.Windows.Forms.ToolStripMenuItem StripPrilepi;
        private System.Windows.Forms.ToolStripButton ToolBoxRazveljavi;
        private System.Windows.Forms.ToolStripButton ToolBoxPonovi;
        private System.Windows.Forms.ToolStripButton ToolBoxCut;
        private System.Windows.Forms.ToolStripButton ToolBoxCopy;
        private System.Windows.Forms.ToolStripButton ToolBoxPrilepi;
    }
}

