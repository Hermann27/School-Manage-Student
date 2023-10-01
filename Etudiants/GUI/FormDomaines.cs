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
    public partial class FormDomaines : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormDomaines()
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

                MessageBox.Show(DomaineManager.Delete(OlEditDomaine), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDomaines_Load (sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static Domaine OlEditDomaine = null;
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
                    
            try
            {
                Domaine NewDomaine = new Domaine(Convert.ToInt32(txtnumDom.Text), txtnomDomaine.Text, DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(DomaineManager.Edit(NewDomaine), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                Domaine CreatDomaine = new Domaine(Convert.ToInt32(txtnumDom.Text), txtnomDomaine.Text, DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(DomaineManager.Add(CreatDomaine), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Domaine ListeDomaine = new Domaine(0);

            DelgueDomaine P = new DelgueDomaine(Charger);
            if (DGV.InvokeRequired)
            {
                DGV.Invoke(P, DomaineManager.Find(ListeDomaine));
            }
            else
            {
                DGV.DataSource = DomaineManager.Find(ListeDomaine);

            }
        }
        delegate void DelgueDomaine(List<Domaine> ListofDomaine);

        private void Charger(List<Domaine> listeDomaine)
        {
            DGV.DataSource = listeDomaine;
            DGV.Columns["NumDom"].Width = 100;
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
            OlEditDomaine = (Domaine)DGV.CurrentRow.DataBoundItem;
            txtnumDom.Text = OlEditDomaine.NumDom.ToString();
            txtnomDomaine .Text = OlEditDomaine.NomDom;
        }

        private void kryptonMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                Domaine Domain = (Domaine)DGV.Rows[i].DataBoundItem;
                if (Domain.NomDom.ToLower().StartsWith(txtSearch.Text.ToLower()))
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

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (txtSearch.Visible == false)
            {
                txtSearch.Visible = true;
                lblsearch.Visible = true;
            }
            else { txtSearch.Visible = false; lblsearch.Visible = false; }
        }
    }
}
