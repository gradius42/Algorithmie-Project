using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Algorithmie_Project
{
    public class TestScript
    {
        public static void TestSorting()
        {
            // init form
            Global.form.cmb_cat_algo.SelectedIndex = 0;
            Global.my_Sorting_panel.rdb_Points_Display.Checked = true;
            
            // Simple sort
            Global.my_Sorting_panel.Update();

            Global.my_Sorting_panel.rdb_150.Checked = true;

            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 0;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 1;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 2;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 3;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);

            // Complexe sort
            Global.my_Sorting_panel.rdb_900.Checked = true;

            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 6;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 8;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 4;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 7;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


            Global.my_Sorting_panel.cmb_Sorting.SelectedIndex = 5;
            Global.my_Sorting_panel.cmb_Sorting.Update();
            Global.my_Sorting_panel.btn_start.PerformClick();
            Thread.Sleep(3500);


        }

        


    }
}
