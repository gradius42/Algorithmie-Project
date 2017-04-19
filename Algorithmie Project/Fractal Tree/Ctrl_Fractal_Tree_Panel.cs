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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Global.graph.Clear(Color.Black);
            Fractal_Tree.Fractal((float)trk_angle.Value);
        }
    }
}
