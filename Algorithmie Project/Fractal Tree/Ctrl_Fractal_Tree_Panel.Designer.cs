namespace Algorithmie_Project
{
    partial class Ctrl_Fractal_Tree_Panel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HelpProvider = new System.Windows.Forms.HelpProvider();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Affichage = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.trk_angle = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_angle)).BeginInit();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trk_angle);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 378);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriété";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // grp_Affichage
            // 
            this.grp_Affichage.ForeColor = System.Drawing.Color.White;
            this.grp_Affichage.Location = new System.Drawing.Point(0, 433);
            this.grp_Affichage.Name = "grp_Affichage";
            this.grp_Affichage.Size = new System.Drawing.Size(230, 69);
            this.grp_Affichage.TabIndex = 4;
            this.grp_Affichage.TabStop = false;
            this.grp_Affichage.Text = "Affichage";
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
            // trk_angle
            // 
            this.trk_angle.Location = new System.Drawing.Point(6, 92);
            this.trk_angle.Maximum = 180;
            this.trk_angle.Minimum = -180;
            this.trk_angle.Name = "trk_angle";
            this.trk_angle.Size = new System.Drawing.Size(218, 45);
            this.trk_angle.TabIndex = 0;
            this.trk_angle.TickFrequency = 30;
            this.trk_angle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trk_angle.Value = 45;
            this.trk_angle.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Ctrl_Fractal_Tree_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grp_Affichage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Sorting);
            this.Controls.Add(this.lbl_cmb_tri);
            this.Name = "Ctrl_Fractal_Tree_Panel";
            this.Size = new System.Drawing.Size(230, 600);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_angle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cmb_tri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HelpProvider HelpProvider;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.GroupBox grp_Affichage;
        public System.Windows.Forms.ComboBox cmb_Sorting;
        public System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TrackBar trk_angle;
    }
}
