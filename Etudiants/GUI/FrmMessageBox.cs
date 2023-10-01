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
    public partial class FrmMessageBox : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FrmMessageBox()
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
