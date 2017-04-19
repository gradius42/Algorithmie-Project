using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithmie_Project
{
    public partial class Ctrl_Labyrinthe_Panel : UserControl
    {
        public Ctrl_Labyrinthe_Panel()
        {
            InitializeComponent();
        }
        

        private void chk_Dij_CheckedChanged(object sender, EventArgs e)
        {
            
            chk_Dij_parcour.Visible = chk_Dij.Checked;
        }

        private void chk_As_CheckedChanged(object sender, EventArgs e)
        {
            chk_As_parcour.Visible = chk_As.Checked;
        }

        private void trk_ratio_Scroll(object sender, EventArgs e)
        {
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void rdb_taille1_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_taille1.Checked)
                return;

            trk_ratio.Maximum = 90 * 60 * 3 / 100;
            trk_ratio.Value = trk_ratio.Maximum / 15;
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void rdb_taille2_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_taille2.Checked)
                return;


            trk_ratio.Maximum = 150 * 100 * 3 / 100;
            trk_ratio.Value = trk_ratio.Maximum / 15;
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void rdb_taille3_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_taille3.Checked)
                return;

            trk_ratio.Maximum = 180 * 120 * 3 / 100;
            trk_ratio.Value = trk_ratio.Maximum / 15;
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void rdb_taille4_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_taille4.Checked)
                return;

            trk_ratio.Maximum = 225 * 150 * 3 / 100;
            trk_ratio.Value = trk_ratio.Maximum / 15;
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void rdb_taille5_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_taille5.Checked)
                return;


            trk_ratio.Maximum = 300 * 200 * 3 / 100;
            trk_ratio.Value = trk_ratio.Maximum / 15;
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void rdb_taille6_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_taille6.Checked)
                return;

            trk_ratio.Maximum = 450 * 300 * 3 / 100;
            trk_ratio.Value = trk_ratio.Maximum / 15;
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void rdb_taille7_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_taille7.Checked)
                return;

            trk_ratio.Maximum = 900 * 600 * 3 / 100;
            trk_ratio.Value = trk_ratio.Maximum / 15;
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Global.graph.Clear(Color.White);

            // Affichage
            Labyrinthe.lineaire = rdb_linéaire.Checked;
            Labyrinthe.d_graph = rdb_construction_etendu.Checked;

            // Dijkstra 
            Labyrinthe.Dij = chk_Dij.Checked ;
            Labyrinthe.Dij_rech = chk_Dij.Checked && chk_Dij_parcour.Checked;

            // A*
            Labyrinthe.AStar = chk_As.Checked;
            Labyrinthe.AStar_rech = chk_As.Checked && chk_As_parcour.Checked;

            // Délai
            Labyrinthe.Auto = (int)(nud_delai.Value * 1000);

            int h, w;

            if (rdb_taille1.Checked)
            {
                w = 90;
                h = 60;
                Labyrinthe.case_width = 10;
            }
            else if (rdb_taille2.Checked)
            {
                w = 150;
                h = 100;
                Labyrinthe.case_width = 6;
            }
            else if (rdb_taille3.Checked)
            {
                w = 180;
                h = 120;
                Labyrinthe.case_width = 5;
            }
            else if (rdb_taille4.Checked)
            {
                w = 225;
                h = 150;
                Labyrinthe.case_width = 4;
            }
            else if (rdb_taille5.Checked)
            {
                w = 300;
                h = 200;
                Labyrinthe.case_width = 3;
            }
            else if (rdb_taille6.Checked)
            {
                w = 450;
                h = 300;
                Labyrinthe.case_width = 2;
            }
            else if (rdb_taille7.Checked)
            {
                w = 900;
                h = 600;
                Labyrinthe.case_width = 1;
            }
            else
            {
                w = 300;
                h = 200;
                Labyrinthe.case_width = 3;
            }

            Labyrinthe lab = new Labyrinthe(w, h, trk_ratio.Value);

            lab.lanceRecherche();

        }

        private void txt_nb_graine_TextChanged(object sender, EventArgs e)
        {
            if (txt_nb_graine.Text != "" && Int32.Parse(txt_nb_graine.Text) > 4)
                trk_ratio.Value = Int32.Parse(txt_nb_graine.Text);
            else
                trk_ratio.Value = 4;
        }

        private void txt_nb_graine_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Delete
                && !int.TryParse(e.KeyChar.ToString(), out i)
                && e.KeyChar != (char)Keys.Left
                && e.KeyChar != (char)Keys.Right
                && e.KeyChar != (char)Keys.Down
                && e.KeyChar != (char)Keys.Up
                && e.KeyChar != (char)Keys.Tab
                )
            {
                e.Handled = true;
            }
        }

        private void txt_nb_graine_Leave(object sender, EventArgs e)
        {
            txt_nb_graine.Text = trk_ratio.Value.ToString();
        }
    }
}
