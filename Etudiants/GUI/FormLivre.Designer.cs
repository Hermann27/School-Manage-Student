namespace GUI
{
    partial class FormLivre
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
            this.Label2 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label12 = new System.Windows.Forms.Label();
            this.PanelA = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelServeur = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtExtension = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.pictImage = new System.Windows.Forms.PictureBox();
            this.txt_url_couverture = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.btnOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CmbDomaine = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.KryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPrixU = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtauteurLivre = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtStock = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtediteur = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtintituleLivre = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtisbn = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.ligne1 = new System.Windows.Forms.Panel();
            this.TravailArrierPlan = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.KPanel1)).BeginInit();
            this.KPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).BeginInit();
            this.Panel3.SuspendLayout();
            this.PanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.PanelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelServeur)).BeginInit();
            this.panelServeur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDomaine)).BeginInit();
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
            this.KPanel1.Size = new System.Drawing.Size(858, 571);
            this.KPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.KPanel1.TabIndex = 30;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.PanelB);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.CheckBox2);
            this.Panel3.Controls.Add(this.Panel2);
            this.Panel3.Location = new System.Drawing.Point(24, 323);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(815, 252);
            this.Panel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.Panel3.TabIndex = 89;
            // 
            // PanelB
            // 
            this.PanelB.BackColor = System.Drawing.Color.Gray;
            this.PanelB.Controls.Add(this.DGV);
            this.PanelB.Location = new System.Drawing.Point(5, 62);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(775, 181);
            this.PanelB.TabIndex = 98;
            // 
            // DGV
            // 
            this.DGV.AllowDrop = true;
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.Location = new System.Drawing.Point(4, 4);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(766, 170);
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
            this.DGV.TabIndex = 109;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Green;
            this.Label2.Location = new System.Drawing.Point(164, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(560, 24);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Quelques Information  sur les  livres de la bibliotheque de L\'institut\r\n";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(789, 48);
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
            this.Panel2.Size = new System.Drawing.Size(787, 10);
            this.Panel2.TabIndex = 93;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Green;
            this.Label12.Location = new System.Drawing.Point(256, 19);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(417, 24);
            this.Label12.TabIndex = 88;
            this.Label12.Text = "Géstion des Livres de la Bibliotheque de L\'institut";
            // 
            // PanelA
            // 
            this.PanelA.BackColor = System.Drawing.Color.Gray;
            this.PanelA.BackgroundImage = global::GUI.Properties.Resources.ph_10005;
            this.PanelA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelA.Controls.Add(this.kryptonButton3);
            this.PanelA.Controls.Add(this.kryptonButton4);
            this.PanelA.Controls.Add(this.kryptonButton6);
            this.PanelA.Controls.Add(this.kryptonButton1);
            this.PanelA.Controls.Add(this.kryptonButton2);
            this.PanelA.Controls.Add(this.panelServeur);
            this.PanelA.Location = new System.Drawing.Point(24, 64);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(790, 257);
            this.PanelA.TabIndex = 87;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(345, 205);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton3.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton3.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton3.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.TabIndex = 118;
            this.kryptonButton3.Values.Image = global::GUI.Properties.Resources.trash;
            this.kryptonButton3.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton3.Values.Text = "Supprimer";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton4.Location = new System.Drawing.Point(457, 205);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton4.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton4.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton4.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton4.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.TabIndex = 120;
            this.kryptonButton4.Values.Image = global::GUI.Properties.Resources.search;
            this.kryptonButton4.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton4.Values.Text = "Rechercher";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton6.Location = new System.Drawing.Point(569, 205);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton6.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton6.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton6.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton6.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.TabIndex = 119;
            this.kryptonButton6.Values.Image = global::GUI.Properties.Resources.mail_delete;
            this.kryptonButton6.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton6.Values.Text = "Annuler";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(121, 205);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton1.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton1.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 116;
            this.kryptonButton1.Values.Image = global::GUI.Properties.Resources.folder_new;
            this.kryptonButton1.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton1.Values.Text = "Ajouter";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(233, 205);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton2.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton2.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.TabIndex = 117;
            this.kryptonButton2.Values.Image = global::GUI.Properties.Resources._14_pencil;
            this.kryptonButton2.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton2.Values.Text = "Modifier";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // panelServeur
            // 
            this.panelServeur.Controls.Add(this.txtExtension);
            this.panelServeur.Controls.Add(this.pictImage);
            this.panelServeur.Controls.Add(this.txt_url_couverture);
            this.panelServeur.Controls.Add(this.btnOpen);
            this.panelServeur.Controls.Add(this.CmbDomaine);
            this.panelServeur.Controls.Add(this.KryptonLabel21);
            this.panelServeur.Controls.Add(this.txtPrixU);
            this.panelServeur.Controls.Add(this.KryptonLabel16);
            this.panelServeur.Controls.Add(this.txtauteurLivre);
            this.panelServeur.Controls.Add(this.KryptonLabel17);
            this.panelServeur.Controls.Add(this.txtStock);
            this.panelServeur.Controls.Add(this.txtediteur);
            this.panelServeur.Controls.Add(this.KryptonLabel7);
            this.panelServeur.Controls.Add(this.KryptonLabel11);
            this.panelServeur.Controls.Add(this.KryptonLabel15);
            this.panelServeur.Controls.Add(this.txtintituleLivre);
            this.panelServeur.Controls.Add(this.txtisbn);
            this.panelServeur.Controls.Add(this.KryptonLabel14);
            this.panelServeur.Controls.Add(this.KryptonLabel13);
            this.panelServeur.Cursor = System.Windows.Forms.Cursors.No;
            this.panelServeur.Location = new System.Drawing.Point(2, 8);
            this.panelServeur.Name = "panelServeur";
            this.panelServeur.Size = new System.Drawing.Size(774, 150);
            this.panelServeur.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelServeur.TabIndex = 1;
            // 
            // txtExtension
            // 
            this.txtExtension.Enabled = false;
            this.txtExtension.Location = new System.Drawing.Point(650, 8);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(92, 19);
            this.txtExtension.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtExtension.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExtension.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtExtension.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtExtension.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtExtension.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExtension.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtExtension.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.TabIndex = 109;
            this.txtExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictImage
            // 
            this.pictImage.BackColor = System.Drawing.Color.Transparent;
            this.pictImage.Location = new System.Drawing.Point(650, 33);
            this.pictImage.Name = "pictImage";
            this.pictImage.Size = new System.Drawing.Size(121, 99);
            this.pictImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictImage.TabIndex = 108;
            this.pictImage.TabStop = false;
            // 
            // txt_url_couverture
            // 
            this.txt_url_couverture.Enabled = false;
            this.txt_url_couverture.Location = new System.Drawing.Point(468, 8);
            this.txt_url_couverture.Name = "txt_url_couverture";
            this.txt_url_couverture.Size = new System.Drawing.Size(179, 19);
            this.txt_url_couverture.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txt_url_couverture.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_url_couverture.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txt_url_couverture.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_url_couverture.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txt_url_couverture.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_url_couverture.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txt_url_couverture.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url_couverture.TabIndex = 106;
            this.txt_url_couverture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(745, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnOpen.Size = new System.Drawing.Size(30, 26);
            this.btnOpen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpen.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnOpen.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnOpen.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOpen.StateTracking.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOpen.TabIndex = 105;
            this.btnOpen.Values.Image = global::GUI.Properties.Resources.download;
            this.btnOpen.Values.Text = "";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // CmbDomaine
            // 
            this.CmbDomaine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CmbDomaine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDomaine.DropDownWidth = 203;
            this.CmbDomaine.Location = new System.Drawing.Point(107, 108);
            this.CmbDomaine.Name = "CmbDomaine";
            this.CmbDomaine.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.CmbDomaine.Size = new System.Drawing.Size(203, 21);
            this.CmbDomaine.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.CmbDomaine.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.CmbDomaine.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmbDomaine.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.SaddleBrown;
            this.CmbDomaine.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.DarkRed;
            this.CmbDomaine.TabIndex = 103;
            // 
            // KryptonLabel21
            // 
            this.KryptonLabel21.Location = new System.Drawing.Point(5, 107);
            this.KryptonLabel21.Name = "KryptonLabel21";
            this.KryptonLabel21.Size = new System.Drawing.Size(107, 19);
            this.KryptonLabel21.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel21.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel21.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel21.TabIndex = 102;
            this.KryptonLabel21.Values.Text = "Domain             :";
            // 
            // txtPrixU
            // 
            this.txtPrixU.Location = new System.Drawing.Point(468, 113);
            this.txtPrixU.Name = "txtPrixU";
            this.txtPrixU.Size = new System.Drawing.Size(178, 19);
            this.txtPrixU.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPrixU.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtPrixU.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrixU.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtPrixU.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixU.TabIndex = 51;
            this.txtPrixU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel16
            // 
            this.KryptonLabel16.Location = new System.Drawing.Point(333, 113);
            this.KryptonLabel16.Name = "KryptonLabel16";
            this.KryptonLabel16.Size = new System.Drawing.Size(142, 19);
            this.KryptonLabel16.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel16.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel16.TabIndex = 50;
            this.KryptonLabel16.Values.Text = "Prix unitaire                :";
            // 
            // txtauteurLivre
            // 
            this.txtauteurLivre.Location = new System.Drawing.Point(107, 75);
            this.txtauteurLivre.Name = "txtauteurLivre";
            this.txtauteurLivre.Size = new System.Drawing.Size(203, 19);
            this.txtauteurLivre.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtauteurLivre.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtauteurLivre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtauteurLivre.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtauteurLivre.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauteurLivre.TabIndex = 49;
            this.txtauteurLivre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel17
            // 
            this.KryptonLabel17.Location = new System.Drawing.Point(5, 76);
            this.KryptonLabel17.Name = "KryptonLabel17";
            this.KryptonLabel17.Size = new System.Drawing.Size(107, 19);
            this.KryptonLabel17.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel17.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel17.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel17.TabIndex = 48;
            this.KryptonLabel17.Values.Text = "Auteur               :";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(468, 78);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(178, 19);
            this.txtStock.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtStock.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStock.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtStock.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtStock.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtStock.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStock.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtStock.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.TabIndex = 47;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtediteur
            // 
            this.txtediteur.Location = new System.Drawing.Point(468, 43);
            this.txtediteur.Name = "txtediteur";
            this.txtediteur.Size = new System.Drawing.Size(178, 19);
            this.txtediteur.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtediteur.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtediteur.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtediteur.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtediteur.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtediteur.TabIndex = 45;
            this.txtediteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel7
            // 
            this.KryptonLabel7.Location = new System.Drawing.Point(334, 78);
            this.KryptonLabel7.Name = "KryptonLabel7";
            this.KryptonLabel7.Size = new System.Drawing.Size(140, 19);
            this.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel7.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel7.TabIndex = 44;
            this.KryptonLabel7.Values.Text = "Stock                          :";
            // 
            // KryptonLabel11
            // 
            this.KryptonLabel11.Location = new System.Drawing.Point(335, 43);
            this.KryptonLabel11.Name = "KryptonLabel11";
            this.KryptonLabel11.Size = new System.Drawing.Size(149, 19);
            this.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel11.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel11.TabIndex = 43;
            this.KryptonLabel11.Values.Text = "Editeur                          :";
            // 
            // KryptonLabel15
            // 
            this.KryptonLabel15.Location = new System.Drawing.Point(333, 8);
            this.KryptonLabel15.Name = "KryptonLabel15";
            this.KryptonLabel15.Size = new System.Drawing.Size(145, 19);
            this.KryptonLabel15.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel15.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel15.TabIndex = 42;
            this.KryptonLabel15.Values.Text = "Chemin Couverture    :";
            // 
            // txtintituleLivre
            // 
            this.txtintituleLivre.Location = new System.Drawing.Point(107, 41);
            this.txtintituleLivre.Name = "txtintituleLivre";
            this.txtintituleLivre.Size = new System.Drawing.Size(203, 19);
            this.txtintituleLivre.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtintituleLivre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtintituleLivre.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtintituleLivre.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtintituleLivre.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtintituleLivre.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtintituleLivre.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtintituleLivre.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtintituleLivre.TabIndex = 41;
            this.txtintituleLivre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(107, 6);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(203, 19);
            this.txtisbn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtisbn.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtisbn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtisbn.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtisbn.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisbn.TabIndex = 39;
            this.txtisbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel14
            // 
            this.KryptonLabel14.Location = new System.Drawing.Point(5, 41);
            this.KryptonLabel14.Name = "KryptonLabel14";
            this.KryptonLabel14.Size = new System.Drawing.Size(104, 19);
            this.KryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel14.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel14.TabIndex = 32;
            this.KryptonLabel14.Values.Text = "Intitulé              :";
            // 
            // KryptonLabel13
            // 
            this.KryptonLabel13.Location = new System.Drawing.Point(5, 6);
            this.KryptonLabel13.Name = "KryptonLabel13";
            this.KryptonLabel13.Size = new System.Drawing.Size(110, 19);
            this.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel13.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel13.TabIndex = 30;
            this.KryptonLabel13.Values.Text = "ISBN                  :";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(813, 44);
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
            this.ligne1.Location = new System.Drawing.Point(24, 46);
            this.ligne1.Name = "ligne1";
            this.ligne1.Size = new System.Drawing.Size(790, 12);
            this.ligne1.TabIndex = 85;
            // 
            // TravailArrierPlan
            // 
            this.TravailArrierPlan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TravailArrierPlan_DoWork);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(858, 571);
            this.Controls.Add(this.KPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.Name = "FormLivre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Black;
            this.Text = "Gestion des Livres";
            this.Load += new System.EventHandler(this.FormLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KPanel1)).EndInit();
            this.KPanel1.ResumeLayout(false);
            this.KPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.PanelB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.PanelA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelServeur)).EndInit();
            this.panelServeur.ResumeLayout(false);
            this.panelServeur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDomaine)).EndInit();
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
        internal ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbDomaine;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel21;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtPrixU;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel16;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtauteurLivre;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel17;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtStock;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtediteur;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel7;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel11;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel15;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtintituleLivre;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtisbn;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel14;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel13;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Panel ligne1;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txt_url_couverture;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnOpen;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.ComponentModel.BackgroundWorker TravailArrierPlan;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView DGV;
        private System.Windows.Forms.PictureBox pictImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtExtension;
    }
}