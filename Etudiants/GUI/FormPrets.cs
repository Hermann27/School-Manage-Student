using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPrets : ComponentFactory.Krypton.Toolkit.KryptonForm 
    {
        public FormPrets()
        {
            InitializeComponent();
        }

        private void FormPrets_Load(object sender, EventArgs e)
        {

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

        }
    }
}
