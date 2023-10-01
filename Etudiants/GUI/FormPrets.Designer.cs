namespace GUI
{
    partial class FormPrets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateEcheance = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.DateRetour = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.datePret = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Cmbprivilege = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.KryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtlogin = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.ligne1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.KPanel1)).BeginInit();
            this.KPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).BeginInit();
            this.Panel3.SuspendLayout();
            this.PanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.PanelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelServeur)).BeginInit();
            this.panelServeur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbprivilege)).BeginInit();
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
            this.Label2.Location = new System.Drawing.Point(136, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(612, 24);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Quelques Information sur les livres  prêtés de la bibliotheque de L\'institut\r\n";
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
            this.Label12.Location = new System.Drawing.Point(213, 6);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(478, 24);
            this.Label12.TabIndex = 88;
            this.Label12.Text = "Géstion des  livres  prêtés de la Bibliotheque de L\'institut";
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
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton4.Location = new System.Drawing.Point(452, 146);
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
            this.kryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
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
            // 
            // panelServeur
            // 
            this.panelServeur.Controls.Add(this.groupBox1);
            this.panelServeur.Controls.Add(this.dateEcheance);
            this.panelServeur.Controls.Add(this.DateRetour);
            this.panelServeur.Controls.Add(this.datePret);
            this.panelServeur.Controls.Add(this.Cmbprivilege);
            this.panelServeur.Controls.Add(this.KryptonLabel21);
            this.panelServeur.Controls.Add(this.KryptonLabel17);
            this.panelServeur.Controls.Add(this.txtlogin);
            this.panelServeur.Controls.Add(this.KryptonLabel14);
            this.panelServeur.Controls.Add(this.KryptonLabel13);
            this.panelServeur.Controls.Add(this.KryptonLabel12);
            this.panelServeur.Cursor = System.Windows.Forms.Cursors.No;
            this.panelServeur.Location = new System.Drawing.Point(3, 10);
            this.panelServeur.Name = "panelServeur";
            this.panelServeur.Size = new System.Drawing.Size(774, 123);
            this.panelServeur.StateCommon.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.panelServeur.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(397, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 38);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retourner un Pret";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(203, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oui";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateEcheance
            // 
            this.dateEcheance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateEcheance.Location = new System.Drawing.Point(138, 90);
            this.dateEcheance.Name = "dateEcheance";
            this.dateEcheance.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dateEcheance.ShowCheckBox = true;
            this.dateEcheance.Size = new System.Drawing.Size(200, 21);
            this.dateEcheance.TabIndex = 115;
            // 
            // DateRetour
            // 
            this.DateRetour.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DateRetour.Location = new System.Drawing.Point(529, 90);
            this.DateRetour.Name = "DateRetour";
            this.DateRetour.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.DateRetour.ShowCheckBox = true;
            this.DateRetour.Size = new System.Drawing.Size(200, 21);
            this.DateRetour.TabIndex = 114;
            // 
            // datePret
            // 
            this.datePret.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.datePret.Location = new System.Drawing.Point(529, 46);
            this.datePret.Name = "datePret";
            this.datePret.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.datePret.ShowCheckBox = true;
            this.datePret.Size = new System.Drawing.Size(200, 21);
            this.datePret.TabIndex = 113;
            // 
            // Cmbprivilege
            // 
            this.Cmbprivilege.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cmbprivilege.DropDownWidth = 203;
            this.Cmbprivilege.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Cmbprivilege.Location = new System.Drawing.Point(138, 46);
            this.Cmbprivilege.Name = "Cmbprivilege";
            this.Cmbprivilege.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.Cmbprivilege.Size = new System.Drawing.Size(200, 21);
            this.Cmbprivilege.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Black;
            this.Cmbprivilege.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Fuchsia;
            this.Cmbprivilege.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cmbprivilege.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Aqua;
            this.Cmbprivilege.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Aqua;
            this.Cmbprivilege.TabIndex = 103;
            // 
            // KryptonLabel21
            // 
            this.KryptonLabel21.Location = new System.Drawing.Point(15, 46);
            this.KryptonLabel21.Name = "KryptonLabel21";
            this.KryptonLabel21.Size = new System.Drawing.Size(128, 19);
            this.KryptonLabel21.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel21.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel21.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel21.TabIndex = 102;
            this.KryptonLabel21.Values.Text = "Nom Etudiant         :";
            // 
            // KryptonLabel17
            // 
            this.KryptonLabel17.Location = new System.Drawing.Point(395, 90);
            this.KryptonLabel17.Name = "KryptonLabel17";
            this.KryptonLabel17.Size = new System.Drawing.Size(151, 19);
            this.KryptonLabel17.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel17.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel17.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel17.TabIndex = 48;
            this.KryptonLabel17.Values.Text = "Date Retour                  :";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(138, 10);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(200, 19);
            this.txtlogin.StateCommon.Border.Color1 = System.Drawing.Color.LawnGreen;
            this.txtlogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtlogin.StateCommon.Content.Color1 = System.Drawing.Color.Maroon;
            this.txtlogin.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtlogin.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.txtlogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtlogin.StateNormal.Content.Color1 = System.Drawing.Color.Red;
            this.txtlogin.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.TabIndex = 40;
            this.txtlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptonLabel14
            // 
            this.KryptonLabel14.Location = new System.Drawing.Point(11, 89);
            this.KryptonLabel14.Name = "KryptonLabel14";
            this.KryptonLabel14.Size = new System.Drawing.Size(131, 19);
            this.KryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel14.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel14.TabIndex = 32;
            this.KryptonLabel14.Values.Text = "Date Echéance       :";
            // 
            // KryptonLabel13
            // 
            this.KryptonLabel13.Location = new System.Drawing.Point(397, 48);
            this.KryptonLabel13.Name = "KryptonLabel13";
            this.KryptonLabel13.Size = new System.Drawing.Size(148, 19);
            this.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel13.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel13.TabIndex = 30;
            this.KryptonLabel13.Values.Text = "Date prêt                      :";
            // 
            // KryptonLabel12
            // 
            this.KryptonLabel12.Location = new System.Drawing.Point(14, 10);
            this.KryptonLabel12.Name = "KryptonLabel12";
            this.KryptonLabel12.Size = new System.Drawing.Size(130, 19);
            this.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.KryptonLabel12.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KryptonLabel12.TabIndex = 28;
            this.KryptonLabel12.Values.Text = "Titre livre                 :";
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
            // FormPrets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(849, 574);
            this.Controls.Add(this.KPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.Name = "FormPrets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Black;
            this.Text = "Gestion des Prets";
            this.Load += new System.EventHandler(this.FormPrets_Load);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbprivilege)).EndInit();
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
        internal ComponentFactory.Krypton.Toolkit.KryptonComboBox Cmbprivilege;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel21;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel17;
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtlogin;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel14;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel13;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel12;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Panel ligne1;
        internal ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateEcheance;
        internal ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateRetour;
        internal ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datePret;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}