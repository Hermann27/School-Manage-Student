namespace GUI
{
    partial class FormEntresLivres
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
            this.CombLivre = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.CmbFournisseur = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtPrix = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtQte = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.CombLivre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFournisseur)).BeginInit();
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
            this.KPanel1.Size = new System.Drawing.Size(849, 574);
            this.KPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.KPanel1.TabIndex = 30;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.PanelB);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.CheckBox2);
            this.Panel3.Controls.Add(this.Panel2);
            this.Panel3.Location = new System.Drawing.Point(17, 245);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(815, 320);
            this.Panel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.Panel3.TabIndex = 89;
            // 
            // PanelB
            // 
            this.PanelB.BackColor = System.Drawing.Color.Gray;
            this.PanelB.Controls.Add(this.DGV);
            this.PanelB.Location = new System.Drawing.Point(5, 62);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(775, 242);
            this.PanelB.TabIndex = 98;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.Location = new System.Drawing.Point(3, 15);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(766, 209);
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
            this.DGV.TabIndex = 108;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Green;
            this.Label2.Location = new System.Drawing.Point(81, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(645, 24);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Quelques Information sur lesEntres des livres  de la bibliotheque de L\'institut\r\n" +
    "";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(784, 47);
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
            this.Panel2.Size = new System.Drawing.Size(782, 10);
            this.Panel2.TabIndex = 93;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Green;
            this.Label12.Location = new System.Drawing.Point(153, 6);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(511, 24);
            this.Label12.TabIndex = 88;
            this.Label12.Text = "Géstion des Entres des livres  de la Bibliotheque de L\'institut";
            // 
            // PanelA
            // 
            this.PanelA.BackColor = System.Drawing.Color.Gray;
            this.PanelA.Controls.Add(this.kryptonButton3);
            this.PanelA.Controls.Add(this.kryptonButton4);
            this.PanelA.Controls.Add(this.kryptonButton6);
            this.PanelA.Controls.Add(this.kryptonButton1);
            this.PanelA.Controls.Add(this.kryptonButton2);
            this.PanelA.Controls.Add(this.panelServeur);
            this.PanelA.Location = new System.Drawing.Point(17, 49);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(780, 193);
            this.PanelA.TabIndex = 87;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(340, 146);
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
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.PaleTurquoise;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.kryptonButton3.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton3.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.TabIndex = 123;
            this.kryptonButton3.Values.Image = global::GUI.Properties.Resources.trash;
            this.kryptonButton3.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton3.Values.Text = "Supprimer";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton4.Location = new System.Drawing.Point(452, 146);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonButton4.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.PaleTurquoise;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateTracking.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.kryptonButton4.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton4.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton4.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.TabIndex = 125;
            this.kryptonButton4.Values.Image = global::GUI.Properties.Resources.search;
            this.kryptonButton4.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton4.Values.Text = "Rechercher";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton6.Location = new System.Drawing.Point(564, 146);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonButton6.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.PaleTurquoise;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StateTracking.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.kryptonButton6.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton6.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton6.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.TabIndex = 124;
            this.kryptonButton6.Values.Image = global::GUI.Properties.Resources.mail_delete;
            this.kryptonButton6.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton6.Values.Text = "Annuler";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(116, 146);
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
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.PaleTurquoise;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton1.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 121;
            this.kryptonButton1.Values.Image = global::GUI.Properties.Resources.folder_new;
            this.kryptonButton1.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton1.Values.Text = "Ajouter";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(228, 146);
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
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.PaleTurquoise;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonButton2.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLeftWhite;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.TabIndex = 122;
            this.kryptonButton2.Values.Image = global::GUI.Properties.Resources._14_pencil;
            this.kryptonButton2.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton2.Values.Text = "Modifier";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // panelServeur
            // 
            this.panelServeur.Controls.Add(this.CombLivre);
            this.panelServeur.Controls.Add(this.CmbFournisseur);
            this.panelServeur.Controls.Add(this.txtPrix);
            this.panelServeur.Controls.Add(this.KryptonLabel21);
            this.panelServeur.Controls.Add(this.KryptonLabel17);
            this.panelServeur.Controls.Add(this.txtQte);
            this.panelServeur.Controls.Add(this.KryptonLabel13);
            this.panelServeur.Controls.Add(this.KryptonLabel12);
            this.panelServeur.Cursor = System.Windows.Forms.Cursors.No;
            this.panelServeur.Location = new System.Drawing.Point(3, 10);
            this.panelServeur.Name = "panelServeur";
            this.panelServeur.Size = new System.Drawing.Size(774, 123);
            this.panelServeur.StateCommon.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.panelServeur.TabIndex = 1;
            // 
            // CombLivre
            // 
            this.CombLivre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CombLivre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombLivre.DropDownWidth = 203;
            this.CombLivre.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.CombLivre.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.CombLivre.Location = new System.Drawing.Point(520, 66);
            this.CombLivre.Name = "CombLivre";
            this.CombLivre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.CombLivre.Size = new System.Drawing.Size(203, 19);
            this.CombLivre.Sorted = true;
            this.CombLivre.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.CombLivre.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.CombLivre.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CombLivre.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Maroon;
            this.CombLivre.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombLivre.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.CombLivre.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombLivre.TabIndex = 105;
            // 
            // CmbFournisseur
            // 
            this.CmbFournisseur.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CmbFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFournisseur.DropDownWidth = 203;
            this.CmbFournisseur.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.CmbFournisseur.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.CmbFournisseur.Location = new System.Drawing.Point(520, 28);
            this.CmbFournisseur.Name = "CmbFournisseur";
            this.CmbFournisseur.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.CmbFournisseur.Size = new System.Drawing.Size(203, 19);
            this.CmbFournisseur.Sorted = true;
            this.CmbFournisseur.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.CmbFournisseur.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.CmbFournisseur.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmbFournisseur.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Maroon;
            this.CmbFournisseur.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFournisseur.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.CmbFournisseur.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFournisseur.TabIndex = 104;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(152, 64);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(200, 19);
            this.txtPrix.StateCommon.Border.Color1 = System.Drawing.Color.LawnGreen;
            this.txtPrix.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrix.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtPrix.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPrix.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtPrix.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrix.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtPrix.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.TabIndex = 103;
            this.txtPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel21
            // 
            this.KryptonLabel21.Location = new System.Drawing.Point(29, 64);
            this.KryptonLabel21.Name = "KryptonLabel21";
            this.KryptonLabel21.Size = new System.Drawing.Size(138, 19);
            this.KryptonLabel21.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel21.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel21.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel21.TabIndex = 102;
            this.KryptonLabel21.Values.Text = "Prix HTT                    :";
            // 
            // KryptonLabel17
            // 
            this.KryptonLabel17.Location = new System.Drawing.Point(374, 66);
            this.KryptonLabel17.Name = "KryptonLabel17";
            this.KryptonLabel17.Size = new System.Drawing.Size(161, 19);
            this.KryptonLabel17.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel17.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel17.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel17.TabIndex = 48;
            this.KryptonLabel17.Values.Text = "Livres                               :";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(152, 28);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(200, 19);
            this.txtQte.StateCommon.Border.Color1 = System.Drawing.Color.LawnGreen;
            this.txtQte.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQte.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtQte.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtQte.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtQte.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQte.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtQte.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.TabIndex = 40;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel13
            // 
            this.KryptonLabel13.Location = new System.Drawing.Point(374, 25);
            this.KryptonLabel13.Name = "KryptonLabel13";
            this.KryptonLabel13.Size = new System.Drawing.Size(163, 19);
            this.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel13.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel13.TabIndex = 30;
            this.KryptonLabel13.Values.Text = "Fournisseurs                    :";
            // 
            // KryptonLabel12
            // 
            this.KryptonLabel12.Location = new System.Drawing.Point(28, 28);
            this.KryptonLabel12.Name = "KryptonLabel12";
            this.KryptonLabel12.Size = new System.Drawing.Size(133, 19);
            this.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel12.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel12.TabIndex = 28;
            this.KryptonLabel12.Values.Text = "Quantite Entrees     :";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(800, 32);
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
            this.ligne1.Location = new System.Drawing.Point(17, 33);
            this.ligne1.Name = "ligne1";
            this.ligne1.Size = new System.Drawing.Size(785, 12);
            this.ligne1.TabIndex = 85;
            // 
            // TravailArrierPlan
            // 
            this.TravailArrierPlan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TravailArrierPlan_DoWork);
            // 
            // FormEntresLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(849, 574);
            this.Controls.Add(this.KPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.Name = "FormEntresLivres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Black;
            this.Text = "Gestion des Entrees des Livres";
            this.Load += new System.EventHandler(this.FormEntresLivres_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.CombLivre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel KPanel1;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel Panel3;
        internal System.Windows.Forms.Panel PanelB;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView DGV;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Panel PanelA;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel panelServeur;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel21;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel17;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtQte;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel13;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel12;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Panel ligne1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtPrix;
        internal ComponentFactory.Krypton.Toolkit.KryptonComboBox CombLivre;
        internal ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbFournisseur;
        private System.ComponentModel.BackgroundWorker TravailArrierPlan;
    }
}