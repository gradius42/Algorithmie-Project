using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Algorithmie_Project
{
    public partial class Ctrl_Fractal_Tree_Panel : UserControl
    {
        public Ctrl_Fractal_Tree_Panel()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Fractal_Tree.Fractal(45);
        }

        private void pan_color_1_Click(object sender, EventArgs e)
        {
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowDialog();
            pan_color_1.BackColor = colorDialog.Color;
            colorDialog.Color = Color.White;
        }

        private void pan_color_2_Click(object sender, EventArgs e)
        {
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowDialog();
            pan_color_2.BackColor = colorDialog.Color;
            colorDialog.Color = Color.White;
        }

        private void pan_color_3_Click(object sender, EventArgs e)
        {
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowDialog();
            pan_color_3.BackColor = colorDialog.Color;
            colorDialog.Color = Color.White;
        }

        private void trk_angle_Scroll(object sender, EventArgs e)
        {
            txt_angle.Text = trk_angle.Value.ToString();

            Global.graph.Clear(Color.Black);
            Fractal_Tree.Fractal((float)trk_angle.Value);
        }

        private void trk_rotation_Scroll(object sender, EventArgs e)
        {
            txt_rotation.Text = trk_rotation.Value.ToString();

            Global.graph.Clear(Color.Black);
            Fractal_Tree.Fractal((float)trk_angle.Value);
        }

        private void txt_angle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_rotation_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_angle_Leave(object sender, EventArgs e)
        {
            txt_angle.Text = trk_angle.Value.ToString();
        }

        private void txt_rotation_Leave(object sender, EventArgs e)
        {
            txt_rotation.Text = trk_rotation.Value.ToString();
        }

        private void txt_angle_TextChanged(object sender, EventArgs e)
        {
            if (txt_angle.Text != "" && Int32.Parse(txt_angle.Text) <= 180)
                trk_angle.Value = Int32.Parse(txt_angle.Text);
            else
                trk_angle.Value = 180;
        }

        private void txt_rotation_TextChanged(object sender, EventArgs e)
        {
            if (txt_angle.Text != "" && Int32.Parse(txt_angle.Text) <= 180  && Int32.Parse(txt_angle.Text) >= -180)
                trk_angle.Value = Int32.Parse(txt_angle.Text);
            else
                trk_angle.Value = 0;
        }
    }
}
