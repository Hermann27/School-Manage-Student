using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using DAL;
using BLL;
namespace GUI
{
    public partial class FormClasses : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FormClasses()
        {
            InitializeComponent();
        }


        private void FormClasses_Load(object sender, EventArgs e)
        {
            //PanelB.Visible = false;
            TravailArrierPlan.RunWorkerAsync();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Classe CreateClass = new Classe(txtCdeclasse.Text, txtintituleclasse.Text,DateTime.Now,DateTime.Now,new Utilisateur(1),new Utilisateur(1));
                MessageBox.Show(ClasseManager.Add(CreateClass), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClasses_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static Classe OlEditClass = null;
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Classe NewClass = new Classe(txtCdeclasse.Text, txtintituleclasse.Text, DateTime.Now, DateTime.Now, new Utilisateur(1), new Utilisateur(1));
                MessageBox.Show(ClasseManager.Edit(OlEditClass, NewClass), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClasses_Load(sender, e);
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
                MessageBox.Show(ClasseManager.Delete(OlEditClass), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClasses_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Classe ListeClasse = new Classe(null);

            DelgueClasse P = new DelgueClasse(Charger);
            if (DGV.InvokeRequired)
            {
                DGV.Invoke(P, ClasseManager.Find(ListeClasse));
            }
            else
            {
                DGV.DataSource = ClasseManager.Find(ListeClasse);

            }
        }
        delegate void DelgueClasse(List<Classe> ListofClasse);

        private void Charger(List<Classe> listeClasse)
        {
            DGV.DataSource = listeClasse;
            DGV.Columns["CodeClasse"].Width = 100; 
            DGV.CurrentCell.Selected = false;
            DGV.Cursor = Cursors.AppStarting;
            intialise();

        }
        public void intialise()
        {
            txtCdeclasse.Text = "";
            txtintituleclasse.Text = "";
            OlEditClass = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                Classe Class = (Classe)DGV.Rows[i].DataBoundItem;
                if (Class.CodeClasse.ToLower().StartsWith(txtSearch.Text.ToLower()) || Class.Libele.ToLower().StartsWith(txtSearch.Text.ToLower()))
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

        private void DGV_SelectionChanged_1(object sender, EventArgs e)
        {
            OlEditClass = (Classe)DGV.CurrentRow.DataBoundItem;
            txtCdeclasse.Text = OlEditClass.CodeClasse;
            txtintituleclasse.Text = OlEditClass.Libele;
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (txtSearch.Visible == false)
            {
                txtSearch.Visible = true;
                lblsearch.Visible  = true;
            }
            else { txtSearch.Visible = false; lblsearch.Visible = false; }
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            //Form1 FrCrystal = new Form1();
            //FrCrystal.ShowDialog();
        }
    }
}
