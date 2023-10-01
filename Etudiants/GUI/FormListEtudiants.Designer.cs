namespace GUI
{
    partial class FormListEtudiants 
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
            this.pictureALL = new System.Windows.Forms.PictureBox();
            this.PanelB = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblnombre = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.DGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.TravailArrierPlan = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.KPanel1)).BeginInit();
            this.KPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureALL)).BeginInit();
            this.PanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
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
            this.KPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KPanel1.Location = new System.Drawing.Point(0, 0);
            this.KPanel1.Name = "KPanel1";
            this.KPanel1.Size = new System.Drawing.Size(864, 580);
            this.KPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.KPanel1.TabIndex = 30;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.pictureALL);
            this.Panel3.Controls.Add(this.PanelB);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.CheckBox2);
            this.Panel3.Controls.Add(this.Panel2);
            this.Panel3.Location = new System.Drawing.Point(3, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(861, 562);
            this.Panel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.Panel3.TabIndex = 89;
            // 
            // pictureALL
            // 
            this.pictureALL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureALL.Location = new System.Drawing.Point(3, 0);
            this.pictureALL.Name = "pictureALL";
            this.pictureALL.Size = new System.Drawing.Size(82, 82);
            this.pictureALL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureALL.TabIndex = 99;
            this.pictureALL.TabStop = false;
            // 
            // PanelB
            // 
            this.PanelB.BackColor = System.Drawing.Color.Gray;
            this.PanelB.Controls.Add(this.kryptonButton1);
            this.PanelB.Controls.Add(this.lblnombre);
            this.PanelB.Controls.Add(this.kryptonLabel3);
            this.PanelB.Controls.Add(this.DGV);
            this.PanelB.Controls.Add(this.kryptonButton6);
            this.PanelB.Controls.Add(this.txtSearch);
            this.PanelB.Controls.Add(this.kryptonLabel2);
            this.PanelB.Controls.Add(this.kryptonButton7);
            this.PanelB.Location = new System.Drawing.Point(5, 107);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(831, 452);
            this.PanelB.TabIndex = 98;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(429, 9);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton1.Size = new System.Drawing.Size(162, 35);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MediumSpringGreen;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.Thistle;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 124;
            this.kryptonButton1.Values.Image = global::GUI.Properties.Resources.fileshare;
            this.kryptonButton1.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton1.Values.Text = "Details de la Recherche";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblnombre.Location = new System.Drawing.Point(780, 429);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lblnombre.Size = new System.Drawing.Size(18, 19);
            this.lblnombre.StateCommon.ShortText.Color1 = System.Drawing.Color.PaleGreen;
            this.lblnombre.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lblnombre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.TabIndex = 123;
            this.lblnombre.Values.Text = "0";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(639, 429);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(143, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.kryptonLabel3.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 122;
            this.kryptonLabel3.Values.Text = "Total Etudiants           :";
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
            this.DGV.Location = new System.Drawing.Point(4, 61);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.Size = new System.Drawing.Size(824, 362);
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
            this.DGV.TabIndex = 121;
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton6.Location = new System.Drawing.Point(715, 9);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton6.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton6.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MediumSpringGreen;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.StateTracking.Back.Color1 = System.Drawing.Color.Thistle;
            this.kryptonButton6.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton6.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.TabIndex = 118;
            this.kryptonButton6.Values.Image = global::GUI.Properties.Resources.mail_delete;
            this.kryptonButton6.Values.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton6.Values.Text = "Annuler";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 19);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.LawnGreen;
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
            this.txtSearch.TabIndex = 114;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(10, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(118, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.kryptonLabel2.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 117;
            this.kryptonLabel2.Values.Text = "Recherché           :";
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton7.Location = new System.Drawing.Point(604, 9);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton7.Size = new System.Drawing.Size(105, 35);
            this.kryptonButton7.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonHighlight;
            this.kryptonButton7.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.kryptonButton7.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton7.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton7.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MediumSpringGreen;
            this.kryptonButton7.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton7.StateTracking.Back.Color1 = System.Drawing.Color.Thistle;
            this.kryptonButton7.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonButton7.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.TabIndex = 116;
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
            this.Label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label2.Location = new System.Drawing.Point(283, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(313, 24);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Information général sur les Etudiants";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(836, 85);
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
            this.Panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Panel2.Location = new System.Drawing.Point(3, 85);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(843, 14);
            this.Panel2.TabIndex = 93;
            // 
            // TravailArrierPlan
            // 
            this.TravailArrierPlan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TravailArrierPlan_DoWork);
            // 
            // FormListEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(864, 580);
            this.Controls.Add(this.KPanel1);
            this.Controls.Add(this.kryptonLabel1);
            this.MaximizeBox = false;
            this.Name = "FormListEtudiants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Black;
            this.Text = "Liste des  Etudiants";
            this.Load += new System.EventHandler(this.FormEtudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KPanel1)).EndInit();
            this.KPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureALL)).EndInit();
            this.PanelB.ResumeLayout(false);
            this.PanelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
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
        internal ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtSearch;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton7;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        private System.ComponentModel.BackgroundWorker TravailArrierPlan;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView DGV;
        private System.Windows.Forms.PictureBox pictureALL;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel lblnombre;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}