using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja10_SimonPersa
{
    public partial class Form1 : Form
    {
        bool Odklenjeno;
        bool shrani;
        bool orodnavrstica;
        bool statusnavrsica;
        public Form1()
        {
            InitializeComponent();
        }

        void shraniDatoteko()
        {
            saveFileDialog.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
            saveFileDialog.FileName = "BeležkovDokument.rtf";
            saveFileDialog.OverwritePrompt = true;
            DialogResult result = saveFileDialog.ShowDialog();



            if (result == DialogResult.OK)
            {
                FileStream s;
                StreamWriter sw;

                s = File.Open(saveFileDialog.FileName, FileMode.Create);
                sw = new StreamWriter(s);
                sw.WriteLine(RichText.Rtf);
                sw.Close();
                s.Close();

            }

        }

        void odpriDatoteko()
        {
            openFileDialog.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichText.Rtf = File.ReadAllText(openFileDialog.FileName);
                RichText.SelectionStart = RichText.Text.Length - 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Odklenjeno = true;
            shrani = false;
            orodnavrstica = false;
            statusnavrsica = true;
            StatusDatum.Text = DateTime.Now.ToString("dd.MMMM.yyyy");
        }

        private void ToolBoxZaklenjeno_Click(object sender, EventArgs e)
        {
            if(Odklenjeno == true)
            {
                ToolBoxZaklenjeno.Image = Properties.Resources.lockopne;
                ToolBoxZaklenjeno.ToolTipText = "Odkleni Orodno Vrstico";
                ToolBoxNova.Enabled = false;
                ToolBoxNova.Enabled = false;
                ToolBoxShrani.Enabled = false;
                ToolBoxPisava.Enabled = false;
                ToolBoxBarvaOzadja.Enabled = false;
                ToolBoxBarvaPisave.Enabled = false;
                ToolBoxDesnoPoravnajBesedilo.Enabled = false;
                ToolBoxLevaPoravnava.Enabled = false;
                ToolBoxDesnoPoravnajBesedilo.Enabled = false;
                ToolBoxOdpri.Enabled = false;
                ToolBoxSredinskaPoravnava.Enabled = false;
                ToolBoxRazveljavi.Enabled = false;
                ToolBoxPonovi.Enabled = false;
                ToolBoxCopy.Enabled = false;
                ToolBoxCut.Enabled = false;
                ToolBoxPrilepi.Enabled = false;
                Odklenjeno = false;
            }
            else if(Odklenjeno == false)
            {
                ToolBoxZaklenjeno.Image = Properties.Resources.locked;
                ToolBoxZaklenjeno.ToolTipText = "Zakleni Orodno Vrstico";

                ToolBoxNova.Enabled = true;
                ToolBoxShrani.Enabled = true;
                ToolBoxPisava.Enabled = true;
                ToolBoxBarvaOzadja.Enabled = true;
                ToolBoxBarvaPisave.Enabled = true;
                ToolBoxDesnoPoravnajBesedilo.Enabled = true;
                ToolBoxLevaPoravnava.Enabled = true;
                ToolBoxDesnoPoravnajBesedilo.Enabled = true;
                ToolBoxOdpri.Enabled = true;
                ToolBoxSredinskaPoravnava.Enabled = true;
                ToolBoxRazveljavi.Enabled = true;
                ToolBoxPonovi.Enabled = true;
                ToolBoxCopy.Enabled = true;
                ToolBoxCut.Enabled = true;
                ToolBoxPrilepi.Enabled = true;
                

                Odklenjeno = true;
            }
        }

        private void RichText_TextChanged(object sender, EventArgs e)
        {
            shrani = true;
            StatusSteviloZnakov.Text = "Characters: " + RichText.TextLength + " | ";
        }

        private void ToolBoxLevaPoravnava_Click(object sender, EventArgs e)
        {
            RichText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ToolBoxSredinskaPoravnava_Click(object sender, EventArgs e)
        {
            RichText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ToolBoxDesnoPoravnajBesedilo_Click(object sender, EventArgs e)
        {
            RichText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void StripLevaPoravnava_Click(object sender, EventArgs e)
        {
            RichText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void StripSredinskaPoravnava_Click(object sender, EventArgs e)
        {
            RichText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void StripDesnaPoravnava_Click(object sender, EventArgs e)
        {
            RichText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ToolBoxBarvaOzadja_Click(object sender, EventArgs e)
        {
            DialogResult barva = ColorDialogBarvaOzadja.ShowDialog();
            if(barva == DialogResult.OK && RichText.SelectedText.Length>0)
            {
                RichText.SelectionColor = ColorDialogBarvaOzadja.Color;
            }
            else
            {
                RichText.BackColor = ColorDialogBarvaOzadja.Color;
            }
            
        }

        private void StripBarvaOzadja_Click(object sender, EventArgs e)
        {
            DialogResult barva = ColorDialogBarvaOzadja.ShowDialog();
            if (barva == DialogResult.OK && RichText.SelectedText.Length > 0)
            {
                RichText.SelectionColor = ColorDialogBarvaOzadja.Color;
            }
            else
            {
                RichText.BackColor = ColorDialogBarvaOzadja.Color;
            }
        }

        private void ToolBoxBarvaPisave_Click(object sender, EventArgs e)
        {
            DialogResult BarvaPisave = ColorDialogBarvaPisave.ShowDialog();
            if(BarvaPisave == DialogResult.OK && RichText.SelectedText.Length > 0)
            {
                RichText.SelectionColor = ColorDialogBarvaPisave.Color;
            }
            else
            {
                RichText.BackColor = ColorDialogBarvaPisave.Color;
            }
        }

        private void StripBarvaPisave_Click(object sender, EventArgs e)
        {
            DialogResult BarvaPisave = ColorDialogBarvaPisave.ShowDialog();
            if (BarvaPisave == DialogResult.OK && RichText.SelectedText.Length > 0)
            {
                RichText.SelectionColor = ColorDialogBarvaPisave.Color;
            }
            else
            {
                RichText.BackColor = ColorDialogBarvaPisave.Color;
            }
        }

        private void ToolBoxPisava_Click(object sender, EventArgs e)
        {
            DialogResult OblikaPisave = FontDialogPisava.ShowDialog();
            if(OblikaPisave == DialogResult.OK && RichText.SelectedText.Length > 0)
            {
                RichText.SelectionFont = FontDialogPisava.Font;
            }
            else
            {
                RichText.Font = FontDialogPisava.Font;
            }
        }

        private void StripPisava_Click(object sender, EventArgs e)
        {
            DialogResult OblikaPisave = FontDialogPisava.ShowDialog();
            if (OblikaPisave == DialogResult.OK && RichText.SelectedText.Length > 0)
            {
                RichText.SelectionFont = FontDialogPisava.Font;
            }
            else
            {
                RichText.Font = FontDialogPisava.Font;
            }
        }

        private void ToolBoxOdpri_Click(object sender, EventArgs e)
        {
            
            odpriDatoteko();
            shrani = false;
        }

        private void ToolBoxShrani_Click(object sender, EventArgs e)
        {
            shraniDatoteko();
        }

        private void ToolBoxNova_Click(object sender, EventArgs e)
        {
            if(shrani == true)
            {
               DialogResult r =  MessageBox.Show("Ali želiš shraniti spremembe?", "Beležko", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(r == DialogResult.Yes)
                {
                    shraniDatoteko();
                    shrani = false;
                }
                else if(r == DialogResult.No)
                {
                    RichText.Clear();
                    shrani = false;
                }
                else
                {
                    //
                }
            }
        }

        private void StripNova_Click(object sender, EventArgs e)
        {
            if (shrani == true)
            {
                DialogResult r = MessageBox.Show("Ali želiš shraniti spremembe?", "Beležko", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    shraniDatoteko();
                    shrani = false;
                }
                else if (r == DialogResult.No)
                {
                    RichText.Clear();
                    shrani = false;
                }
                else
                {
                    //
                }
            }
        }

        private void StripIzhod_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Ali želiš shraniti spremembe?", "Beležko", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                shraniDatoteko();
                shrani = false;
            }
            else if (r == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void StripOdpri_Click(object sender, EventArgs e)
        {
            odpriDatoteko();
            shrani = false;
        }

        private void StripSave_Click(object sender, EventArgs e)
        {
            shraniDatoteko();
        }

        private void StripOrodnaVrstica_Click(object sender, EventArgs e)
        {
            if(orodnavrstica == false)
            {
                StripOrodnaVrstica.Image = Properties.Resources.checkmark;
                RichText.Size = new Size(484, 379);
                ToolBox.Visible = false;
                StripOrodnaVrstica.ToolTipText = "Prikaži orodno vrstico";
                orodnavrstica = true;
            }
            else if(orodnavrstica == true)
            {
                StripOrodnaVrstica.Image = Properties.Resources.cross;
                RichText.Size = new Size(482, 383);
                ToolBox.Visible = true;
                StripOrodnaVrstica.ToolTipText = "Skrij orodno vrstico";
                orodnavrstica = false;
            }

        }

        private void StripStatusnaVrstica_Click(object sender, EventArgs e)
        {
            if(statusnavrsica == false)
            {
                StatusStripInformacije.Visible = true;
                StripStatusnaVrstica.ToolTipText = "Skrij statusno vrstico";
                StripStatusnaVrstica.Image = Properties.Resources.checkmark;
                statusnavrsica = true;
            }
            else if(statusnavrsica == true)
            {
                StatusStripInformacije.Visible = false;
                StripStatusnaVrstica.ToolTipText = "Prikazi statusno vrstico";
                StripStatusnaVrstica.Image = Properties.Resources.cross;
                statusnavrsica = false;
            }
        }

        private void ToolBoxCopy_Click(object sender, EventArgs e)
        {
            RichText.Copy();
        }

        private void StripKopiraj_Click(object sender, EventArgs e)
        {
            RichText.Copy();
        }

        private void StripRazveljavi_Click(object sender, EventArgs e)
        {
            RichText.Undo();
        }

        private void ToolBoxRazveljavi_Click(object sender, EventArgs e)
        {
            RichText.Undo();
        }

        private void ToolBoxPonovi_Click(object sender, EventArgs e)
        {
            RichText.Redo();
        }

        private void StripPonovi_Click(object sender, EventArgs e)
        {
            RichText.Redo();
        }

        private void StripIzrezi_Click(object sender, EventArgs e)
        {
            RichText.Cut();
        }

        private void ToolBoxCut_Click(object sender, EventArgs e)
        {
            RichText.Cut();
        }

        private void ToolBoxPrilepi_Click(object sender, EventArgs e)
        {
            RichText.Paste();
        }

        private void StripPrilepi_Click(object sender, EventArgs e)
        {
            RichText.Paste();
        }

        private void StatusSteviloZnakov_Click(object sender, EventArgs e)
        {

        }
    }
}
