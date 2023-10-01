namespace GUI
{
    partial class FormEtudiants 
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
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PanelB = new System.Windows.Forms.Panel();
            this.DGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label12 = new System.Windows.Forms.Label();
            this.PanelA = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelServeur = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radiobtnNon = new System.Windows.Forms.RadioButton();
            this.radiobtnOui = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnF = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculin = new System.Windows.Forms.RadioButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_url_prof = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.pictImage = new System.Windows.Forms.PictureBox();
            this.dateNaiss = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.CmbFiliere = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.KryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtlieuNaiss = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtcite = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtSexe = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtphone = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtmatricule = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtnom = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.ligne1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFiliere)).BeginInit();
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
            this.KPanel1.Size = new System.Drawing.Size(854, 572);
            this.KPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.KPanel1.TabIndex = 30;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.kryptonLabel4);
            this.Panel3.Controls.Add(this.PanelB);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.CheckBox2);
            this.Panel3.Controls.Add(this.Panel2);
            this.Panel3.Location = new System.Drawing.Point(16, 299);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(815, 262);
            this.Panel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.Panel3.TabIndex = 89;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonLabel4.Location = new System.Drawing.Point(7, 246);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(756, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLabel4.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 121;
            this.kryptonLabel4.Values.Text = "Restons toujours en confiance avec l\'equipe type 3 de SoftNewTechnologie Entrepri" +
    "se Email: softnewtechnologie@gmail.com";
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
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DGV.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.DGV.Location = new System.Drawing.Point(6, 8);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.Size = new System.Drawing.Size(764, 164);
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
            this.DGV.TabIndex = 122;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged_1);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label2.Location = new System.Drawing.Point(252, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(341, 24);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Quelques Informations sur les Etudiants";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(789, 46);
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
            this.Label12.Location = new System.Drawing.Point(283, 12);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(289, 24);
            this.Label12.TabIndex = 88;
            this.Label12.Text = "Gestion des Etudiants de L\'institut";
            // 
            // PanelA
            // 
            this.PanelA.BackColor = System.Drawing.Color.Gray;
            this.PanelA.Controls.Add(this.kryptonButton3);
            this.PanelA.Controls.Add(this.kryptonButton4);
            this.PanelA.Controls.Add(this.panelServeur);
            this.PanelA.Controls.Add(this.kryptonButton6);
            this.PanelA.Controls.Add(this.kryptonButton1);
            this.PanelA.Controls.Add(this.kryptonButton2);
            this.PanelA.Location = new System.Drawing.Point(16, 60);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(780, 237);
            this.PanelA.TabIndex = 87;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(322, 194);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton3.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton3.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.TabIndex = 107;
            this.kryptonButton3.Values.Image = global::GUI.Properties.Resources.trash;
            this.kryptonButton3.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton3.Values.Text = "Supprimer";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton4.Location = new System.Drawing.Point(440, 194);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton4.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton4.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton4.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.TabIndex = 115;
            this.kryptonButton4.Values.Image = global::GUI.Properties.Resources.search;
            this.kryptonButton4.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton4.Values.Text = "Rechercher";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // panelServeur
            // 
            this.panelServeur.Controls.Add(this.panel4);
            this.panelServeur.Controls.Add(this.panel1);
            this.panelServeur.Controls.Add(this.kryptonLabel3);
            this.panelServeur.Controls.Add(this.kryptonLabel2);
            this.panelServeur.Controls.Add(this.kryptonButton5);
            this.panelServeur.Controls.Add(this.txt_url_prof);
            this.panelServeur.Controls.Add(this.pictImage);
            this.panelServeur.Controls.Add(this.dateNaiss);
            this.panelServeur.Controls.Add(this.CmbFiliere);
            this.panelServeur.Controls.Add(this.KryptonLabel21);
            this.panelServeur.Controls.Add(this.txtlieuNaiss);
            this.panelServeur.Controls.Add(this.KryptonLabel16);
            this.panelServeur.Controls.Add(this.txtcite);
            this.panelServeur.Controls.Add(this.KryptonLabel17);
            this.panelServeur.Controls.Add(this.txtSexe);
            this.panelServeur.Controls.Add(this.txtphone);
            this.panelServeur.Controls.Add(this.KryptonLabel7);
            this.panelServeur.Controls.Add(this.KryptonLabel11);
            this.panelServeur.Controls.Add(this.KryptonLabel15);
            this.panelServeur.Controls.Add(this.txtmatricule);
            this.panelServeur.Controls.Add(this.txtnom);
            this.panelServeur.Controls.Add(this.KryptonLabel13);
            this.panelServeur.Controls.Add(this.KryptonLabel12);
            this.panelServeur.Cursor = System.Windows.Forms.Cursors.No;
            this.panelServeur.Location = new System.Drawing.Point(9, 8);
            this.panelServeur.Name = "panelServeur";
            this.panelServeur.Size = new System.Drawing.Size(766, 173);
            this.panelServeur.StateCommon.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.panelServeur.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.radiobtnNon);
            this.panel4.Controls.Add(this.radiobtnOui);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Location = new System.Drawing.Point(107, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 25);
            this.panel4.TabIndex = 120;
            // 
            // radiobtnNon
            // 
            this.radiobtnNon.AutoSize = true;
            this.radiobtnNon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnNon.ForeColor = System.Drawing.Color.Maroon;
            this.radiobtnNon.Location = new System.Drawing.Point(103, 5);
            this.radiobtnNon.Name = "radiobtnNon";
            this.radiobtnNon.Size = new System.Drawing.Size(48, 17);
            this.radiobtnNon.TabIndex = 1;
            this.radiobtnNon.TabStop = true;
            this.radiobtnNon.Text = "Non";
            this.radiobtnNon.UseVisualStyleBackColor = true;
            this.radiobtnNon.CheckedChanged += new System.EventHandler(this.radiobtnNon_CheckedChanged);
            // 
            // radiobtnOui
            // 
            this.radiobtnOui.AutoSize = true;
            this.radiobtnOui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnOui.ForeColor = System.Drawing.Color.Maroon;
            this.radiobtnOui.Location = new System.Drawing.Point(46, 5);
            this.radiobtnOui.Name = "radiobtnOui";
            this.radiobtnOui.Size = new System.Drawing.Size(44, 17);
            this.radiobtnOui.TabIndex = 0;
            this.radiobtnOui.TabStop = true;
            this.radiobtnOui.Text = "Oui";
            this.radiobtnOui.UseVisualStyleBackColor = true;
            this.radiobtnOui.CheckedChanged += new System.EventHandler(this.radiobtnOui_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.radioBtnF);
            this.panel1.Controls.Add(this.radioBtnMasculin);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(449, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 25);
            this.panel1.TabIndex = 119;
            // 
            // radioBtnF
            // 
            this.radioBtnF.AutoSize = true;
            this.radioBtnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnF.ForeColor = System.Drawing.Color.Maroon;
            this.radioBtnF.Location = new System.Drawing.Point(114, 5);
            this.radioBtnF.Name = "radioBtnF";
            this.radioBtnF.Size = new System.Drawing.Size(75, 17);
            this.radioBtnF.TabIndex = 1;
            this.radioBtnF.TabStop = true;
            this.radioBtnF.Text = "Feminuin";
            this.radioBtnF.UseVisualStyleBackColor = true;
            this.radioBtnF.CheckedChanged += new System.EventHandler(this.radioBtnF_CheckedChanged);
            // 
            // radioBtnMasculin
            // 
            this.radioBtnMasculin.AutoSize = true;
            this.radioBtnMasculin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMasculin.ForeColor = System.Drawing.Color.Maroon;
            this.radioBtnMasculin.Location = new System.Drawing.Point(26, 5);
            this.radioBtnMasculin.Name = "radioBtnMasculin";
            this.radioBtnMasculin.Size = new System.Drawing.Size(75, 17);
            this.radioBtnMasculin.TabIndex = 0;
            this.radioBtnMasculin.TabStop = true;
            this.radioBtnMasculin.Text = "Masculin";
            this.radioBtnMasculin.UseVisualStyleBackColor = true;
            this.radioBtnMasculin.CheckedChanged += new System.EventHandler(this.radioBtnMasculin_CheckedChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonLabel3.Location = new System.Drawing.Point(665, 149);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(98, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.kryptonLabel3.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 118;
            this.kryptonLabel3.Values.Text = "Effacer  Image";
            this.kryptonLabel3.Click += new System.EventHandler(this.kryptonLabel3_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonLabel2.Location = new System.Drawing.Point(517, 149);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(135, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.kryptonLabel2.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 117;
            this.kryptonLabel2.Values.Text = "Initialiser les champs";
            this.kryptonLabel2.Click += new System.EventHandler(this.kryptonLabel2_Click);
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.kryptonButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton5.Location = new System.Drawing.Point(740, 113);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonButton5.Size = new System.Drawing.Size(24, 19);
            this.kryptonButton5.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.kryptonButton5.StateCommon.Back.Color2 = System.Drawing.SystemColors.InactiveCaptionText;
            this.kryptonButton5.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton5.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton5.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.kryptonButton5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.kryptonButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton5.StateTracking.Back.Color1 = System.Drawing.Color.RosyBrown;
            this.kryptonButton5.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton5.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.TabIndex = 116;
            this.kryptonButton5.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton5.Values.Text = "...";
            this.kryptonButton5.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // txt_url_prof
            // 
            this.txt_url_prof.Enabled = false;
            this.txt_url_prof.Location = new System.Drawing.Point(658, 113);
            this.txt_url_prof.Name = "txt_url_prof";
            this.txt_url_prof.Size = new System.Drawing.Size(82, 19);
            this.txt_url_prof.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_url_prof.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txt_url_prof.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_url_prof.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txt_url_prof.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url_prof.TabIndex = 107;
            this.txt_url_prof.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictImage
            // 
            this.pictImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictImage.Location = new System.Drawing.Point(656, 8);
            this.pictImage.Name = "pictImage";
            this.pictImage.Size = new System.Drawing.Size(105, 99);
            this.pictImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictImage.TabIndex = 106;
            this.pictImage.TabStop = false;
            // 
            // dateNaiss
            // 
            this.dateNaiss.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateNaiss.Location = new System.Drawing.Point(449, 8);
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dateNaiss.ShowCheckBox = true;
            this.dateNaiss.Size = new System.Drawing.Size(203, 21);
            this.dateNaiss.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.dateNaiss.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateNaiss.TabIndex = 105;
            // 
            // CmbFiliere
            // 
            this.CmbFiliere.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CmbFiliere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiliere.DropDownWidth = 203;
            this.CmbFiliere.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.CmbFiliere.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.CmbFiliere.Location = new System.Drawing.Point(107, 111);
            this.CmbFiliere.Name = "CmbFiliere";
            this.CmbFiliere.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.CmbFiliere.Size = new System.Drawing.Size(203, 19);
            this.CmbFiliere.Sorted = true;
            this.CmbFiliere.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.CmbFiliere.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.CmbFiliere.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmbFiliere.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Maroon;
            this.CmbFiliere.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiliere.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.CmbFiliere.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiliere.TabIndex = 103;
            // 
            // KryptonLabel21
            // 
            this.KryptonLabel21.Location = new System.Drawing.Point(5, 110);
            this.KryptonLabel21.Name = "KryptonLabel21";
            this.KryptonLabel21.Size = new System.Drawing.Size(115, 19);
            this.KryptonLabel21.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel21.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel21.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel21.TabIndex = 102;
            this.KryptonLabel21.Values.Text = "Filière                  :";
            // 
            // txtlieuNaiss
            // 
            this.txtlieuNaiss.Location = new System.Drawing.Point(449, 113);
            this.txtlieuNaiss.Name = "txtlieuNaiss";
            this.txtlieuNaiss.Size = new System.Drawing.Size(203, 19);
            this.txtlieuNaiss.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.txtlieuNaiss.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtlieuNaiss.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtlieuNaiss.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtlieuNaiss.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlieuNaiss.TabIndex = 51;
            this.txtlieuNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel16
            // 
            this.KryptonLabel16.Location = new System.Drawing.Point(324, 113);
            this.KryptonLabel16.Name = "KryptonLabel16";
            this.KryptonLabel16.Size = new System.Drawing.Size(137, 19);
            this.KryptonLabel16.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel16.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel16.TabIndex = 50;
            this.KryptonLabel16.Values.Text = "Lieu de naissance    :";
            // 
            // txtcite
            // 
            this.txtcite.Location = new System.Drawing.Point(107, 78);
            this.txtcite.Name = "txtcite";
            this.txtcite.Size = new System.Drawing.Size(203, 19);
            this.txtcite.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcite.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtcite.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtcite.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtcite.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcite.TabIndex = 49;
            this.txtcite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel17
            // 
            this.KryptonLabel17.Location = new System.Drawing.Point(5, 79);
            this.KryptonLabel17.Name = "KryptonLabel17";
            this.KryptonLabel17.Size = new System.Drawing.Size(120, 19);
            this.KryptonLabel17.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel17.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel17.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel17.TabIndex = 48;
            this.KryptonLabel17.Values.Text = "Loger à la  cité ?  :";
            // 
            // txtSexe
            // 
            this.txtSexe.Location = new System.Drawing.Point(449, 78);
            this.txtSexe.Name = "txtSexe";
            this.txtSexe.Size = new System.Drawing.Size(203, 19);
            this.txtSexe.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSexe.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtSexe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSexe.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtSexe.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSexe.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtSexe.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSexe.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtSexe.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexe.TabIndex = 47;
            this.txtSexe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(449, 43);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(203, 19);
            this.txtphone.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.txtphone.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtphone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtphone.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtphone.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.TabIndex = 45;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel7
            // 
            this.KryptonLabel7.Location = new System.Drawing.Point(323, 78);
            this.KryptonLabel7.Name = "KryptonLabel7";
            this.KryptonLabel7.Size = new System.Drawing.Size(141, 19);
            this.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel7.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel7.TabIndex = 44;
            this.KryptonLabel7.Values.Text = "Sexe                           :";
            // 
            // KryptonLabel11
            // 
            this.KryptonLabel11.Location = new System.Drawing.Point(323, 43);
            this.KryptonLabel11.Name = "KryptonLabel11";
            this.KryptonLabel11.Size = new System.Drawing.Size(138, 19);
            this.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel11.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel11.TabIndex = 43;
            this.KryptonLabel11.Values.Text = "Téléphone                 :";
            // 
            // KryptonLabel15
            // 
            this.KryptonLabel15.Location = new System.Drawing.Point(323, 8);
            this.KryptonLabel15.Name = "KryptonLabel15";
            this.KryptonLabel15.Size = new System.Drawing.Size(132, 19);
            this.KryptonLabel15.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel15.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel15.TabIndex = 42;
            this.KryptonLabel15.Values.Text = "Date de naissance  :";
            // 
            // txtmatricule
            // 
            this.txtmatricule.Location = new System.Drawing.Point(107, 10);
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(203, 19);
            this.txtmatricule.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmatricule.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtmatricule.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtmatricule.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtmatricule.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtmatricule.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtmatricule.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtmatricule.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtmatricule.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricule.TabIndex = 40;
            this.txtmatricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(107, 44);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(203, 19);
            this.txtnom.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtnom.StateCommon.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.txtnom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtnom.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtnom.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.TabIndex = 39;
            this.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel13
            // 
            this.KryptonLabel13.Location = new System.Drawing.Point(5, 44);
            this.KryptonLabel13.Name = "KryptonLabel13";
            this.KryptonLabel13.Size = new System.Drawing.Size(114, 19);
            this.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel13.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel13.TabIndex = 30;
            this.KryptonLabel13.Values.Text = "Nom                    :";
            // 
            // KryptonLabel12
            // 
            this.KryptonLabel12.Location = new System.Drawing.Point(4, 9);
            this.KryptonLabel12.Name = "KryptonLabel12";
            this.KryptonLabel12.Size = new System.Drawing.Size(112, 19);
            this.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel12.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel12.TabIndex = 28;
            this.KryptonLabel12.Values.Text = "Matricule            :";
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton6.Location = new System.Drawing.Point(558, 194);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton6.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton6.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.TabIndex = 108;
            this.kryptonButton6.Values.Image = global::GUI.Properties.Resources.mail_delete;
            this.kryptonButton6.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton6.Values.Text = "Annuler";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(86, 194);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton1.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 105;
            this.kryptonButton1.Values.Image = global::GUI.Properties.Resources.folder_new;
            this.kryptonButton1.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton1.Values.Text = "Ajouter";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(204, 194);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton2.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.AliceBlue;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.TabIndex = 106;
            this.kryptonButton2.Values.Image = global::GUI.Properties.Resources._14_pencil;
            this.kryptonButton2.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton2.Values.Text = "Modifier";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(805, 43);
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
            this.ligne1.Location = new System.Drawing.Point(16, 45);
            this.ligne1.Name = "ligne1";
            this.ligne1.Size = new System.Drawing.Size(790, 12);
            this.ligne1.TabIndex = 85;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            //this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TravailArrierPlan
            // 
            this.TravailArrierPlan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.TravailArrierPlan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TravailArrierPlan_RunWorkerCompleted);
            // 
            // FormEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 572);
            this.Controls.Add(this.KPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.Name = "FormEtudiants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Black;
            this.Text = "Gestion des Etudiants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEtudiants_FormClosing);
            this.Load += new System.EventHandler(this.FormEtudiants_Load);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFiliere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel KPanel1;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Panel PanelA;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel panelServeur;
        internal ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbFiliere;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel21;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtlieuNaiss;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel16;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtcite;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel17;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtSexe;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtphone;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel7;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel11;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel15;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtmatricule;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtnom;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel13;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel12;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Panel ligne1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        internal ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateNaiss;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel Panel3;
        internal System.Windows.Forms.Panel PanelB;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.Panel Panel2;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton5;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txt_url_prof;
        private System.Windows.Forms.PictureBox pictImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker TravailArrierPlan;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnF;
        private System.Windows.Forms.RadioButton radioBtnMasculin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radiobtnNon;
        private System.Windows.Forms.RadioButton radiobtnOui;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}