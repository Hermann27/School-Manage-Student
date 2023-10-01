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
using BO;
using DAL;
using System.IO;
namespace GUI
{
    public partial class FormLivre : ComponentFactory.Krypton.Toolkit.KryptonForm  
    {
        public FormLivre()
        {
            InitializeComponent();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                PanelB.Enabled = false;
                PanelB.Visible = false;
            }
            else
            {
                PanelB.Enabled = true;
                PanelB.Visible = true;

            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
 
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                Utilisateur utilisateur = new Utilisateur(1);
                DirectoryInfo Dossier = new DirectoryInfo("PhotoCouverture");
                if (!Dossier.Exists) Dossier.Create();
                Livre NewLivre = new Livre((Domaine)CmbDomaine.SelectedItem, 0, txtisbn.Text, txtintituleLivre.Text, txtauteurLivre.Text, txtediteur.Text,
                                                 Convert.ToInt32(txtStock.Text),
                                                 Convert.ToDouble(txtPrixU.Text),
                                                 txtExtension.Text, "PhotoCouverture\\" + txtisbn.Text, DateTime.Now, DateTime.Now, utilisateur, utilisateur);
                File.Copy(txt_url_couverture.Text, "PhotoCouverture\\" + txtisbn.Text + txtExtension.Text);
                MessageBox.Show(LivreManager.Add(NewLivre), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLivre_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Livre NwEtud = new Livre((Domaine)CmbDomaine.SelectedItem,
                                 Convert.ToInt32(OLLivre.CodeLivre),
                                 txtisbn.Text, txtintituleLivre.Text,
                                 txtauteurLivre.Text, txtediteur.Text,
                                 Convert.ToInt32(txtStock.Text),
                                 Convert.ToDouble(txtPrixU.Text),
                                 txtExtension.Text, "PhotoCouverture\\" + txtisbn.Text, DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(LivreManager.Edit(OLLivre, NwEtud), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string ch = OLLivre.CheminCouv + OLLivre.Extension;
                if (File.Exists(ch))
                {
                    File.Delete(ch);
                    if (txt_url_couverture.Text.Trim() != "")
                        File.Copy(txt_url_couverture.Text, "PhotoCouverture\\" + NwEtud.ISBN  + NwEtud.Extension , false);
                }
                else
                {
                    if (txt_url_couverture.Text.Trim() != "")
                        File.Copy(txt_url_couverture.Text, "PhotoCouverture\\" + NwEtud.ISBN + NwEtud.Extension, false);
                }


                FormLivre_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(LivreManager.Delete(OLLivre), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string ch = OLLivre.CheminCouv + OLLivre.Extension;
                if (File.Exists(ch)) File.Delete(ch);
                FormLivre_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            FormListLivres childForm = new FormListLivres();
            childForm.ShowDialog();
        }
        private static Livre OLLivre=null ;
        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        delegate void DELgueLivre(List<Livre> Listoflivre);

        private void Charger(List<Livre > listeLivre)
        {
            CmbDomaine .DataSource = DomaineManager.Find(new Domaine(0));
            CmbDomaine.DisplayMember = "NomDom";
            DGV.DataSource = listeLivre;
            DGV.Columns["CheminCouv"].Visible = false;
            DGV.Columns["Extension"].Visible = false;
            DGV.Columns["Pu"].Visible = false;
            DGV.Columns["Editeur"].Visible = false;
            DGV.Columns["Stock"].Visible = false;
            if(DGV.RowCount>0)
            DGV.CurrentCell.Selected = false;
            DGV.Cursor = Cursors.AppStarting;
            intialise();

        }
        public void intialise()
        {
            //txtCdeLivre.Text ="";
            txtintituleLivre.Text = "";
            txtisbn.Text = "";
            txtauteurLivre.Text = "";
            txtediteur.Text = "";
            txtPrixU.Text = "";
            txtStock.Text = "";
            pictImage.ImageLocation = "";
            txt_url_couverture.Text = "";
            OLLivre = null;
        }
        private void TravailArrierPlan_DoWork(object sender, DoWorkEventArgs e)
        {
            MySQL Connexion = new MySQL("localhost", "root", "biblio");
            Livre ListeLivre = new Livre(0);

            DELgueLivre P = new DELgueLivre(Charger);
            if (DGV.InvokeRequired)
            {
                DGV.Invoke(P, LivreManager.Find(ListeLivre));
            }
            else
            {
               DGV.DataSource = LivreManager.Find(ListeLivre);
               DGV.Columns["CheminCouvL"].Visible = false;
               DGV.Columns["ExtCouvL"].Visible = false;
               DGV.Columns["PuL"].Visible = false;
               DGV.Columns["EditeurL"].Visible = false;
               DGV.Columns["StockL"].Visible = false;
            }
        }

        private void FormLivre_Load(object sender, EventArgs e)
        {
            TravailArrierPlan.RunWorkerAsync();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers Image (*.JPG)|*.JPG|(*.PNG)|*.PNG";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                txt_url_couverture.Text = FileName;
                txtExtension.Text = Path.GetExtension(FileName).ToString();
                pictImage.ImageLocation = FileName;
            }
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            OLLivre = (Livre)DGV.CurrentRow.DataBoundItem;
            //txtCdeLivre .Text = OLLivre.CodeLivre.ToString() ;
            txtintituleLivre .Text = OLLivre.Intitule ;
            txtisbn.Text = OLLivre.ISBN ;
            txtauteurLivre.Text = OLLivre.Auteur ;
            txtediteur .Text = OLLivre.Editeur ;
            txtPrixU.Text = OLLivre.Pu.ToString() ;
            txtStock.Text = OLLivre.Stock.ToString();
            pictImage.ImageLocation = OLLivre.CheminCouv + OLLivre.Extension;
            CmbDomaine.SelectedItem = OLLivre.domaine.NomDom;
            txt_url_couverture.Text = OLLivre.CheminCouv ;
            txtExtension.Text = OLLivre.Extension;
        }
    }
}
