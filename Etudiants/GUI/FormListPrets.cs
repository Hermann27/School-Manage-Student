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
namespace GUI
{
    public partial class FormListPrets : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormListPrets()
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
           // Etudiant ListeEtudiant = new Etudiant("");
           // DGV.DataSource = EtudiantManager.Find(ListeEtudiant);
        }

        

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
