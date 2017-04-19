using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithmie_Project
{
    public partial class Ctrl_Sorting_Panel : UserControl
    {
        public Ctrl_Sorting_Panel()
        {
            InitializeComponent();
        }

        //*** Selection Ensemble de valeur

        private void rdb_full_CheckedChanged(object sender, EventArgs e)
        {
            ErrorProvider.SetError(rdb_Ens_Val, "");
        }

        private void txt_Esn_val_Enter(object sender, EventArgs e)
        {
            if(txt_Esn_val.Text == "Ex : 1,2,3,4,5,6")
            {
                txt_Esn_val.Text = "";
                txt_Esn_val.ForeColor = Color.Black;

            }
        }

        private void txt_Esn_val_Leave(object sender, EventArgs e)
        {
            if (txt_Esn_val.Text == "")
            {
                txt_Esn_val.Text = "Ex : 1,2,3,4,5,6";
                txt_Esn_val.ForeColor = Color.DimGray;
                ErrorProvider.SetError(rdb_Ens_Val, "Vous devez indiquer des valeurs !");
            }
            else
                ErrorProvider.SetError(rdb_Ens_Val, "");
        }

        private void rdb_Ens_Val_CheckedChanged(object sender, EventArgs e)
        {
            txt_Esn_val.Enabled = rdb_Ens_Val.Checked;

            if (rdb_Ens_Val.Checked)
            {
                HelpProvider.SetHelpString(rdb_Ens_Val, " min : 1 ; max : 600 ");
            }
            else
            {
                HelpProvider.SetHelpString(rdb_Ens_Val, "");
                txt_Esn_val.Text = "Ex : 1,2,3,4,5,6";
                txt_Esn_val.ForeColor = Color.DimGray;
                ErrorProvider.SetError(txt_Esn_val, "");
            }
        }

        private void txt_Esn_val_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Delete
                && !int.TryParse(e.KeyChar.ToString(), out i)
                && e.KeyChar != ','
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

        //*** Selection Manuelle

        private void rdb_alea_CheckedChanged(object sender, EventArgs e)
        {
            ErrorProvider.SetError(rdb_Manuel, "");
        }

        private void rdb_Manuel_CheckedChanged(object sender, EventArgs e)
        {
            txt_Manuel.Enabled = rdb_Manuel.Checked;

            if (rdb_Manuel.Checked)
            {
                HelpProvider.SetHelpString(rdb_Manuel, " min : 1 ; max : 600 ");
            }
            else
            {
                HelpProvider.SetHelpString(rdb_Manuel, "");
                txt_Manuel.Text = "Ex : 1,2,3,4,5,6";
                txt_Manuel.ForeColor = Color.DimGray;
                ErrorProvider.SetError(txt_Esn_val, "");
            }
        }

        private void txt_Manuel_Enter(object sender, EventArgs e)
        {
            if (txt_Manuel.Text == "Ex : 1,2,3,4,5,6")
            {
                txt_Manuel.Text = "";
                txt_Manuel.ForeColor = Color.Black;

            }
        }

        private void txt_Manuel_Leave(object sender, EventArgs e)
        {
            if (txt_Manuel.Text == "")
            {
                txt_Manuel.Text = "Ex : 1,2,3,4,5,6";
                txt_Manuel.ForeColor = Color.DimGray;
                ErrorProvider.SetError(rdb_Manuel, "Vous devez indiquer des valeurs !");
            }
            else
                ErrorProvider.SetError(rdb_Manuel, "Vous devez indiquer des valeurs !");
        }
        
        private void txt_Manuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Delete
                && !int.TryParse(e.KeyChar.ToString(), out i)
                && e.KeyChar != ','
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

        //*** Start Action

        private void btn_start_Click(object sender, EventArgs e)
        {

            Global.graph.Clear(Color.Black);
            Global.comment.Clear(Color.DimGray);

            if (cmb_Sorting.SelectedIndex != -1)
            {
                //--- Update Display

                if (rdb_Col_Full.Checked)
                    SortingArray.displayType = 0;
                else if (rdb_Col_Thin.Checked)
                    SortingArray.displayType = 1;
                else if (rdb_Points_Display.Checked)
                    SortingArray.displayType = 2;

                //--- Creating SortingArray

                SortingArray sa = new SortingArray();

                if (rdb_alea.Checked)
                {
                    int nb;

                    if (rdb_50.Checked)
                        nb = cmb_Sorting.SelectedIndex != 8 ? 50 : 32;
                    else if (rdb_100.Checked)
                        nb = cmb_Sorting.SelectedIndex != 8 ? 100 : 64;
                    else if (rdb_150.Checked)
                        nb = cmb_Sorting.SelectedIndex != 8 ? 150 : 128;
                    else if (rdb_300.Checked)
                        nb = cmb_Sorting.SelectedIndex != 8 ? 300 : 256;
                    else if (rdb_600.Checked)
                        nb = cmb_Sorting.SelectedIndex != 8 ? 600 : 512;
                    else if (rdb_900.Checked)
                        nb = cmb_Sorting.SelectedIndex != 8 ? 900 : 1024;
                    else
                        nb = cmb_Sorting.SelectedIndex != 8 ? 100 : 64;

                    if (rdb_full.Checked)
                        sa = new SortingArray(nb);
                    else
                    {
                        string[] buf = txt_Esn_val.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        int[] tab = new int[buf.Length];

                        for (int i = 0; i < buf.Length; i++)
                            tab[i] = int.Parse(buf[i]);

                        sa = new SortingArray(nb, tab);
                    }

                }
                else if (rdb_Manuel.Checked)
                {
                    string[] buf = txt_Manuel.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] tab = new int[buf.Length];

                    for (int i = 0; i < buf.Length; i++)
                        tab[i] = int.Parse(buf[i]);

                    sa = new SortingArray(tab);
                }




                // Writing Message
                string msg = cmb_Sorting.Text;
                Font font = new Font("Lato", 30, FontStyle.Italic | FontStyle.Bold);

                Global.comment.DrawString(msg, font, Brushes.White, 240,5);

                msg = "Nombre de valeur : " + sa.length;
                Font f2 = new Font("Lato", 15);

                Global.comment.DrawString(msg, f2, Brushes.White, 235, 60);

                //--- Launching Sorting

                sa.DrawTab(Color.White);

                switch (cmb_Sorting.SelectedIndex)
                {
                    case 0:
                        //Global.activ_process = new Thread 
                        sa.SelectionSortG();
                        break;
                    case 1:
                        sa.InsertionSortG();
                        break;
                    case 2:
                        sa.BubbleSortG();
                        break;
                    case 3:
                        sa.ShakerSortG();
                        break;
                    case 4:
                        sa.QuickSortG(0,(int)sa.length-1);
                        break;
                    case 5:
                        sa.RadixLsdSortG();
                        break;
                    case 6:
                        sa.MergeSortG(0, (int)sa.length - 1);
                        break;
                    case 7:
                        sa.HeapSortG();
                        break;
                    case 8:
                        sa.BitonicG();
                        break;
                    default:
                        break;
                }

                sa.DrawTab(Color.Green);

            }
            else // Error Selection
            {
                ErrorProvider.SetError(cmb_Sorting, "Selectionnez un algorithme!");
            }


        }

        private void cmb_Sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Sorting.SelectedIndex != -1)
                ErrorProvider.SetError(cmb_Sorting, "");
        }







        //*** FIN





    }
}
