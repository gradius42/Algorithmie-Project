namespace Algorithmie_Project
{
    partial class Ctrl_Labyrinthe_Panel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grp_taille = new System.Windows.Forms.GroupBox();
            this.rdb_taille7 = new System.Windows.Forms.RadioButton();
            this.rdb_taille6 = new System.Windows.Forms.RadioButton();
            this.rdb_taille5 = new System.Windows.Forms.RadioButton();
            this.rdb_taille4 = new System.Windows.Forms.RadioButton();
            this.rdb_taille3 = new System.Windows.Forms.RadioButton();
            this.rdb_taille2 = new System.Windows.Forms.RadioButton();
            this.rdb_taille1 = new System.Windows.Forms.RadioButton();
            this.grp_prop_generation = new System.Windows.Forms.GroupBox();
            this.grp_graine = new System.Windows.Forms.GroupBox();
            this.lbl_nb_graine = new System.Windows.Forms.Label();
            this.txt_nb_graine = new System.Windows.Forms.TextBox();
            this.trk_ratio = new System.Windows.Forms.TrackBar();
            this.rdb_linéaire = new System.Windows.Forms.RadioButton();
            this.rdb_alea = new System.Windows.Forms.RadioButton();
            this.HelpProvider = new System.Windows.Forms.HelpProvider();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Affichage = new System.Windows.Forms.GroupBox();
            this.nud_delai = new System.Windows.Forms.NumericUpDown();
            this.lbl_delai = new System.Windows.Forms.Label();
            this.rdb_construction_normal = new System.Windows.Forms.RadioButton();
            this.rdb_construction_etendu = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_As_parcour = new System.Windows.Forms.CheckBox();
            this.chk_As = new System.Windows.Forms.CheckBox();
            this.chk_Dij_parcour = new System.Windows.Forms.CheckBox();
            this.chk_Dij = new System.Windows.Forms.CheckBox();
            this.grp_taille.SuspendLayout();
            this.grp_prop_generation.SuspendLayout();
            this.grp_graine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grp_Affichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_taille
            // 
            this.grp_taille.Controls.Add(this.rdb_taille7);
            this.grp_taille.Controls.Add(this.rdb_taille6);
            this.grp_taille.Controls.Add(this.rdb_taille5);
            this.grp_taille.Controls.Add(this.rdb_taille4);
            this.grp_taille.Controls.Add(this.rdb_taille3);
            this.grp_taille.Controls.Add(this.rdb_taille2);
            this.grp_taille.Controls.Add(this.rdb_taille1);
            this.grp_taille.ForeColor = System.Drawing.Color.White;
            this.grp_taille.Location = new System.Drawing.Point(10, 71);
            this.grp_taille.Name = "grp_taille";
            this.grp_taille.Size = new System.Drawing.Size(210, 118);
            this.grp_taille.TabIndex = 2;
            this.grp_taille.TabStop = false;
            this.grp_taille.Text = "Taille";
            // 
            // rdb_taille7
            // 
            this.rdb_taille7.AutoSize = true;
            this.rdb_taille7.Location = new System.Drawing.Point(17, 91);
            this.rdb_taille7.Name = "rdb_taille7";
            this.rdb_taille7.Size = new System.Drawing.Size(71, 17);
            this.rdb_taille7.TabIndex = 6;
            this.rdb_taille7.Text = "900 * 600";
            this.rdb_taille7.UseVisualStyleBackColor = true;
            this.rdb_taille7.CheckedChanged += new System.EventHandler(this.rdb_taille7_CheckedChanged);
            // 
            // rdb_taille6
            // 
            this.rdb_taille6.AutoSize = true;
            this.rdb_taille6.Location = new System.Drawing.Point(111, 70);
            this.rdb_taille6.Name = "rdb_taille6";
            this.rdb_taille6.Size = new System.Drawing.Size(71, 17);
            this.rdb_taille6.TabIndex = 5;
            this.rdb_taille6.Text = "450 * 300";
            this.rdb_taille6.UseVisualStyleBackColor = true;
            this.rdb_taille6.CheckedChanged += new System.EventHandler(this.rdb_taille6_CheckedChanged);
            // 
            // rdb_taille5
            // 
            this.rdb_taille5.AutoSize = true;
            this.rdb_taille5.Checked = true;
            this.rdb_taille5.Location = new System.Drawing.Point(17, 70);
            this.rdb_taille5.Name = "rdb_taille5";
            this.rdb_taille5.Size = new System.Drawing.Size(71, 17);
            this.rdb_taille5.TabIndex = 4;
            this.rdb_taille5.TabStop = true;
            this.rdb_taille5.Text = "300 * 200";
            this.rdb_taille5.UseVisualStyleBackColor = true;
            this.rdb_taille5.CheckedChanged += new System.EventHandler(this.rdb_taille5_CheckedChanged);
            // 
            // rdb_taille4
            // 
            this.rdb_taille4.AutoSize = true;
            this.rdb_taille4.Location = new System.Drawing.Point(111, 47);
            this.rdb_taille4.Name = "rdb_taille4";
            this.rdb_taille4.Size = new System.Drawing.Size(71, 17);
            this.rdb_taille4.TabIndex = 3;
            this.rdb_taille4.Text = "225 * 150";
            this.rdb_taille4.UseVisualStyleBackColor = true;
            this.rdb_taille4.CheckedChanged += new System.EventHandler(this.rdb_taille4_CheckedChanged);
            // 
            // rdb_taille3
            // 
            this.rdb_taille3.AutoSize = true;
            this.rdb_taille3.Location = new System.Drawing.Point(17, 47);
            this.rdb_taille3.Name = "rdb_taille3";
            this.rdb_taille3.Size = new System.Drawing.Size(71, 17);
            this.rdb_taille3.TabIndex = 2;
            this.rdb_taille3.Text = "180 * 120";
            this.rdb_taille3.UseVisualStyleBackColor = true;
            this.rdb_taille3.CheckedChanged += new System.EventHandler(this.rdb_taille3_CheckedChanged);
            // 
            // rdb_taille2
            // 
            this.rdb_taille2.AutoSize = true;
            this.rdb_taille2.Location = new System.Drawing.Point(111, 24);
            this.rdb_taille2.Name = "rdb_taille2";
            this.rdb_taille2.Size = new System.Drawing.Size(71, 17);
            this.rdb_taille2.TabIndex = 1;
            this.rdb_taille2.Text = "150 * 100";
            this.rdb_taille2.UseVisualStyleBackColor = true;
            this.rdb_taille2.CheckedChanged += new System.EventHandler(this.rdb_taille2_CheckedChanged);
            // 
            // rdb_taille1
            // 
            this.rdb_taille1.AutoSize = true;
            this.rdb_taille1.Location = new System.Drawing.Point(17, 24);
            this.rdb_taille1.Name = "rdb_taille1";
            this.rdb_taille1.Size = new System.Drawing.Size(59, 17);
            this.rdb_taille1.TabIndex = 0;
            this.rdb_taille1.Text = "90 * 60";
            this.rdb_taille1.UseVisualStyleBackColor = true;
            this.rdb_taille1.CheckedChanged += new System.EventHandler(this.rdb_taille1_CheckedChanged);
            // 
            // grp_prop_generation
            // 
            this.grp_prop_generation.Controls.Add(this.grp_graine);
            this.grp_prop_generation.Controls.Add(this.rdb_linéaire);
            this.grp_prop_generation.Controls.Add(this.rdb_alea);
            this.grp_prop_generation.Controls.Add(this.grp_taille);
            this.grp_prop_generation.ForeColor = System.Drawing.Color.White;
            this.grp_prop_generation.Location = new System.Drawing.Point(0, 3);
            this.grp_prop_generation.Name = "grp_prop_generation";
            this.grp_prop_generation.Size = new System.Drawing.Size(230, 316);
            this.grp_prop_generation.TabIndex = 3;
            this.grp_prop_generation.TabStop = false;
            this.grp_prop_generation.Text = "Propriété de génération";
            // 
            // grp_graine
            // 
            this.grp_graine.Controls.Add(this.lbl_nb_graine);
            this.grp_graine.Controls.Add(this.txt_nb_graine);
            this.grp_graine.Controls.Add(this.trk_ratio);
            this.grp_graine.ForeColor = System.Drawing.Color.White;
            this.grp_graine.Location = new System.Drawing.Point(10, 195);
            this.grp_graine.Name = "grp_graine";
            this.grp_graine.Size = new System.Drawing.Size(210, 111);
            this.grp_graine.TabIndex = 7;
            this.grp_graine.TabStop = false;
            this.grp_graine.Text = "Grainage";
            // 
            // lbl_nb_graine
            // 
            this.lbl_nb_graine.AutoSize = true;
            this.lbl_nb_graine.Location = new System.Drawing.Point(6, 26);
            this.lbl_nb_graine.Name = "lbl_nb_graine";
            this.lbl_nb_graine.Size = new System.Drawing.Size(102, 13);
            this.lbl_nb_graine.TabIndex = 9;
            this.lbl_nb_graine.Text = "Nombre de graines :";
            // 
            // txt_nb_graine
            // 
            this.txt_nb_graine.Location = new System.Drawing.Point(109, 19);
            this.txt_nb_graine.MaxLength = 5;
            this.txt_nb_graine.Name = "txt_nb_graine";
            this.txt_nb_graine.Size = new System.Drawing.Size(57, 20);
            this.txt_nb_graine.TabIndex = 8;
            this.txt_nb_graine.Text = "100";
            this.txt_nb_graine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nb_graine.TextChanged += new System.EventHandler(this.txt_nb_graine_TextChanged);
            this.txt_nb_graine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nb_graine_KeyPress);
            this.txt_nb_graine.Leave += new System.EventHandler(this.txt_nb_graine_Leave);
            // 
            // trk_ratio
            // 
            this.trk_ratio.BackColor = System.Drawing.Color.DimGray;
            this.ErrorProvider.SetIconAlignment(this.trk_ratio, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.trk_ratio.LargeChange = 1;
            this.trk_ratio.Location = new System.Drawing.Point(6, 48);
            this.trk_ratio.Maximum = 3000;
            this.trk_ratio.Minimum = 4;
            this.trk_ratio.Name = "trk_ratio";
            this.trk_ratio.Size = new System.Drawing.Size(198, 45);
            this.trk_ratio.TabIndex = 7;
            this.trk_ratio.TickFrequency = 200;
            this.trk_ratio.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trk_ratio.Value = 500;
            this.trk_ratio.Scroll += new System.EventHandler(this.trk_ratio_Scroll);
            // 
            // rdb_linéaire
            // 
            this.rdb_linéaire.AutoSize = true;
            this.rdb_linéaire.Location = new System.Drawing.Point(13, 48);
            this.rdb_linéaire.Name = "rdb_linéaire";
            this.rdb_linéaire.Size = new System.Drawing.Size(119, 17);
            this.rdb_linéaire.TabIndex = 6;
            this.rdb_linéaire.TabStop = true;
            this.rdb_linéaire.Text = "Généré linéairement";
            this.rdb_linéaire.UseVisualStyleBackColor = true;
            // 
            // rdb_alea
            // 
            this.rdb_alea.AutoSize = true;
            this.rdb_alea.Checked = true;
            this.rdb_alea.Location = new System.Drawing.Point(13, 25);
            this.rdb_alea.Name = "rdb_alea";
            this.rdb_alea.Size = new System.Drawing.Size(126, 17);
            this.rdb_alea.TabIndex = 3;
            this.rdb_alea.TabStop = true;
            this.rdb_alea.Text = "Généré aléatoirement";
            this.rdb_alea.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // grp_Affichage
            // 
            this.grp_Affichage.Controls.Add(this.nud_delai);
            this.grp_Affichage.Controls.Add(this.lbl_delai);
            this.grp_Affichage.Controls.Add(this.rdb_construction_normal);
            this.grp_Affichage.Controls.Add(this.rdb_construction_etendu);
            this.grp_Affichage.ForeColor = System.Drawing.Color.White;
            this.grp_Affichage.Location = new System.Drawing.Point(0, 433);
            this.grp_Affichage.Name = "grp_Affichage";
            this.grp_Affichage.Size = new System.Drawing.Size(230, 92);
            this.grp_Affichage.TabIndex = 4;
            this.grp_Affichage.TabStop = false;
            this.grp_Affichage.Text = "Affichage";
            // 
            // nud_delai
            // 
            this.nud_delai.DecimalPlaces = 1;
            this.nud_delai.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_delai.Location = new System.Drawing.Point(155, 64);
            this.nud_delai.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_delai.Name = "nud_delai";
            this.nud_delai.Size = new System.Drawing.Size(65, 20);
            this.nud_delai.TabIndex = 4;
            this.nud_delai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_delai.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // lbl_delai
            // 
            this.lbl_delai.AutoSize = true;
            this.lbl_delai.Location = new System.Drawing.Point(7, 68);
            this.lbl_delai.Name = "lbl_delai";
            this.lbl_delai.Size = new System.Drawing.Size(142, 13);
            this.lbl_delai.TabIndex = 3;
            this.lbl_delai.Text = "Délais entre les étapes (ms) :";
            // 
            // rdb_construction_normal
            // 
            this.rdb_construction_normal.AutoSize = true;
            this.rdb_construction_normal.Checked = true;
            this.rdb_construction_normal.Location = new System.Drawing.Point(52, 20);
            this.rdb_construction_normal.Name = "rdb_construction_normal";
            this.rdb_construction_normal.Size = new System.Drawing.Size(124, 17);
            this.rdb_construction_normal.TabIndex = 2;
            this.rdb_construction_normal.TabStop = true;
            this.rdb_construction_normal.Text = "Construction normale";
            this.rdb_construction_normal.UseVisualStyleBackColor = true;
            // 
            // rdb_construction_etendu
            // 
            this.rdb_construction_etendu.AutoSize = true;
            this.rdb_construction_etendu.Location = new System.Drawing.Point(52, 43);
            this.rdb_construction_etendu.Name = "rdb_construction_etendu";
            this.rdb_construction_etendu.Size = new System.Drawing.Size(126, 17);
            this.rdb_construction_etendu.TabIndex = 1;
            this.rdb_construction_etendu.Text = "Construction étendue";
            this.rdb_construction_etendu.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(52, 544);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(122, 39);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_As_parcour);
            this.groupBox1.Controls.Add(this.chk_As);
            this.groupBox1.Controls.Add(this.chk_Dij_parcour);
            this.groupBox1.Controls.Add(this.chk_Dij);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche de chemin";
            // 
            // chk_As_parcour
            // 
            this.chk_As_parcour.AutoSize = true;
            this.chk_As_parcour.Checked = true;
            this.chk_As_parcour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_As_parcour.Location = new System.Drawing.Point(43, 77);
            this.chk_As_parcour.Name = "chk_As_parcour";
            this.chk_As_parcour.Size = new System.Drawing.Size(90, 17);
            this.chk_As_parcour.TabIndex = 2;
            this.chk_As_parcour.Text = "Avec parcour";
            this.chk_As_parcour.UseVisualStyleBackColor = true;
            this.chk_As_parcour.Visible = false;
            // 
            // chk_As
            // 
            this.chk_As.AutoSize = true;
            this.chk_As.Location = new System.Drawing.Point(10, 58);
            this.chk_As.Name = "chk_As";
            this.chk_As.Size = new System.Drawing.Size(40, 17);
            this.chk_As.TabIndex = 1;
            this.chk_As.Text = "A *";
            this.chk_As.UseVisualStyleBackColor = true;
            this.chk_As.CheckedChanged += new System.EventHandler(this.chk_As_CheckedChanged);
            // 
            // chk_Dij_parcour
            // 
            this.chk_Dij_parcour.AutoSize = true;
            this.chk_Dij_parcour.Checked = true;
            this.chk_Dij_parcour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Dij_parcour.Location = new System.Drawing.Point(43, 39);
            this.chk_Dij_parcour.Name = "chk_Dij_parcour";
            this.chk_Dij_parcour.Size = new System.Drawing.Size(90, 17);
            this.chk_Dij_parcour.TabIndex = 1;
            this.chk_Dij_parcour.Text = "Avec parcour";
            this.chk_Dij_parcour.UseVisualStyleBackColor = true;
            this.chk_Dij_parcour.Visible = false;
            // 
            // chk_Dij
            // 
            this.chk_Dij.AutoSize = true;
            this.chk_Dij.Location = new System.Drawing.Point(10, 20);
            this.chk_Dij.Name = "chk_Dij";
            this.chk_Dij.Size = new System.Drawing.Size(61, 17);
            this.chk_Dij.TabIndex = 0;
            this.chk_Dij.Text = "Dijsktra";
            this.chk_Dij.UseVisualStyleBackColor = true;
            this.chk_Dij.CheckedChanged += new System.EventHandler(this.chk_Dij_CheckedChanged);
            // 
            // Ctrl_Labyrinthe_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grp_Affichage);
            this.Controls.Add(this.grp_prop_generation);
            this.Name = "Ctrl_Labyrinthe_Panel";
            this.Size = new System.Drawing.Size(230, 591);
            this.grp_taille.ResumeLayout(false);
            this.grp_taille.PerformLayout();
            this.grp_prop_generation.ResumeLayout(false);
            this.grp_prop_generation.PerformLayout();
            this.grp_graine.ResumeLayout(false);
            this.grp_graine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grp_Affichage.ResumeLayout(false);
            this.grp_Affichage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_taille;
        private System.Windows.Forms.GroupBox grp_prop_generation;
        private System.Windows.Forms.RadioButton rdb_alea;
        private System.Windows.Forms.HelpProvider HelpProvider;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.GroupBox grp_Affichage;
        public System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.RadioButton rdb_construction_normal;
        public System.Windows.Forms.RadioButton rdb_construction_etendu;
        private System.Windows.Forms.RadioButton rdb_linéaire;
        private System.Windows.Forms.RadioButton rdb_taille7;
        private System.Windows.Forms.RadioButton rdb_taille6;
        private System.Windows.Forms.RadioButton rdb_taille5;
        private System.Windows.Forms.RadioButton rdb_taille4;
        private System.Windows.Forms.RadioButton rdb_taille3;
        private System.Windows.Forms.RadioButton rdb_taille2;
        private System.Windows.Forms.RadioButton rdb_taille1;
        private System.Windows.Forms.GroupBox grp_graine;
        private System.Windows.Forms.TrackBar trk_ratio;
        private System.Windows.Forms.Label lbl_nb_graine;
        private System.Windows.Forms.TextBox txt_nb_graine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_As_parcour;
        private System.Windows.Forms.CheckBox chk_As;
        private System.Windows.Forms.CheckBox chk_Dij_parcour;
        private System.Windows.Forms.CheckBox chk_Dij;
        private System.Windows.Forms.NumericUpDown nud_delai;
        private System.Windows.Forms.Label lbl_delai;
    }
}
