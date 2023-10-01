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
    public partial class FormFournisseur : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormFournisseur()
        {
            InitializeComponent();
        }
        private void FormDomaines_Load(object sender, EventArgs e)
        {
           // PanelB.Visible = false;
            TravailArrierPlan.RunWorkerAsync();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            
            try
            { 

                MessageBox.Show(EntreeManager.Delete(OlEditDomaine), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDomaines_Load (sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static Entree OlEditDomaine = null;
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
                    
            try
            {
                Entree NewEntree = new Entree(Convert.ToInt32(txtnumDom.Text), datebord.Value, txtnomDomaine.Text, DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(EntreeManager.Edit(OlEditDomaine,NewEntree), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDomaines_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Entree CreatEntree = new Entree(0,datebord.Value, txtnomDomaine.Text, DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(EntreeManager.Add(CreatEntree), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDomaines_Load (sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void TravailArrierPlan_DoWork(object sender, DoWorkEventArgs e)
        {
            MySQL Connexion = new MySQL("localhost", "root", "biblio");
            Entree ListeEntree = new Entree(0);

            DelgueDomaine P = new DelgueDomaine(Charger);
            if (DGV.InvokeRequired)
            {
                DGV.Invoke(P, EntreeManager.Find(ListeEntree));
            }
            else
            {
                DGV.DataSource = EntreeManager.Find(ListeEntree);

            }
        }
        delegate void DelgueDomaine(List<Entree> ListoEntree);

        private void Charger(List<Entree> ListoEntree)
        {
            DGV.DataSource = ListoEntree;
            //DGV.Columns["NumDom"].Width = 100;
            if(DGV.RowCount>0)
            DGV.CurrentCell.Selected = false;
            DGV.Cursor = Cursors.AppStarting;
            intialise();

        }
        public void intialise()
        {
             txtnumDom.Text = "";
            txtnomDomaine.Text = "";
            OlEditDomaine = null;
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            OlEditDomaine = (Entree)DGV.CurrentRow.DataBoundItem;
            datebord.Value  = OlEditDomaine.DateBord;
            txtnomDomaine .Text = OlEditDomaine.NomFsseur ;
        }

        private void kryptonMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                Entree Domain = (Entree)DGV.Rows[i].DataBoundItem;
                if (Domain.NomFsseur.ToLower().StartsWith(txtSearch.Text.ToLower()))
                {
                    DGV.CurrentCell = DGV.Rows[i].Cells[0];
                    DGV.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    if (txtSearch.Text == "")
                    {
                        DGV.Rows[i].Selected = false;
                    }
                    DGV.Rows[i].Selected = false;

                }
            }
        }
    }
}
