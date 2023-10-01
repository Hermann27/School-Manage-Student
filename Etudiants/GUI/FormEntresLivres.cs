using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BO;
using BLL;
namespace GUI
{
    public partial class FormEntresLivres : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormEntresLivres()
        {
            InitializeComponent();
        }
        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            FormListPrets childForm = new FormListPrets();
            childForm.ShowDialog();
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try{
             
                EntreeLivre  ADDLivre = new EntreeLivre((Entree)CmbFournisseur.SelectedItem,(Livre )CombLivre.SelectedItem,
                                 Convert.ToInt32(txtQte.Text),
                                 Convert.ToDouble(txtPrix.Text), DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(EntreeLivreManager.Add(ADDLivre), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormEntresLivres_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEntresLivres_Load(object sender, EventArgs e)
        {
            TravailArrierPlan.RunWorkerAsync();
                       
        }
        private static EntreeLivre OLLivre = null;
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EntreeLivre NwEtud = new EntreeLivre((Entree)CmbFournisseur.SelectedItem, (Livre)CombLivre.SelectedItem,
                                   Convert.ToInt32(txtQte.Text),
                                   Convert.ToDouble(txtPrix.Text), DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(EntreeLivreManager.Edit(OLLivre, NwEtud), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 FormEntresLivres_Load(sender, e);
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
                MessageBox.Show(EntreeLivreManager.Delete(OLLivre), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        delegate void DELgueLivre(List<EntreeLivre> Listoflivre);

        private void Charger(List<EntreeLivre> listeLivre)
        {
            CmbFournisseur.DataSource = EntreeManager.Find(new Entree(0));
            CmbFournisseur.DisplayMember = "NomFsseur";
            CombLivre.DataSource = LivreManager.Find(new Livre(0));
            CombLivre.DisplayMember = "intitule";           
            DGV.DataSource = listeLivre;
          /*  DGV.Columns["CheminCouv"].Visible = false;
            DGV.Columns["Extension"].Visible = false;
            DGV.Columns["Pu"].Visible = false;
            DGV.Columns["Editeur"].Visible = false;
            DGV.Columns["Stock"].Visible = false;*/
            if (DGV.RowCount > 0)
                DGV.CurrentCell.Selected = false;
            DGV.Cursor = Cursors.AppStarting;
            intialise();

        }
        public void intialise()
        {
            txtQte.Text = "";
            txtPrix.Text = "";
            OLLivre = null;
        }

        private void TravailArrierPlan_DoWork(object sender, DoWorkEventArgs e)
        {
            MySQL Connexion = new MySQL("localhost", "root", "biblio");
            EntreeLivre ListeEntreeLivre = new EntreeLivre(null,null);

            DELgueLivre P = new DELgueLivre(Charger);
            if (DGV.InvokeRequired)
            {
                DGV.Invoke(P, EntreeLivreManager.Find(ListeEntreeLivre));
            }
            else
            {
                DGV.DataSource = EntreeLivreManager.Find(ListeEntreeLivre);

            }
        }
    }
}
