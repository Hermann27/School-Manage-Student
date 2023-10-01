using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DAL;
using BLL;
using TOOLS;
using BO;
namespace GUI
{
    public partial class FormDetails : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            FrmMessageBox call=new FrmMessageBox();
            call.ShowDialog();
            Form FrCrystal = new Form();
            FrCrystal.ShowDialog();
        }


            //try
            //{
            //    MySQL mysql = new MySQL("localhost","root","biblio");
            //    dataGridView1.DataSource = ClasseDAO.Find(new Classe(""));
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message );
            //
    }
}
