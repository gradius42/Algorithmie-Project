using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithmie_Project
{
    public partial class MainFrame : Form
    {       

        public MainFrame()
        {
            InitializeComponent();

            Global.my_Sorting_panel = new Ctrl_Sorting_Panel();
            Global.my_Labyrinthe_panel = new Ctrl_Labyrinthe_Panel();
            Global.my_Fractal_Tree_Panel = new Ctrl_Fractal_Tree_Panel();

            canvas.Refresh();

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        public void canvas_Paint(object sender, PaintEventArgs e)
        {
            
            Global.graph = canvas.CreateGraphics();
            Global.comment = canvasComment.CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SortingArray sa = new SortingArray(300,new int[] { 1, 2, 3, 4, 5,6,7,8,9 });
            //SortingArray sa = new SortingArray(64);
            //sa.DrawTab(Color.White);
            //Console.WriteLine(sa.ToString());
            //sa.BitonicG();
            //Console.WriteLine(sa.ToString());
            //sa.DrawTab(Color.Green);

            TestScript.TestSorting();

            //Global.graph.FillRectangle(Brushes.Aqua, 0, 0,3,600);
        }

        public void refresh_canvas()
        {
            canvas.Refresh();
        }
        
        private void cmb_cat_algo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_cat_algo.SelectedIndex)
            {
                case -1: // default
                    pan_option_menu.Controls.Clear();
                    break;
                case 0: // Tri
                    pan_option_menu.Controls.Clear();
                    pan_option_menu.Controls.Add(Global.my_Sorting_panel);
                    break;
                case 1: // Labyrinthe
                    pan_option_menu.Controls.Clear();
                    pan_option_menu.Controls.Add(Global.my_Labyrinthe_panel);
                    break;
                case 2:
                    pan_option_menu.Controls.Clear();
                    pan_option_menu.Controls.Add(Global.my_Fractal_Tree_Panel);
                    break;


            }
        }
        
    }
}
