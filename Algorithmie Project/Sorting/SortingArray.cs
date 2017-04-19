using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Algorithmie_Project
{
    public class SortingArray
    {
        //*** Global
        public static readonly int CAN_W = 900;
        public static readonly int CAN_H = 600;

        public static readonly int MAX_LENGTH = 600;

        public static int displayType = 0;

        public static readonly Color[] heapColor = { ColorTranslator.FromHtml("#CC66FF"), 
                                                    ColorTranslator.FromHtml("#9966FF"),
                                                    ColorTranslator.FromHtml("#6666FF"),
                                                    ColorTranslator.FromHtml("#3366FF"),
                                                    ColorTranslator.FromHtml("#0066FF"),
                                                    ColorTranslator.FromHtml("#0099FF"),
                                                    ColorTranslator.FromHtml("#00CCFF"),
                                                    ColorTranslator.FromHtml("#33CCCC"),
                                                    ColorTranslator.FromHtml("#00FFCC"),
                                                    ColorTranslator.FromHtml("#00FF99")  }; // l = 10

        //*** Tab Data
        public int[] tab;
        public int length;
        public bool isSorted = false;
        
        //*** Painting Tools        

        public float wSpace;
        public float hLength;
        
        // ===== Constructor ===== // 

        /// <summary>
        /// Default : 1-100
        /// </summary>
        public SortingArray()
        {
            length = 100;
            tab = new int[100];


            for (int i = 0; i < 100; i++)
                tab[i] = i + 1;

            Randomize();

            wSpace = 1;
            hLength = CAN_H/100;

        }

        /// <summary>
        /// tab[len] : 1 - len
        /// </summary>
        /// <param name="len"> nombre de valeur</param>
        public SortingArray(int len)
        {
            length = len;
            tab = new int[len];

            for (int i = 0; i < len; i++)
                    tab[i] = i + 1;

            Randomize();

            if (len < 900)
            {
                wSpace = CAN_W / len;
                hLength = CAN_H / len;
            }
            else
            {
                wSpace = 1;
                hLength = 2 / 3;
            }
        }

        /// <summary>
        /// tab[len] avec des valeurs aléatoire de values[]
        /// </summary>
        /// <param name="len">nombre de valeur</param>
        /// <param name="values">valeurs possible</param>
        public SortingArray(int len , int[] values)
        {
            length = len;
            tab = new int[len];

            Random rand = new Random();

            for (int i = 0; i < len; i++)
                tab[i] =  values[ rand.Next(0, values.Length) ];

            int max = values[0];

            for (int j = 1; j < values.Length; j++)
                max = (max < values[j]) ? values[j] : max;

            wSpace = CAN_W / len;
            hLength = CAN_H / max;

        }
        
        /// <summary>
        /// tableau constant
        /// </summary>
        /// <param name="values"> tableau des valeurs du tab</param>
        public SortingArray(int[] values)
        {
            tab = values;
            length = tab.Length;


            int max = values[0];

            for (int j = 1; j < values.Length; j++)
                max = (max < values[j]) ? values[j] : max;

            wSpace = CAN_W / length;
            hLength = CAN_H / max;
        }
        
        // ===== Function ===== //

        /// <summary>
        /// Inverse 2 valeurs
        /// </summary>
        /// <param name="i1">v1</param>
        /// <param name="i2">v2</param>
        public void Swap(int i1 , int i2)
        {
            int buf = tab[i1];
            tab[i1] = tab[i2];
            tab[i2] = buf;
        }
        
        /// <summary>
        /// Insert tab[index] à la position pos
        /// </summary>
        /// <param name="index"></param>
        /// <param name="pos"></param>
        public void Insert(int index , int pos)
        {
            int buf1;
            int buf2 = tab[index];

            for(int i = pos; i<index; i++)
            {
                buf1 = tab[i];
                tab[i] = buf2;
                buf2 = buf1;
            }

            tab[index] = buf2;
        }

        /// <summary>
        /// Mélange un tableau 
        /// </summary>
        public void Randomize()
        {
            Random rand = new Random();
            int index, index2;
            int max = 2 * length;

            for (int i = 0; i < max; i++)
            {
                index = rand.Next(0, length);
                index2 = rand.Next(0, length);

                if (index != index2)
                {
                    Swap(index, index2);
                }

            }

            isSorted = false;
        }

        /// <summary>
        /// Retourne le contenu du tableau 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            String s = "[";

            for (int i = 0; i < length - 1; i++)
                s += " " + tab[i].ToString() + ",";

            s += " " + tab[length - 1].ToString() + " ]";

            return s;
        }

        public void DrawColumn(int index, Color color)
        {
            Global.myPen.Color = Color.Black;

            float l = length;

            //Console.WriteLine(tab[index] * hLength);
            if(length < 900)
            {
                if (SortingArray.displayType != 2)
                {
                    Global.graph.FillRectangle(Brushes.Black, index * wSpace, 0, wSpace, CAN_H);

                    Global.graph.FillRectangle(new SolidBrush(color), index * wSpace, CAN_H - (tab[index] *  hLength), displayType == 0 ? wSpace : 1, tab[index] * hLength);
                
                }
                else
                {
                    Global.graph.FillRectangle(Brushes.Black , index * wSpace, 0, wSpace, CAN_H);
                
                    Global.graph.FillRectangle(new SolidBrush(color), index * wSpace, CAN_H - (tab[index] * hLength), wSpace, hLength);
                
                }
            }
            else
            {
                if (SortingArray.displayType != 2)
                {
                    Global.graph.FillRectangle(Brushes.Black, index , 0, wSpace, CAN_H);

                    Global.graph.FillRectangle(new SolidBrush(color), index , CAN_H - tab[index] * 2 / 3 , 1, tab[index] * 2 / 3);

                }
                else
                {
                    Global.graph.FillRectangle(Brushes.Black, index, 0, wSpace, CAN_H);

                    Global.graph.FillRectangle(new SolidBrush(color), index, CAN_H - tab[index] * 2 / 3 , 1, 1);

                }
            }

            for (int i = 0; i < 120000; i++) ;
               
        }

        public void DrawTab(Color color)
        {
            Global.form.refresh_canvas();
            
            for (int i = 0; i < tab.Length; i++)
            {
                DrawColumn(i, color);
                
            }
        }

        // ===== Sorting algorthme ===== //

        //*** Simple Sort
        
        public void InsertionSort()
        {
            if (isSorted)
                return;

            int index,pos;

            if (tab[1] < tab[0])
                Swap(0, 1);

            for(index = 2; index < length; index++)
                for (pos = index; index > 1 && tab[pos] < tab[pos - 1]; pos--)
                    Swap(pos, pos - 1);

            

            isSorted = true;
        }

        public void SelectionSort()
        {
            if (isSorted)
                return;

            int pos, finder, index;

            for (pos = 0; pos < length - 1; pos++)
            {
                index = pos;
                for (finder = pos + 1; finder < length; finder++)
                    if (tab[index] > tab[finder])
                        index = finder;

                Swap(pos,index);
            }

            isSorted = true;
        }

        public void BubbleSort()
        {
            if (isSorted)
                return;
            
            for(int max = length-1; max > 0; max--)
                for (int pos = 0; pos < max; pos++)
                    if (tab[pos] > tab[pos + 1])
                        Swap(pos, pos + 1);

            isSorted = true;
        }

        public void ShakerSort()
        {
            int max = length - 1;
            int min = 0;
            int pos;
            bool echange = true;

            while (echange)
            {
                echange = false;

                for (pos = 0; pos < max; pos++)
                    if (tab[pos] > tab[pos + 1])
                    {
                        Swap(pos, pos + 1);
                        echange = true;
                    }
                max--;

                for (pos = max; pos > min && echange; pos--)
                    if (tab[pos] < tab[pos - 1])
                        Swap(pos, pos - 1);

                min++;
            }

        }

        //*** Simple Sort with display

        public void InsertionSortG()
        {
            if (isSorted)
                return;

            int index, pos;

            DrawColumn(0, Color.Red);
            DrawColumn(1, Color.Red);

            if (tab[1] < tab[0])
                Swap(0, 1);

            DrawColumn(0, Color.White);
            DrawColumn(1, Color.White);

            for (index = 2; index < length; index++)
            {
                for (pos = index; pos > 0 && tab[pos] < tab[pos - 1]; pos--)
                {
                    if (pos + 1 < length)
                        DrawColumn(pos + 1, Color.White);
                    DrawColumn(pos, Color.Red);
                    DrawColumn(pos-1, Color.Red);

                    Swap(pos, pos - 1);
                }

                DrawColumn(pos+1, Color.White);
                DrawColumn(pos, Color.White);

            }


            isSorted = true;
        }

        public void SelectionSortG()
        {
            if (isSorted)
                return;

            int pos, finder, index;

            for (pos = 0; pos < length - 1; pos++)
            {
                index = pos;

                for (finder = pos + 1; finder < length; finder++)
                {
                    if (tab[index] > tab[finder])
                    {
                        index = finder;
                    }

                    DrawColumn(finder - 1, Color.White);
                    DrawColumn(finder, Color.Red);

                }

                DrawColumn(length - 1, Color.White);

                DrawColumn(pos, Color.Red);
                DrawColumn(index, Color.Red);

                Swap(pos, index);

                DrawColumn(pos, Color.White);
                DrawColumn(index, Color.White);
            }

            isSorted = true;
        }

        public void BubbleSortG()
        {
            if (isSorted)
                return;

            int max, pos;

            for (max = length - 1; max > 0; max--)
            {
                for (pos = 0; pos < max; pos++)
                {
                    if (pos - 1 >= 0)
                        DrawColumn(pos - 1, Color.White);
                    DrawColumn(pos, Color.Red);
                    DrawColumn(pos + 1, Color.Red);
                    
                    if (tab[pos] > tab[pos + 1])
                    {
                        Swap(pos, pos + 1);
                    }

                }

                DrawColumn(pos-1, Color.White);
                DrawColumn(pos, Color.White);
            }

            isSorted = true;
        }

        public void ShakerSortG()
        {
            int max = length - 1;
            int min = 0;
            int pos;
            bool echange = true;

            while (echange)
            {
                echange = false;

                for (pos = 0; pos < max; pos++)
                {
                    if (pos - 1 >= 0)
                        DrawColumn(pos - 1, Color.White);
                    DrawColumn(pos, Color.Red);
                    DrawColumn(pos + 1, Color.Red);

                    if (tab[pos] > tab[pos + 1])
                    {
                        Swap(pos, pos + 1);
                        echange = true;
                    }

                }

                DrawColumn(pos - 1, Color.White);
                DrawColumn(pos, Color.White);

                max--;

                for (pos = max; pos > min && echange; pos--)
                {
                    if (pos + 1 < length)
                        DrawColumn(pos + 1, Color.White);
                    DrawColumn(pos, Color.Red);
                    DrawColumn(pos - 1, Color.Red);

                    if (tab[pos] < tab[pos - 1])
                        Swap(pos, pos - 1);
                    
                }

                DrawColumn(pos +1 , Color.White);
                DrawColumn(pos, Color.White);

                min++;
            }

        }

        //*** Efficient Sort

            //--- Quick Sort
        public int partitionner(int first, int last, int pivot)
        {
            
            Swap(pivot, last);

            int j = first;
            int i;
            
            for(i = first;i<last;i++)
            {
                if(tab[i]<=tab[last])
                {
                    Swap(i, j);
                    j++;
                }
            }

            Swap(last, j);

            return j;
        }

        public void QuickSort(int first,int last)
        {
            if(first < last)
            {
                
                int pivot = new Random().Next(first, last+1);// last;
                pivot = partitionner(first, last, pivot);
                QuickSort(first, pivot-1);
                QuickSort(pivot + 1, last);

            }

        }
            //--- Fin QS

        public void HeapSort()
        {
            int n = tab.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end
                Swap(0, i);

                // call max heapify on the reduced heap
                heapify(i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is
        // an index in arr[]. n is size of heap
        void heapify(int n, int i)
        {
            int largest = i;  // Initialize largest as root
            int l = 2 * i + 1;  // left = 2*i + 1
            int r = 2 * i + 2;  // right = 2*i + 2

            // If left child is larger than root
            if (l < n && tab[l] > tab[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && tab[r] > tab[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = tab[i];
                tab[i] = tab[largest];
                tab[largest] = swap;

                // Recursively heapify the affected sub-tree
                heapify(n, largest);
            }
        }


        //--- Merge Sort

        public void MergeSort(int left, int right)
        {
            if (left < right)
            {
                // trouve le milieu
                int m = left + (right - left) / 2;

                // Tri la partie gauche et la partie droite
                MergeSort( left, m);
                MergeSort( m + 1, right);

                // regroupe
                Merge(left, m, right);
            }
        }

        public void Merge(int left, int mid ,int right)
        {
            int i, j, k;
            int n1 = mid - left + 1;
            int n2 = right - mid;

            /* create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];


            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
                L[i] = tab[left + i];
            for (j = 0; j < n2; j++)
                R[j] = tab[mid + 1 + j];

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray
            j = 0; // Initial index of second subarray
            k = left; // Initial index of merged subarray
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    tab[k] = L[i];
                    i++;
                }
                else
                {
                    tab[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there
               are any */
            while (i < n1)
            {
                tab[k] = L[i];
                i++;
                k++;
            }

            /* Copy the remaining elements of R[], if there
               are any */
            while (j < n2)
            {
                tab[k] = R[j];
                j++;
                k++;
            }



        }

        //--- Fin MS

        //--- Bitonic Sort    

        public void CompAndSwap(int i, int j, int dir)
        {
            /* The parameter dir indicates the sorting direction,
               ASCENDING or DESCENDING; if (a[i] > a[j]) agrees
               with the direction, then a[i] and a[j] are
               interchanged. */

            DrawColumn(i, Color.Red);
            DrawColumn(j, Color.Red);

            if ((tab[i] > tab[j] && dir == 1) ||
                 (tab[i] < tab[j] && dir == 0))
            {
                // Swapping elements
                Swap(i, j);
            }

            DrawColumn(i, Color.White);
            DrawColumn(j, Color.White);
        }

        public void BitonicMerge(int low, int cnt, int dir)
        {
            /* It recursively sorts a bitonic sequence in ascending
           order, if dir = 1, and in descending order otherwise
           (means dir=0). The sequence to be sorted starts at
           index position low, the parameter cnt is the number
           of elements to be sorted.*/

            if (cnt > 1)
            {
                int k = cnt / 2;
                for (int i = low; i < low + k; i++)
                    CompAndSwap(i, i + k, dir);
                BitonicMerge(low, k, dir);
                BitonicMerge(low + k, k, dir);
            }
        }

        public void BitonicSort(int low, int cnt, int dir)
        {
            /* This funcion first produces a bitonic sequence by
           recursively sorting its two halves in opposite sorting
           orders, and then  calls bitonicMerge to make them in
           the same order */
            if (cnt > 1)
            {
                int k = cnt / 2;

                // sort in ascending order since dir here is 1
                BitonicSortG(low, k, 1);

                // sort in descending order since dir here is 0
                BitonicSortG(low + k, k, 0);

                // Will merge wole sequence in ascending order
                // since dir=1.
                BitonicMergeG(low, cnt, dir);
            }
        }

        //--- Fin BS

        //*** Efficient Sort with display

        //--- Quick Sort
        public int partitionnerG(int first, int last, int pivot)
        {
            //DrawColumn(pivot, Color.Red);
            //DrawColumn(last, Color.Red);

            Swap(pivot, last);

            DrawColumn(pivot, Color.White);
            DrawColumn(last, Color.White);

            int j = first;
            int i;

            for (i = first; i < last; i++)
            {
                if (i - 1 >= 0)
                    DrawColumn(i-1, Color.White);
                DrawColumn(j, Color.Red);
                DrawColumn(i, Color.Red);

                if (tab[i] <= tab[last])
                {
                    Swap(i, j);
                    DrawColumn(j, Color.White);
                    j++;

                }
            }
            DrawColumn(i - 1, Color.White);

            //DrawColumn(j, Color.Red);
            //DrawColumn(last, Color.Red);

            Swap(last, j);

            DrawColumn(j, Color.White);
            DrawColumn(last, Color.White);



            return j;
        }

        public void QuickSortG(int first, int last)
        {
            if (first < last)
            {

                int pivot = new Random().Next(first, last + 1);// last;
                pivot = partitionnerG(first, last, pivot);
                DrawColumn(pivot, Color.Red);
                QuickSortG(first, pivot - 1);
                DrawColumn(pivot, Color.White);
                QuickSortG(pivot + 1, last);

            }

        }
        
        //--- Fin QS

        //--- Heap Sort

        public void HeapSortG()
        {
            int n = tab.Length;
            
            for (int i = n / 2 - 1; i >= 0; i--)
                heapifyG(n, i);

            DrawHeap();
            
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(0, i);
                DrawColumn(0, heapColor[0]);
                DrawColumn(i, Color.White);
                
                heapifyG(i, 0);
            }
            
        }

        public void DrawHeap()
        {
            Color up;

            for(int i = tab.Length - 1; i >= 0; i--)
            {
                if (i < 1)
                {
                    up = heapColor[0];
                }
                else if (i < 3)
                {
                    up = heapColor[1];
                }
                else if (i < 7)
                {
                    up = heapColor[2];
                }
                else if (i < 15)
                {
                    up = heapColor[3];
                }
                else if (i < 31)
                {
                    up = heapColor[4];
                }
                else if (i < 63)
                {
                    up = heapColor[5];
                }
                else if (i < 127)
                {
                    up = heapColor[6];
                }
                else if (i < 255)
                {
                    up = heapColor[7];
                }
                else
                {
                    up = heapColor[8];
                }

                DrawColumn(i, up);
            }
        }
        
        void heapifyG(int n, int i)
        {
            Color up;
            Color down;

            int largest = i;  // Initialize largest as root
            int l = 2 * i + 1;  // left = 2*i + 1
            int r = 2 * i + 2;  // right = 2*i + 2

            if (l < n && tab[l] > tab[largest])
                largest = l;

            if (r < n && tab[r] > tab[largest])
                largest = r;

            if (i< 1)
            {
                up = heapColor[0];
                down = heapColor[1];
            }
            else if (i < 3)
            {
                up = heapColor[1];
                down = heapColor[2];
            }
            else if (i < 7)
            {
                up = heapColor[2];
                down = heapColor[3];
            }
            else if (i < 15)
            {
                up = heapColor[3];
                down = heapColor[4];
            }
            else if (i < 31)
            {
                up = heapColor[4];
                down = heapColor[5];
            }
            else if (i < 63)
            {
                up = heapColor[5];
                down = heapColor[6];
            }
            else if (i < 127)
            {
                up = heapColor[6];
                down = heapColor[7];
            }
            else if (i < 255)
            {
                up = heapColor[7];
                down = heapColor[8];
            }
            else
            {
                up = heapColor[8];
                down = heapColor[9];
            }

            if (largest != i)
            {
                Swap(i, largest);
                DrawColumn(i, up);
                DrawColumn(largest, down);

                heapifyG(n, largest);
            }
        }

        //--- Fin HS

        //--- Merge Sort

        public void MergeSortG(int left, int right)
        {
            if (left < right)
            {
                // trouve le milieu
                int m = left + (right - left) / 2;

                // Tri la partie gauche et la partie droite
                MergeSortG(left, m);
                MergeSortG(m + 1, right);

                // regroupe
                MergeG(left, m, right);
            }
        }

        public void MergeG(int left, int mid, int right)
        {
            int i, j, k;
            int n1 = mid - left + 1;
            int n2 = right - mid;

            /* create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];


            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
            {
                L[i] = tab[left + i];
                if (i > 0)
                    DrawColumn(left + i -1, Color.White);
                DrawColumn(left + i, Color.Red);
            }

            DrawColumn(left + i - 1, Color.White);

            for (j = 0; j < n2; j++)
            {
                R[j] = tab[mid + 1 + j];
                if (j > 0)
                    DrawColumn(mid + j, Color.White);
                DrawColumn(mid + 1 + j, Color.Red);
            }

            DrawColumn(mid + j, Color.White);

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray
            j = 0; // Initial index of second subarray
            k = left; // Initial index of merged subarray
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    tab[k] = L[i];
                    i++;
                }
                else
                {
                    tab[k] = R[j];
                    j++;
                }

                if (k > 0)
                    DrawColumn(k - 1, Color.White);
                DrawColumn(k, Color.Red);
                k++;
            }

            /* Copy the remaining elements of L[], if there
               are any */
            while (i < n1)
            {
                tab[k] = L[i];

                if (k > 0)
                    DrawColumn(k - 1, Color.White);
                DrawColumn(k, Color.Red);

                i++;
                k++;
            }

            /* Copy the remaining elements of R[], if there
               are any */
            while (j < n2)
            {
                tab[k] = R[j];

                if (k > 0)
                    DrawColumn(k - 1, Color.White);
                DrawColumn(k, Color.Red);

                j++;
                k++;
            }

            DrawColumn(k - 1, Color.White);


        }

        //--- Fin MS

        //--- Bitonic Sort    

        public void BitonicG()
        {
            //BitonicSequenceG();

            BitonicSortG(0, length, 1);
        }

        public void BitonicSequenceG()
        {
            for (int i = 0,  j = tab.Length - 1; i < j; i++ , j--)
            {
                // left
                DrawColumn(i, Color.Red);
                DrawColumn(i+1, Color.Red);

                if (tab[i] > tab[i + 1])
                    Swap(i, i + 1);

                DrawColumn(i, Color.White);
                DrawColumn(i + 1, Color.White);

                // right
                DrawColumn(j, Color.Red);
                DrawColumn(j - 1 , Color.Red);

                if (tab[j] > tab[j - 1 ])
                    Swap(i, i + 1);

                DrawColumn(j, Color.White);
                DrawColumn(j - 1, Color.White);
            }
        }

        public void CompAndSwapG(int i, int j, int dir)
        {
            /* The parameter dir indicates the sorting direction,
               ASCENDING or DESCENDING; if (a[i] > a[j]) agrees
               with the direction, then a[i] and a[j] are
               interchanged. */

            DrawColumn(i, Color.Red);
            DrawColumn(j, Color.Red);

            if ( (tab[i] > tab[j] && dir == 1) ||
                 (tab[i] < tab[j] && dir == 0))
            {
                // Swapping elements
                Swap(i, j);
            }

            DrawColumn(i, Color.White);
            DrawColumn(j, Color.White);
        }

        public void BitonicMergeG(int low, int cnt, int dir)
        {
            /* It recursively sorts a bitonic sequence in ascending
           order, if dir = 1, and in descending order otherwise
           (means dir=0). The sequence to be sorted starts at
           index position low, the parameter cnt is the number
           of elements to be sorted.*/

            if (cnt > 1)
            {
                int k = greatestPowerOfTwoLessThan(cnt);
                for (int i = low; i < low + cnt - k; i++)
                    CompAndSwapG(i, i + k, dir);
                BitonicMergeG(low, k, dir);
                BitonicMergeG(low + k, cnt - k, dir);
            }
        }

        public void BitonicSortG(int low, int cnt, int dir)
        {
            /* This funcion first produces a bitonic sequence by
           recursively sorting its two halves in opposite sorting
           orders, and then  calls bitonicMerge to make them in
           the same order */
            if (cnt > 1)
            {
                int k = cnt / 2;

                // sort in ascending order since dir here is 1
                BitonicSortG(low, k, 0);

                // sort in descending order since dir here is 0
                BitonicSortG(low + k , cnt - k, 1);

                // Will merge wole sequence in ascending order
                // since dir=1.
                BitonicMergeG(low, cnt, dir);
            }
        }

        private int greatestPowerOfTwoLessThan(int n)
        {
            int k = 1;
            while (k > 0 && k < n)
                k = k << 1;
            return k >> 1;
        }

        //--- Fin BS

        //*** NO Comparison Sort

        public void RadixLsdSort()
        {
            int max = tab[0];
            int i, count;

            // init
            List<int>[] cups = new List<int>[10];
            cups[0] = new List<int>();
            cups[1] = new List<int>();
            cups[2] = new List<int>();
            cups[3] = new List<int>();
            cups[4] = new List<int>();
            cups[5] = new List<int>();
            cups[6] = new List<int>();
            cups[7] = new List<int>();
            cups[8] = new List<int>();
            cups[9] = new List<int>();


            // trouve le max
            for (i = 1; i < tab.Length; i++)
                if (tab[i] > max)
                    max = tab[i];
            
            // nombre de passage
            for(int rep = 1; max / rep > 0; rep *= 10)
            {
                for (i = 1; i < tab.Length; i++)
                    cups[(tab[i] / rep) % 10].Add(tab[i]);

                count = 0;

                for(i = 0; i < 10; i++)
                {
                    while( cups[i].Count > 0)
                    {
                        tab[count] = cups[i].First();
                        cups[i].RemoveAt(0);
                        count++;
                    }
                }
                
            }


        }

        //*
        public void RadixMsdSort()
        {

        }

        //*
        public void CountingSort()
        {

        }

        //*
        public void BucketSort()
        {

        }

        //*** NO Comparison Sort with display

        public void RadixLsdSortG()
        {
            int max = tab[0];
            int i, count;

            // init
            List<int>[] cups = new List<int>[10];
            cups[0] = new List<int>();
            cups[1] = new List<int>();
            cups[2] = new List<int>();
            cups[3] = new List<int>();
            cups[4] = new List<int>();
            cups[5] = new List<int>();
            cups[6] = new List<int>();
            cups[7] = new List<int>();
            cups[8] = new List<int>();
            cups[9] = new List<int>();


            // trouve le max
            for (i = 1; i < tab.Length; i++)
                if (tab[i] > max)
                    max = tab[i];

            // nombre de passage
            for (int rep = 1; max / rep > 0; rep *= 10)
            {
                for (i = 0; i < tab.Length; i++)
                {
                    cups[(tab[i] / rep) % 10].Add(tab[i]);
                    
                }

                count = 0;

                for (i = 0; i < 10; i++)
                {
                    while (cups[i].Count > 0)
                    {
                        tab[count] = cups[i].First();
                        cups[i].RemoveAt(0);
                        
                        if (count > 0)
                            DrawColumn(count - 1,Color.White);
                        DrawColumn(count, Color.Red);

                        count++;
                    }

                    
                }

                DrawColumn(length - 1, Color.White);

            }


        }

        public void RadixMsdSortG()
        {

        }

    }
}
