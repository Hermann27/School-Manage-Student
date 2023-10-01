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
using BLL;
using BO;
namespace GUI
{
    public partial class FormListEtudiants : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormListEtudiants()
        {
            InitializeComponent();
        }

        
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if( CheckBox2.Checked)
            {
                 PanelB.Enabled = false;
                 PanelB.Visible = false;
                 pictureALL.Visible = false;
            }else
            {
           PanelB.Enabled = true;
           PanelB.Visible = true;
           pictureALL.Visible = true;

            }
        }


        private void FormEtudiants_Load(object sender, EventArgs e)
        {
            TravailArrierPlan.RunWorkerAsync();
          
        }
        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        delegate void DELgueEtudiant(List<Etudiant> ListofEtud);

        private void Charger(List<Etudiant> listeEtud)
        {
            
            DGV.DataSource = listeEtud;
            lblnombre.Text = Convert.ToString(DGV.Rows.Count);
             
        }
        private void TravailArrierPlan_DoWork(object sender, DoWorkEventArgs e)
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
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                Etudiant Etud = (Etudiant)DGV.Rows[i].DataBoundItem;
                if (Etud.Matricule.ToLower().StartsWith(txtSearch.Text.ToLower()) || Etud.classe.CodeClasse.ToLower().StartsWith(txtSearch.Text.ToLower()) || Etud.NomEtud.ToLower().StartsWith(txtSearch.Text.ToLower()))
                {
                    DGV.CurrentCell = DGV.Rows[i].Cells[0];
                    DGV.Rows[i].Selected = true;
                    pictureALL.ImageLocation = Etud.CheminPhoto + Etud.ExtPhoto;
                    break;
                }
                else
                {
                    DGV.Rows[i].Selected = false;
                    pictureALL.ImageLocation = null;
                                   
                }
            }

            if (txtSearch.Text == "")
            {
                DGV.Rows[0].Selected = false;
                pictureALL.ImageLocation = null;
            }
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FormDetails Chilrm = new FormDetails();
            Chilrm.ShowDialog();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Form FrCrystal = new Form();
            FrCrystal.ShowDialog();
        }
    }
}
