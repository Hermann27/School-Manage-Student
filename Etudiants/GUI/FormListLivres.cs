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
namespace GUI
{
    public partial class FormListLivres : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormListLivres()
        {
            InitializeComponent();
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
        delegate void DELgueLivre(List<Livre> Listoflivre);

        private void Charger(List<Livre> Listoflivre)
        {

            double Montat=0;
            DGV.DataSource = Listoflivre;
            
            for (int j = 0; j < DGV.Rows.Count; j++) 
            {
                Montat += Convert.ToDouble(DGV.Rows[j].Cells["Pu"].Value);
 
            }
            lblsms.Text = Convert.ToString(DGV.Rows.Count);
            lblmontantT.Text  = Convert.ToString(Montat);
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
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                Livre Livre = (Livre)DGV.Rows[i].DataBoundItem;
                if (Livre.CodeLivre.ToString().ToLower().StartsWith(txtSearch.Text.ToLower()) || Livre.Auteur.ToLower().StartsWith(txtSearch.Text.ToLower()) || Livre.Stock.ToString().ToLower().StartsWith(txtSearch.Text.ToLower()))
                {
                    DGV.CurrentCell = DGV.Rows[i].Cells[0];
                    DGV.Rows[i].Selected = true;
                    pictureALL.ImageLocation = Livre.CheminCouv + Livre.Extension;
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
    }
}
