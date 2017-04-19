namespace Algorithmie_Project
{
    partial class Ctrl_Sorting_Panel
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
            this.lbl_cmb_tri = new System.Windows.Forms.Label();
            this.cmb_Sorting = new System.Windows.Forms.ComboBox();
            this.grp_nb_value = new System.Windows.Forms.GroupBox();
            this.rdb_900 = new System.Windows.Forms.RadioButton();
            this.rdb_600 = new System.Windows.Forms.RadioButton();
            this.rdb_300 = new System.Windows.Forms.RadioButton();
            this.rdb_100 = new System.Windows.Forms.RadioButton();
            this.rdb_50 = new System.Windows.Forms.RadioButton();
            this.rdb_150 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Manuel = new System.Windows.Forms.TextBox();
            this.rdb_Manuel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Esn_val = new System.Windows.Forms.TextBox();
            this.rdb_Ens_Val = new System.Windows.Forms.RadioButton();
            this.rdb_full = new System.Windows.Forms.RadioButton();
            this.rdb_alea = new System.Windows.Forms.RadioButton();
            this.HelpProvider = new System.Windows.Forms.HelpProvider();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Affichage = new System.Windows.Forms.GroupBox();
            this.rdb_Points_Display = new System.Windows.Forms.RadioButton();
            this.rdb_Col_Thin = new System.Windows.Forms.RadioButton();
            this.rdb_Col_Full = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.grp_nb_value.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grp_Affichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cmb_tri
            // 
            this.lbl_cmb_tri.AutoSize = true;
            this.lbl_cmb_tri.ForeColor = System.Drawing.Color.White;
            this.lbl_cmb_tri.Location = new System.Drawing.Point(84, 4);
            this.lbl_cmb_tri.Name = "lbl_cmb_tri";
            this.lbl_cmb_tri.Size = new System.Drawing.Size(63, 13);
            this.lbl_cmb_tri.TabIndex = 0;
            this.lbl_cmb_tri.Text = "Type de tri :";
            // 
            // cmb_Sorting
            // 
            this.cmb_Sorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sorting.FormattingEnabled = true;
            this.cmb_Sorting.Items.AddRange(new object[] {
            "Selection Sort",
            "Insertion Sort",
            "Bubble Sort",
            "Shaker Sort",
            "Quick Sort",
            "Radix LSD Sort",
            "Merge Sort",
            "Heap Sort",
            "Bitonic Sort"});
            this.cmb_Sorting.Location = new System.Drawing.Point(39, 22);
            this.cmb_Sorting.Name = "cmb_Sorting";
            this.cmb_Sorting.Size = new System.Drawing.Size(152, 21);
            this.cmb_Sorting.TabIndex = 1;
            this.cmb_Sorting.SelectedIndexChanged += new System.EventHandler(this.cmb_Sorting_SelectedIndexChanged);
            // 
            // grp_nb_value
            // 
            this.grp_nb_value.Controls.Add(this.rdb_900);
            this.grp_nb_value.Controls.Add(this.rdb_600);
            this.grp_nb_value.Controls.Add(this.rdb_300);
            this.grp_nb_value.Controls.Add(this.rdb_100);
            this.grp_nb_value.Controls.Add(this.rdb_50);
            this.grp_nb_value.Controls.Add(this.rdb_150);
            this.grp_nb_value.ForeColor = System.Drawing.Color.White;
            this.grp_nb_value.Location = new System.Drawing.Point(12, 22);
            this.grp_nb_value.Name = "grp_nb_value";
            this.grp_nb_value.Size = new System.Drawing.Size(210, 98);
            this.grp_nb_value.TabIndex = 2;
            this.grp_nb_value.TabStop = false;
            this.grp_nb_value.Text = "Nombre de valeur :";
            // 
            // rdb_900
            // 
            this.rdb_900.AutoSize = true;
            this.rdb_900.Location = new System.Drawing.Point(147, 68);
            this.rdb_900.Name = "rdb_900";
            this.rdb_900.Size = new System.Drawing.Size(43, 17);
            this.rdb_900.TabIndex = 6;
            this.rdb_900.Text = "900";
            this.rdb_900.UseVisualStyleBackColor = true;
            // 
            // rdb_600
            // 
            this.rdb_600.AutoSize = true;
            this.rdb_600.Location = new System.Drawing.Point(83, 68);
            this.rdb_600.Name = "rdb_600";
            this.rdb_600.Size = new System.Drawing.Size(43, 17);
            this.rdb_600.TabIndex = 5;
            this.rdb_600.Text = "600";
            this.rdb_600.UseVisualStyleBackColor = true;
            // 
            // rdb_300
            // 
            this.rdb_300.AutoSize = true;
            this.rdb_300.Location = new System.Drawing.Point(19, 68);
            this.rdb_300.Name = "rdb_300";
            this.rdb_300.Size = new System.Drawing.Size(43, 17);
            this.rdb_300.TabIndex = 4;
            this.rdb_300.Text = "300";
            this.rdb_300.UseVisualStyleBackColor = true;
            // 
            // rdb_100
            // 
            this.rdb_100.AutoSize = true;
            this.rdb_100.Location = new System.Drawing.Point(81, 24);
            this.rdb_100.Name = "rdb_100";
            this.rdb_100.Size = new System.Drawing.Size(43, 17);
            this.rdb_100.TabIndex = 3;
            this.rdb_100.Text = "100";
            this.rdb_100.UseVisualStyleBackColor = true;
            // 
            // rdb_50
            // 
            this.rdb_50.AutoSize = true;
            this.rdb_50.Location = new System.Drawing.Point(19, 24);
            this.rdb_50.Name = "rdb_50";
            this.rdb_50.Size = new System.Drawing.Size(37, 17);
            this.rdb_50.TabIndex = 2;
            this.rdb_50.Text = "50";
            this.rdb_50.UseVisualStyleBackColor = true;
            // 
            // rdb_150
            // 
            this.rdb_150.AutoSize = true;
            this.rdb_150.Checked = true;
            this.rdb_150.Location = new System.Drawing.Point(149, 24);
            this.rdb_150.Name = "rdb_150";
            this.rdb_150.Size = new System.Drawing.Size(43, 17);
            this.rdb_150.TabIndex = 1;
            this.rdb_150.TabStop = true;
            this.rdb_150.Text = "150";
            this.rdb_150.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Manuel);
            this.groupBox1.Controls.Add(this.rdb_Manuel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rdb_alea);
            this.groupBox1.Controls.Add(this.grp_nb_value);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 378);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriété du tableau";
            // 
            // txt_Manuel
            // 
            this.txt_Manuel.Enabled = false;
            this.txt_Manuel.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Manuel.Location = new System.Drawing.Point(12, 305);
            this.txt_Manuel.Multiline = true;
            this.txt_Manuel.Name = "txt_Manuel";
            this.txt_Manuel.Size = new System.Drawing.Size(210, 59);
            this.txt_Manuel.TabIndex = 3;
            this.txt_Manuel.Text = "Ex : 1,2,3,4,5,6";
            this.txt_Manuel.Enter += new System.EventHandler(this.txt_Manuel_Enter);
            this.txt_Manuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Manuel_KeyPress);
            this.txt_Manuel.Leave += new System.EventHandler(this.txt_Manuel_Leave);
            // 
            // rdb_Manuel
            // 
            this.rdb_Manuel.AutoSize = true;
            this.rdb_Manuel.Location = new System.Drawing.Point(13, 282);
            this.rdb_Manuel.Name = "rdb_Manuel";
            this.rdb_Manuel.Size = new System.Drawing.Size(117, 17);
            this.rdb_Manuel.TabIndex = 5;
            this.rdb_Manuel.TabStop = true;
            this.rdb_Manuel.Text = "Dénini manuellemnt";
            this.rdb_Manuel.UseVisualStyleBackColor = true;
            this.rdb_Manuel.CheckedChanged += new System.EventHandler(this.rdb_Manuel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Esn_val);
            this.groupBox2.Controls.Add(this.rdb_Ens_Val);
            this.groupBox2.Controls.Add(this.rdb_full);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ensemble de valeur :";
            // 
            // txt_Esn_val
            // 
            this.txt_Esn_val.Enabled = false;
            this.txt_Esn_val.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Esn_val.Location = new System.Drawing.Point(27, 67);
            this.txt_Esn_val.Multiline = true;
            this.txt_Esn_val.Name = "txt_Esn_val";
            this.txt_Esn_val.Size = new System.Drawing.Size(175, 43);
            this.txt_Esn_val.TabIndex = 2;
            this.txt_Esn_val.Text = "Ex : 1,2,3,4,5,6";
            this.txt_Esn_val.Enter += new System.EventHandler(this.txt_Esn_val_Enter);
            this.txt_Esn_val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Esn_val_KeyPress);
            this.txt_Esn_val.Leave += new System.EventHandler(this.txt_Esn_val_Leave);
            // 
            // rdb_Ens_Val
            // 
            this.rdb_Ens_Val.AutoSize = true;
            this.rdb_Ens_Val.Location = new System.Drawing.Point(15, 45);
            this.rdb_Ens_Val.Name = "rdb_Ens_Val";
            this.rdb_Ens_Val.Size = new System.Drawing.Size(124, 17);
            this.rdb_Ens_Val.TabIndex = 1;
            this.rdb_Ens_Val.Text = "Ensemble de valeur :";
            this.rdb_Ens_Val.UseVisualStyleBackColor = true;
            this.rdb_Ens_Val.CheckedChanged += new System.EventHandler(this.rdb_Ens_Val_CheckedChanged);
            // 
            // rdb_full
            // 
            this.rdb_full.AutoSize = true;
            this.rdb_full.Checked = true;
            this.rdb_full.Location = new System.Drawing.Point(15, 22);
            this.rdb_full.Name = "rdb_full";
            this.rdb_full.Size = new System.Drawing.Size(172, 17);
            this.rdb_full.TabIndex = 0;
            this.rdb_full.TabStop = true;
            this.rdb_full.Text = "Continue et croissante [ 1 , nb ]";
            this.rdb_full.UseVisualStyleBackColor = true;
            this.rdb_full.CheckedChanged += new System.EventHandler(this.rdb_full_CheckedChanged);
            // 
            // rdb_alea
            // 
            this.rdb_alea.AutoSize = true;
            this.rdb_alea.Checked = true;
            this.rdb_alea.Location = new System.Drawing.Point(13, 126);
            this.rdb_alea.Name = "rdb_alea";
            this.rdb_alea.Size = new System.Drawing.Size(126, 17);
            this.rdb_alea.TabIndex = 3;
            this.rdb_alea.TabStop = true;
            this.rdb_alea.Text = "Généré aléatoirement";
            this.rdb_alea.UseVisualStyleBackColor = true;
            this.rdb_alea.CheckedChanged += new System.EventHandler(this.rdb_alea_CheckedChanged);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // grp_Affichage
            // 
            this.grp_Affichage.Controls.Add(this.rdb_Points_Display);
            this.grp_Affichage.Controls.Add(this.rdb_Col_Thin);
            this.grp_Affichage.Controls.Add(this.rdb_Col_Full);
            this.grp_Affichage.ForeColor = System.Drawing.Color.White;
            this.grp_Affichage.Location = new System.Drawing.Point(0, 433);
            this.grp_Affichage.Name = "grp_Affichage";
            this.grp_Affichage.Size = new System.Drawing.Size(230, 69);
            this.grp_Affichage.TabIndex = 4;
            this.grp_Affichage.TabStop = false;
            this.grp_Affichage.Text = "Affichage";
            // 
            // rdb_Points_Display
            // 
            this.rdb_Points_Display.AutoSize = true;
            this.rdb_Points_Display.Location = new System.Drawing.Point(10, 43);
            this.rdb_Points_Display.Name = "rdb_Points_Display";
            this.rdb_Points_Display.Size = new System.Drawing.Size(98, 17);
            this.rdb_Points_Display.TabIndex = 2;
            this.rdb_Points_Display.Text = "Nuage de point";
            this.rdb_Points_Display.UseVisualStyleBackColor = true;
            // 
            // rdb_Col_Thin
            // 
            this.rdb_Col_Thin.AutoSize = true;
            this.rdb_Col_Thin.Location = new System.Drawing.Point(132, 43);
            this.rdb_Col_Thin.Name = "rdb_Col_Thin";
            this.rdb_Col_Thin.Size = new System.Drawing.Size(84, 17);
            this.rdb_Col_Thin.TabIndex = 1;
            this.rdb_Col_Thin.Text = "Colonne fine";
            this.rdb_Col_Thin.UseVisualStyleBackColor = true;
            // 
            // rdb_Col_Full
            // 
            this.rdb_Col_Full.AutoSize = true;
            this.rdb_Col_Full.Checked = true;
            this.rdb_Col_Full.Location = new System.Drawing.Point(70, 20);
            this.rdb_Col_Full.Name = "rdb_Col_Full";
            this.rdb_Col_Full.Size = new System.Drawing.Size(95, 17);
            this.rdb_Col_Full.TabIndex = 0;
            this.rdb_Col_Full.TabStop = true;
            this.rdb_Col_Full.Text = "Colonne pleine";
            this.rdb_Col_Full.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(54, 530);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(122, 39);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Ctrl_Sorting_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grp_Affichage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Sorting);
            this.Controls.Add(this.lbl_cmb_tri);
            this.Name = "Ctrl_Sorting_Panel";
            this.Size = new System.Drawing.Size(230, 583);
            this.grp_nb_value.ResumeLayout(false);
            this.grp_nb_value.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grp_Affichage.ResumeLayout(false);
            this.grp_Affichage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cmb_tri;
        private System.Windows.Forms.GroupBox grp_nb_value;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_alea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Esn_val;
        private System.Windows.Forms.RadioButton rdb_Ens_Val;
        private System.Windows.Forms.RadioButton rdb_full;
        private System.Windows.Forms.HelpProvider HelpProvider;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.TextBox txt_Manuel;
        private System.Windows.Forms.RadioButton rdb_Manuel;
        private System.Windows.Forms.GroupBox grp_Affichage;
        public System.Windows.Forms.ComboBox cmb_Sorting;
        public System.Windows.Forms.RadioButton rdb_600;
        public System.Windows.Forms.RadioButton rdb_300;
        public System.Windows.Forms.RadioButton rdb_100;
        public System.Windows.Forms.RadioButton rdb_50;
        public System.Windows.Forms.RadioButton rdb_150;
        public System.Windows.Forms.Button btn_start;
        public System.Windows.Forms.RadioButton rdb_Points_Display;
        public System.Windows.Forms.RadioButton rdb_Col_Thin;
        public System.Windows.Forms.RadioButton rdb_Col_Full;
        public System.Windows.Forms.RadioButton rdb_900;
    }
}
