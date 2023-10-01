using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using BO;
using System.IO;
namespace GUI
{
    public partial class FormEtudiants : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormEtudiants()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                PanelA.Enabled = false;
                PanelA.Visible = false;
                Panel3.Location = new Point(Panel3.Location.X, ligne1.Location.Y + 12);
            }
            else
            {
                PanelA.Enabled = true;
                PanelA.Visible = true;
                Panel3.Location = new Point(Panel3.Location.X, PanelA.Location.Y + PanelA.Height + 12);
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if( CheckBox2.Checked)
            {
                 PanelB.Enabled = false;
                 PanelB.Visible = false;
            }else
            {
           PanelB.Enabled = true;
           PanelB.Visible = true;

            }
        }


        private void FormEtudiants_Load(object sender, EventArgs e)
        {
            try
            {
                TravailArrierPlan.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }


        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(EtudiantManager.Delete(OLtudiant),"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                string ch = OLtudiant.CheminPhoto + OLtudiant.ExtPhoto;
                if (File.Exists(ch)) File.Delete(ch);

                FormEtudiants_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
     static   Etudiant  OLtudiant=null;
        
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Utilisateur cr = new Utilisateur(1);
                Etudiant NwEtud = new Etudiant((Classe)CmbFiliere.SelectedItem,
                    txtmatricule.Text, txtnom.Text, Sexe,
                    txtphone.Text, cite, txtlieuNaiss.Text, dateNaiss.Value,
                    Path.GetExtension(txt_url_prof.Text),
                    txt_url_prof.Text.Trim() != "" ? "PhotoEtudiants\\" + txtmatricule.Text : "",
                    DateTime.Now, DateTime.Now, cr, cr);
                MessageBox.Show(EtudiantManager.Edit(OLtudiant, NwEtud), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string ch = OLtudiant.CheminPhoto + OLtudiant.ExtPhoto;
                if (File.Exists(ch))
                {
                    File.Delete(ch);
                    if(txt_url_prof.Text.Trim()!="")
                    File.Copy(txt_url_prof.Text, "PhotoEtudiants\\" + NwEtud.Matricule + NwEtud.ExtPhoto, false);
                }
                else 
                {
                    if (txt_url_prof.Text.Trim() != "")
                    File.Copy(txt_url_prof.Text, "PhotoEtudiants\\" + NwEtud.Matricule + NwEtud.ExtPhoto, false);
                }          
                FormEtudiants_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }     
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Utilisateur user=new Utilisateur(1);
                DirectoryInfo Dossier = new DirectoryInfo("PhotoEtudiants");
                if (!Dossier.Exists) Dossier.Create();

                Etudiant ADDEtud = new Etudiant((Classe)CmbFiliere.SelectedItem, txtmatricule.Text,
                    txtnom.Text, Sexe, txtphone.Text, cite, 
                    txtlieuNaiss.Text, dateNaiss.Value, Path.GetExtension(txt_url_prof.Text), 
                    "PhotoEtudiants\\" + txtmatricule.Text,DateTime.Now,DateTime.Now,user,user);
                MessageBox.Show(EtudiantManager.Add(ADDEtud), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Copy(txt_url_prof.Text, "PhotoEtudiants\\" + txtmatricule.Text + Path.GetExtension(txt_url_prof.Text));
                FormEtudiants_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            FormListEtudiants childForm = new FormListEtudiants();
            childForm.ShowDialog();

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers Image (*.JPG)|*.JPG|(*.PNG)|*.PNG";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                txt_url_prof.Text = FileName;
                pictImage.ImageLocation = FileName;
            }
        }
        delegate void DELgueEtudiant(List<Etudiant> ListofEtud);

        private void Charger(List<Etudiant> listeEtud)
        {
            try 
            {
                CmbFiliere.DataSource = ClasseManager.Find(new Classe(null));
                CmbFiliere.DisplayMember = "CodeClasse";
                DGV.DataSource = listeEtud;
                DGV.Columns["CheminPhoto"].Visible = false;
                DGV.Columns["ExtPhoto"].Visible = false;
                DGV.Columns["cite"].Visible = false;
                DGV.Columns["DateNaiss"].Visible = false;
                DGV.Columns["Lieu"].Visible = false;
                DGV.CurrentCell.Selected = false;
                DGV.Cursor = Cursors.AppStarting;
                intialise();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        public  void intialise()
        {
            txtcite.Text = "";
            txtlieuNaiss.Text = "";
            txtmatricule.Text = "";
            txtnom.Text = "";
            txtphone.Text = "";
            txtSexe.Text = "";
            pictImage.ImageLocation = null;
            txt_url_prof.Text = ""; 
            OLtudiant = null;
        }

        public void intialiseEffACE()
        {
            pictImage.ImageLocation = null;
            txt_url_prof.Text = "";
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                MySQL Connexion = new MySQL("localhost", "root", "biblio");
                Etudiant ListeEtudiant = new Etudiant(null);

                DELgueEtudiant P = new DELgueEtudiant(Charger);
                if (DGV.InvokeRequired)
                {
                    DGV.Invoke(P, EtudiantManager.Find(ListeEtudiant));
                }
                else
                {
                    DGV.DataSource = EtudiantManager.Find(ListeEtudiant);
                    DGV.Columns["CheminPhoto"].Visible = false;
                    DGV.Columns["ExtPhoto"].Visible = false;
                    DGV.Columns["cite"].Visible = false;
                    DGV.Columns["DateNaiss"].Visible = false;
                    DGV.Columns["Lieu"].Visible = false;
                  
                }

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void TravailArrierPlan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DGV.Cursor = Cursors.Arrow;
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
            intialise();
        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {
            intialiseEffACE();
        }

        private void FormEtudiants_FormClosing(object sender, FormClosingEventArgs e)
        {
            MDIParent1.childForm = null;
        }

        private void DGV_SelectionChanged_1(object sender, EventArgs e)
        {
            OLtudiant = (Etudiant)DGV.CurrentRow.DataBoundItem;
            if (OLtudiant.cite == "O") {radiobtnOui.Checked=true;}else { radiobtnNon.Checked = true; } 
            dateNaiss.Value = OLtudiant.DateNaiss;
            txtlieuNaiss.Text = OLtudiant.Lieu;
            txtmatricule.Text = OLtudiant.Matricule;
            txtnom.Text = OLtudiant.NomEtud;
            txtphone.Text = OLtudiant.TelEtud;
            txtSexe.Text = OLtudiant.SexeEtud;
            if (OLtudiant.SexeEtud == "M") {  radioBtnMasculin.Checked = true; } else {  radioBtnF.Checked = true; }
            pictImage.ImageLocation = OLtudiant.CheminPhoto + OLtudiant.ExtPhoto;
            txt_url_prof.Text = OLtudiant.CheminPhoto + OLtudiant.ExtPhoto;

        }
        private static string cite;
        private static string Sexe;
        private void radiobtnOui_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnOui.Checked)
            {
                cite = "";
                cite = "O";
            }
        }

        private void radiobtnNon_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnNon.Checked)
            {
                cite = "";
                cite = "N";
            }
        }

        private void radioBtnMasculin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnMasculin.Checked)
            {
                Sexe = "";
                Sexe = "M";
            }
        }

        private void radioBtnF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnF.Checked)
            {
                Sexe = "";
                Sexe = "F";
            }
        }

         }
}
