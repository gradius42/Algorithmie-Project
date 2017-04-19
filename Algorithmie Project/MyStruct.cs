using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmie_Project
{
    public class Matrice<T>
    {
        public int h;
        public int l;
        public T[] points;

        public Matrice(int l1 , int h1)
        {
            l = l1;
            h = h1;

            points = new T[l * h];

        }

        public void InitValue(T v)
        {
            for (int i = 0; i < h * l; i++)
                points[i] = v;
        }

        public T Get(int p)
        {
            return points[p];
        }

        public T Get(int x, int y)
        {
            return points[x * l + y];
        }

        public void Set(int p, T v)
        {
            points[p] = v;
        }

        public void Set(int x, int y, T v)
        {
            points[x * l + y] = v;
        }

        public int GetL()
        {
            return l;
        }

        public int GetH()
        {
            return h;
        }


    }
    
    public class Ens_Noeud
    {
        // coord
        public int x;
        public int y;

        // linked
        public Ens_Noeud previous = null;
        public Ens_Noeud next = null;

        public Ens_Noeud()
        {
            x = -1;
            y = -1;
        }

        public Ens_Noeud(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Ens
    {
        public int length = 0;

        public Ens_Noeud first = null;
        public Ens_Noeud last = null;

        public Ens()
        {

        }

        // complexité o(1)
        public bool EstVide()
        {
            return first == null;
        }

        // complexité o(1)
        public void Ajoute(int x, int y)
        {

            if (last == null)
            {
                first = new Ens_Noeud(x, y);
                last = first;
            }
            else
            {
                Ens_Noeud n = new Ens_Noeud(x, y);
                n.previous = last;
                last.next = n;
                last = n;

            }
            length++;

        }

        public void AjouteNoeud(ref Ens_Noeud n)
        {

            if (last == null)
            {
                first = n;
                last = first;
            }
            else
            {
                n.previous = last;
                last.next = n;
                last = n;
            }
            length++;

        }

        public void AjouteTrie(ref Ens_Noeud n, ref Matrice<int> heuristique)
        {

            if (first == null && last == null)
            {
                first = n;
                last = n;
                length++;
            }
            else
            {
                if (heuristique.Get(first.x, first.y) >= heuristique.Get( n.x, n.y))
                {
                    first.previous = n;
                    n.next = first;
                    first = n;
                    length++;
                }
                else if (heuristique.Get(last.x, last.y) <= heuristique.Get(n.x, n.y))
                {
                    last.next = n;
                    n.previous = last;
                    last = n;
                    length++;
                }
                else
                {
                    Ens_Noeud np = first.next;

                    while (np != last)
                    {
                        if ( heuristique.Get(n.x, n.y) <= heuristique.Get(np.x, np.y))
                        {
                            n.next = np;
                            n.previous = np.previous;
                            np.previous.next = n;
                            np.previous = n;
                            length++;
                            return;
                        }

                        np = np.next;

                    }

                }

            }

        }

        // complexité O(n)
        public int Find(int x, int y)
        {
            int index = 0;

            Ens_Noeud n = first;
            while (n.next != null)
            {
                if (n.x == x && n.y == y)
                {
                    return index;
                }
                n = n.next;
                index++;
            }
            return -1;
        }

        // complexité O(n/2)
        public Ens_Noeud FindIndex(int index)
        {

            if (index <= length / 2)
            {
                Ens_Noeud n = first;
                int i;
                for (i = 0; i < index && n.next != null; i++)
                {
                    n = n.next;
                }

                return n;
            }
            else
            {
                Ens_Noeud n = last;
                int i;
                for (i = length; i > index && n.previous != null; i--)
                {
                    n = n.previous;
                }

                return n;
            }
        }

        // complexité O(n/2)
        public Ens_Noeud FindSupprIndex(int index)
        {
            Ens_Noeud n = this.FindIndex(index);

            if (n.next == null && n.previous == null)
            {
                first = null;
                last = null;
                length = 0;
            }
            else if (n.next == null)
            {
                n.previous.next = null;
                last = n.previous;
                length--;
            }
            else if (n.previous == null)
            {
                n.next.previous = null;
                first = n.next;
                length--;
            }
            else
            {
                n.previous.next = n.next;
                n.next.previous = n.previous;
                length--;
            }

            return n;

        }

        // complexité O(n)
        public void Suppr(int x, int y)
        {

            Ens_Noeud n = first;
            while (n != null)
            {
                if (n.x == x && n.y == y)
                {

                    if (n.next == null && n.previous == null)
                    {
                        first = null;
                        last = null;
                        length = 0;
                    }
                    else if (n.next == null)
                    {
                        n.previous.next = null;
                        last = n.previous;
                    }
                    else if (n.previous == null)
                    {
                        n.next.previous = null;
                        first = n.next;
                    }
                    else
                    {
                        n.previous.next = n.next;
                        n.next.previous = n.previous;
                    }

                    //NoeudSuppr(n);
                    length--;
                    n = null;
                }
                else
                    n = n.next;
            }

        }


        public Ens_Noeud DepilePremier()
        {
            Ens_Noeud n = first;

            if (n.next != null)
            {
                n.next.previous = null;
                first = n.next;
            }
            else
            {
                first = null;
                last = null;
            }

            length--;
            return n;
        }

        public void SupprPremier()
        {
            Ens_Noeud n = first;

            if (n.next != null)
                n.next.previous = null;
            else
                last = null;

            first = n.next;
            n = null;
            length--;
        }

        public void SupprDernier()
        {
            Ens_Noeud n = last;

            if (n.previous != null)
                n.previous.next = null;

            last = n.previous;
            n = null;
            length--;
        }

        // complexité O(n)
        public bool EstDans(int x, int y)
        {
            return ( this.Find(x, y) != -1);
        }

        // complextité O(1)
        public int Taille()
        {
            return length;
        }

        // complexité O(n)
        public void Print()
        {

            Ens_Noeud n = first;
            Console.Write("{\n");
            while (n != null)
            {
                Console.Write("(%i,%i)", n.x, n.y);
                n = n.next;
            }
            Console.Write("}\n");
        }

        // complexité O(n/2)
        public Ens_Noeud Tirage()
        {
            /* tirage */
            int index = new Random().Next(0,length);
            return FindSupprIndex(index);
        }

        public Ens_Noeud TirageL()
        {
            return DepilePremier();
        }
        

    }

    public class HeapData
    {
        public int x, y, heuristique, cout;

        public HeapData(int x_, int y_ , int c_, int h_)
        {
            x = x_;
            y = y_;
            heuristique = h_;
            cout = c_;
        }
    } 

    public class Heap_lab
    {
        int size; // Size of the allocated memory (in number of items)
        int count; // Count of the elements in the heap
        HeapData[] data; // Array with the elements

        public Heap_lab(int s)
        {
            size = s;
            count = 0;
            data = new HeapData[s];

            for (int i = 0; i < s; i++)
                data[i] = new HeapData(-1, -1, Int32.MaxValue, 0);

        }

        public void Push(HeapData value)
        {
            int index = count;
            data[index] = value;

            int parentIndex = (index - 1) / 2;
            
            while (parentIndex >= 0)
            {
                HeapData parent = data[parentIndex];
                if (value.heuristique < parent.heuristique)  
                {
                    data[index] = parent;
                    data[parentIndex] = value;
                    index = parentIndex;
                }
                else
                {
                    break;
                }

                parentIndex = (index - 1) / 2;
            }

            count++;
            
        }

        public HeapData Pop()
        {
            HeapData firstItem = data[0];
            count--;
            
            data[0] = data[count];

            int index = 0;
            bool fini = false;

            while (!fini)
            {
                int childIndexLeft = index * 2 + 1;
                int childIndexRight = index * 2 + 2;
                int swapIndex = 0;

                if (childIndexLeft < count)
                {
                    swapIndex = childIndexLeft;

                    if (childIndexRight < count)
                    {
                        if (data[childIndexRight].heuristique < data[childIndexLeft].heuristique)
                        {
                            swapIndex = childIndexRight;
                        }
                    }

                    if (data[swapIndex].heuristique < data[index].heuristique)
                    {
                        HeapData parent = data[index];
                        HeapData swap = data[swapIndex];
                        data[index] = swap;
                        data[swapIndex] = parent;
                        index = swapIndex;
                    }
                    else
                        fini = true;

                }
                else
                    fini = true;

            }

            return firstItem;
        } 

        public bool EstVide()
        {
            return count == 0;
        }
    }

    public class MinHeap 
    {
        List<HeapData> elements;

        public bool EstVide()
        {
            return elements.Count == 0;
        }

        public MinHeap()
        {
            elements = new List<HeapData>();
        }

        public void Push(HeapData item) // Add
        {
            elements.Add(item);
            Heapify();
        }

        public void Delete(HeapData item)
        {
            int i = elements.IndexOf(item);
            int last = elements.Count - 1;

            elements[i] = elements[last];
            elements.RemoveAt(last);
            Heapify();
        }

        public HeapData Pop() // Min
        {
            if (elements.Count > 0)
            {
                HeapData item = elements[0];
                Delete(item);
                return item;
            }

            return null;
        }

        public void Heapify()
        {
            for (int i = elements.Count - 1; i > 0; i--)
            {
                int parentPosition = (i + 1) / 2 - 1;
                parentPosition = parentPosition >= 0 ? parentPosition : 0;

                if (elements[parentPosition].heuristique.CompareTo(elements[i].heuristique) > 0)
                {
                    // swap
                    HeapData tmp = elements[parentPosition];
                    elements[parentPosition] = elements[i];
                    elements[i] = tmp;
                }
            }
        }
    }

}
