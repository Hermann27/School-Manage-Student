namespace GUI
{
    partial class FormClasses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Panel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PanelB = new System.Windows.Forms.Panel();
            this.DGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblsearch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label12 = new System.Windows.Forms.Label();
            this.PanelA = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelServeur = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtCdeclasse = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtintituleclasse = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.ligne1 = new System.Windows.Forms.Panel();
            this.TravailArrierPlan = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.KPanel1)).BeginInit();
            this.KPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).BeginInit();
            this.Panel3.SuspendLayout();
            this.PanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.PanelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelServeur)).BeginInit();
            this.panelServeur.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(290, 28);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(299, 36);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.kryptonLabel1.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 29;
            this.kryptonLabel1.Values.Text = "Gestion des Etudiants";
            // 
            // KPanel1
            // 
            this.KPanel1.Controls.Add(this.Panel3);
            this.KPanel1.Controls.Add(this.Label12);
            this.KPanel1.Controls.Add(this.PanelA);
            this.KPanel1.Controls.Add(this.CheckBox1);
            this.KPanel1.Controls.Add(this.ligne1);
            this.KPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KPanel1.Location = new System.Drawing.Point(0, 0);
            this.KPanel1.Name = "KPanel1";
            this.KPanel1.Size = new System.Drawing.Size(853, 592);
            this.KPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.KPanel1.TabIndex = 30;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.PanelB);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.CheckBox2);
            this.Panel3.Controls.Add(this.Panel2);
            this.Panel3.Location = new System.Drawing.Point(19, 248);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(834, 323);
            this.Panel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.Panel3.TabIndex = 89;
            // 
            // PanelB
            // 
            this.PanelB.BackColor = System.Drawing.Color.Gray;
            this.PanelB.Controls.Add(this.DGV);
            this.PanelB.Controls.Add(this.txtSearch);
            this.PanelB.Controls.Add(this.kryptonButton4);
            this.PanelB.Controls.Add(this.lblsearch);
            this.PanelB.Controls.Add(this.kryptonButton7);
            this.PanelB.Location = new System.Drawing.Point(5, 62);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(799, 248);
            this.PanelB.TabIndex = 98;
            // 
            // DGV
            // 
            this.DGV.AllowDrop = true;
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.Location = new System.Drawing.Point(8, 7);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(782, 181);
            this.DGV.StateCommon.Background.Color1 = System.Drawing.Color.GhostWhite;
            this.DGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Green;
            this.DGV.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Maroon;
            this.DGV.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DGV.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DGV.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DGV.TabIndex = 110;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 210);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 19);
            this.txtSearch.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSearch.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtSearch.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtSearch.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton4.Location = new System.Drawing.Point(565, 199);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton4.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton4.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton4.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton4.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.TabIndex = 43;
            this.kryptonButton4.Values.Image = global::GUI.Properties.Resources.search;
            this.kryptonButton4.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton4.Values.Text = "Rechercher";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.Location = new System.Drawing.Point(8, 210);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(118, 19);
            this.lblsearch.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.lblsearch.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblsearch.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.TabIndex = 109;
            this.lblsearch.Values.Text = "Recherché           :";
            this.lblsearch.Visible = false;
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton7.Location = new System.Drawing.Point(679, 199);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton7.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton7.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton7.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton7.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton7.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton7.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.kryptonButton7.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton7.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton7.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton7.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.TabIndex = 45;
            this.kryptonButton7.Values.Image = global::GUI.Properties.Resources.agt_print;
            this.kryptonButton7.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton7.Values.Text = "Imprimer";
            this.kryptonButton7.Click += new System.EventHandler(this.kryptonButton7_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Green;
            this.Label2.Location = new System.Drawing.Point(175, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(395, 24);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Information général sur les classes de L\'institut";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Checked = true;
            this.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox2.Location = new System.Drawing.Point(814, 48);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(15, 14);
            this.CheckBox2.TabIndex = 95;
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.Green;
            this.Panel2.Location = new System.Drawing.Point(3, 49);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(812, 10);
            this.Panel2.TabIndex = 93;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Green;
            this.Label12.Location = new System.Drawing.Point(245, 10);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(274, 24);
            this.Label12.TabIndex = 88;
            this.Label12.Text = "Géstion des classes de L\'institut";
            // 
            // PanelA
            // 
            this.PanelA.BackColor = System.Drawing.Color.Gray;
            this.PanelA.Controls.Add(this.kryptonButton3);
            this.PanelA.Controls.Add(this.kryptonButton6);
            this.PanelA.Controls.Add(this.panelServeur);
            this.PanelA.Controls.Add(this.kryptonButton2);
            this.PanelA.Controls.Add(this.kryptonButton1);
            this.PanelA.Location = new System.Drawing.Point(19, 52);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(804, 193);
            this.PanelA.TabIndex = 87;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(464, 143);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton3.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton3.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.TabIndex = 42;
            this.kryptonButton3.Values.Image = global::GUI.Properties.Resources.trash;
            this.kryptonButton3.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton3.Values.Text = "Supprimer";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton6.Location = new System.Drawing.Point(577, 143);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton6.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton6.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton6.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.TabIndex = 46;
            this.kryptonButton6.Values.Image = global::GUI.Properties.Resources.mail_delete;
            this.kryptonButton6.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton6.Values.Text = "Annuler";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // panelServeur
            // 
            this.panelServeur.Controls.Add(this.txtCdeclasse);
            this.panelServeur.Controls.Add(this.txtintituleclasse);
            this.panelServeur.Controls.Add(this.KryptonLabel13);
            this.panelServeur.Controls.Add(this.KryptonLabel12);
            this.panelServeur.Cursor = System.Windows.Forms.Cursors.No;
            this.panelServeur.Location = new System.Drawing.Point(220, 31);
            this.panelServeur.Name = "panelServeur";
            this.panelServeur.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.panelServeur.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellCustom1;
            this.panelServeur.Size = new System.Drawing.Size(427, 106);
            this.panelServeur.StateCommon.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.panelServeur.TabIndex = 1;
            // 
            // txtCdeclasse
            // 
            this.txtCdeclasse.Location = new System.Drawing.Point(123, 26);
            this.txtCdeclasse.Name = "txtCdeclasse";
            this.txtCdeclasse.Size = new System.Drawing.Size(203, 19);
            this.txtCdeclasse.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtCdeclasse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCdeclasse.StateCommon.Content.Color1 = System.Drawing.Color.DarkRed;
            this.txtCdeclasse.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCdeclasse.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtCdeclasse.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCdeclasse.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtCdeclasse.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdeclasse.TabIndex = 40;
            this.txtCdeclasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtintituleclasse
            // 
            this.txtintituleclasse.Location = new System.Drawing.Point(123, 60);
            this.txtintituleclasse.Name = "txtintituleclasse";
            this.txtintituleclasse.Size = new System.Drawing.Size(203, 19);
            this.txtintituleclasse.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtintituleclasse.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtintituleclasse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtintituleclasse.StateCommon.Content.Color1 = System.Drawing.Color.DarkRed;
            this.txtintituleclasse.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtintituleclasse.TabIndex = 39;
            this.txtintituleclasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel13
            // 
            this.KryptonLabel13.Location = new System.Drawing.Point(21, 60);
            this.KryptonLabel13.Name = "KryptonLabel13";
            this.KryptonLabel13.Size = new System.Drawing.Size(115, 19);
            this.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel13.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel13.TabIndex = 30;
            this.KryptonLabel13.Values.Text = "Intitulé                 :";
            // 
            // KryptonLabel12
            // 
            this.KryptonLabel12.Location = new System.Drawing.Point(20, 25);
            this.KryptonLabel12.Name = "KryptonLabel12";
            this.KryptonLabel12.Size = new System.Drawing.Size(112, 19);
            this.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel12.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel12.TabIndex = 28;
            this.KryptonLabel12.Values.Text = "Code Classe      :";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(340, 143);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton2.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.TabIndex = 41;
            this.kryptonButton2.Values.Image = global::GUI.Properties.Resources._14_pencil;
            this.kryptonButton2.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton2.Values.Text = "Modifier";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(220, 143);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton1.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 35;
            this.kryptonButton1.Values.Image = global::GUI.Properties.Resources.folder_new;
            this.kryptonButton1.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton1.Values.Text = "Ajouter";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(833, 37);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 86;
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // ligne1
            // 
            this.ligne1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ligne1.BackColor = System.Drawing.Color.Green;
            this.ligne1.Location = new System.Drawing.Point(19, 37);
            this.ligne1.Name = "ligne1";
            this.ligne1.Size = new System.Drawing.Size(815, 12);
            this.ligne1.TabIndex = 85;
            // 
            // TravailArrierPlan
            // 
            this.TravailArrierPlan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TravailArrierPlan_DoWork);
            // 
            // FormClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(853, 592);
            this.Controls.Add(this.KPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.Name = "FormClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Black;
            this.Text = "Gestion des Classes";
            this.Load += new System.EventHandler(this.FormClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KPanel1)).EndInit();
            this.KPanel1.ResumeLayout(false);
            this.KPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.PanelB.ResumeLayout(false);
            this.PanelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.PanelA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelServeur)).EndInit();
            this.panelServeur.ResumeLayout(false);
            this.panelServeur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel KPanel1;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel Panel3;
        internal System.Windows.Forms.Panel PanelB;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Panel PanelA;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel panelServeur;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtCdeclasse;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtintituleclasse;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel13;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel12;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Panel ligne1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel lblsearch;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton7;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtSearch;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private System.ComponentModel.BackgroundWorker TravailArrierPlan;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView DGV;
    }
}