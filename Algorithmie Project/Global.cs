using System;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmie_Project
{
    public static class Global
    {
        // ====== Général ====== //

        public static MainFrame form;
        
        public static Thread activ_process;

        // ====== Graphics ====== //

        public static Pen myPen = new Pen(Color.White);
        
        public static Graphics graph;

        public static int P_Width = 900;

        public static int P_Height = 600;

        public static Graphics comment;

        // ====== Control Panel ====== //

        public static Ctrl_Sorting_Panel my_Sorting_panel;

        public static Ctrl_Labyrinthe_Panel my_Labyrinthe_panel;

        public static Ctrl_Fractal_Tree_Panel my_Fractal_Tree_Panel;
    }
}
