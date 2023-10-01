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
using TOOLS;
using BLL;
using MySql.Data.MySqlClient;
namespace GUI
{
    public partial class Form2 : Form 
    {
        public static RadioButton[] tablo = new RadioButton[5];
        static int i = 0;
        delegate void del(string ch);
        delegate void del2(TreeNode f);
        public Form2()
        {
            InitializeComponent();
        }

        public void chaine(string vale)
        {
            label1.Text= vale;
            label1.Visible = true;
        }


        public void affiche(TreeNode tg)
        {
            TVP.Nodes.Add(tg);
        }

        private void travail(object sender, DoWorkEventArgs  e)
        {
            if (label1.InvokeRequired)
            {
                del t = new del(chaine);
                label1.Invoke(t,"Chargement des privilèges ...");
            }
            try
            {
                
                MySQL con = new MySQL("localhost", "root", "mysql");
                MySqlDataReader lecteur = con.GetReader("desc user");
                //TVP.CheckBoxes = true;
                TreeNode prv = new TreeNode("Privilèges");
                while (lecteur.Read())
                {

                    char[] f = { '_' };
                    var tab = Convert.ToString(lecteur["Field"]).Split(f);
                    if (tab[tab.Length - 1].ToLower().Equals("priv"))
                    {

                        TreeNode fr = new TreeNode(Convert.ToString(lecteur["Field"]).Remove(Convert.ToString(lecteur["Field"]).Length - 5));
                        prv.Nodes.Add(fr);
                    }

                }
                lecteur.Close();

                con = new MySQL("localhost", "root", "mysql");
                lecteur = con.GetReader("show databases");
                TreeNode trt = new TreeNode("Bases et tables");
                trt.ImageIndex = 2;
                TreeNode trf = null;
                //TVDB.CheckBoxes = true;
                while (lecteur.Read())
                {
                    MySQL con2 = new MySQL("localhost", "root", Convert.ToString(lecteur["database"]));
                    MySqlDataReader lecteur2 = con2.GetReader("show tables");
                    trf = new TreeNode(Convert.ToString(lecteur["database"]));
                    trf.ImageIndex = 2;
                    while (lecteur2.Read())
                    {
                        TreeNode b = new TreeNode(Convert.ToString(lecteur2["Tables_in_" + Convert.ToString(lecteur["database"])]));
                        b.ImageIndex = 1;
                        trf.Nodes.Add(b);
                    }
                    lecteur2.Close();

                    foreach (TreeNode tn in trf.Nodes)
                    {
                        con2 = new MySQL("localhost", "root", Convert.ToString(lecteur["database"]));
                        lecteur2 = con2.GetReader("desc " + tn.Text);
                        while (lecteur2.Read())
                        {
                            TreeNode b = new TreeNode(Convert.ToString(lecteur2["Field"]));
                            b.ImageIndex = 3;
                            tn.Nodes.Add(b);
                        }
                    }
                    lecteur2.Close();

                    trt.Nodes.Add(trf);

                }
                //TVDB.Nodes.Add(trt);
                foreach (TreeNode gf in prv.Nodes)
                {
                    TreeNode fv = (TreeNode)trt.Clone();
                    gf.Nodes.Add(fv);
                }

                if (TVP.InvokeRequired)
                {
                    del2 g = new del2(affiche);
                    TVP.Invoke(g, prv);
                    prv = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fin(object sender, RunWorkerCompletedEventArgs e)
        {
            if (label1.InvokeRequired)
            {
                del t = new del(chaine);
                label1.Invoke(t, "");
            }
            else
            {
                panel1.Visible = false;
            }
                
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("encore");
            TVP.CheckBoxes = true;
            Form2 frm=new Form2();
            backgroundWorker1.DoWork += new DoWorkEventHandler(travail);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(fin);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            foreach (TreeNode eltpriv in TVP.Nodes)
            {
                foreach (TreeNode eltpvi in eltpriv.Nodes)
                {
                    if (eltpvi.Checked == true)
                    {
                       
                        TreeNode pv = new TreeNode(eltpvi.Text);
                        foreach (TreeNode eltb in eltpvi.Nodes)
                        {
                            foreach (TreeNode eltbd in eltb.Nodes)
                            {
                                if (eltbd.Checked == true)
                                {
                                    TreeNode bd = new TreeNode(eltbd.Text);
                                    foreach (TreeNode elttb in eltbd.Nodes)
                                    {
                                        if (elttb.Checked == true)
                                        {
                                            TreeNode tb = new TreeNode(elttb.Text);
                                            foreach (TreeNode eltch in elttb.Nodes)
                                            {
                                                if (eltch.Checked == true)
                                                    tb.Nodes.Add(new TreeNode(eltch.Text));
                                            }
                                            bd.Nodes.Add(tb);
                                        }
                                    }
                                    pv.Nodes.Add(bd);
                                    TreeNode av = (TreeNode)pv.Clone();
             
                                }
                            }
                        }
                    }
                    
                }
            }
        }

        private bool recherche(string val)
        {
            return false ;
        }

       
        private void TVP_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TVP.SelectedNode.Checked == true)
            {
                TVP.SelectedNode.Checked = false;
                foreach (TreeNode te in TVP.SelectedNode.Nodes)
                {
                    te.Checked = false ;
                }
            }
            else
            {
                TVP.SelectedNode.Checked = true;
                foreach (TreeNode te in TVP.SelectedNode.Nodes)
                {
                    te.Checked = true;
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            
        }
        static string query = "Grant ";
        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            string queryg = "";
            bool test = false;

            foreach (TreeNode racpriv in TVP.Nodes)
            {
                foreach (TreeNode priv in racpriv.Nodes)
                {
                    if (priv.Checked == true)
                    {
                        string valpriv = priv.Text;
                        query += priv.Text + "(";
                        foreach (TreeNode racbd in priv.Nodes)
                        {
                            foreach (TreeNode bd in racbd.Nodes)
                            {

                                if (bd.Checked == true)
                                {
                                    foreach (TreeNode tb in bd.Nodes)
                                    {
                                        
                                        if (tb.Checked == true)
                                        {
                                            
                                            foreach (TreeNode champs in tb.Nodes)
                                            {
                                                if (champs.Checked == true)
                                                {
                                                    query += champs.Text + ",";
                                                }
                                            }
                                            if (query.LastOrDefault() == '(')
                                            {
                                                query=query.Remove(query.Length - 1, 1);
                                                query += " on " + bd.Text + "." + tb.Text;
                                                query += " to " + txtLogin.Text + "@" + txtAdresse.Text + " Identified by '" + txtPass.Text + "';";
                                                queryg += query;
                                            }
                                            else
                                            {
                                                query = query.Remove(query.Length - 1, 1);
                                                query += ")" + " on " + bd.Text + "." + tb.Text;
                                                query += " to " + txtLogin.Text + "@" + txtAdresse.Text + " Identified by '" + txtPass.Text + "';";
                                                queryg += query;
                                            }
                                            
                                           
                                            test = true;
                                        }

                                       
                                        query = "Grant " + priv.Text + "(";
                                        
                                    }
                                    if (!test)
                                    {
                                        query = query.Remove(query.Length - 1, 1);
                                        query += " on " + bd.Text + ".*";
                                        query += " to " + txtLogin.Text + "@" + txtAdresse.Text + " Identified by '" + txtPass.Text + "';";
                                        queryg += query;
                                    }
                                    test = false;
                                    
                                }

                                query = "Grant " + priv.Text + "(";
                            }
                        }
                    }

                    
                }
            }

            try
            {
                queryg += "  FLUSH PRIVILEGES";
                MySQL pl = new MySQL("localhost", "root");
                pl.Execute(queryg);
                MessageBox.Show("Utilisateur Crée!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 3)
                i = 0;
            tablo[i].Select();
            i += 1;
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
