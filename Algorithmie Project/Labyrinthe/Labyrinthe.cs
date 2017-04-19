using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace Algorithmie_Project
{
    
    class Labyrinthe
    {

        // Génération
        public static bool v_graph = true;
        public static bool d_graph = false;
        public static bool lineaire = false;

        // Dijkstra 
        public static bool Dij = false;
        public static bool Dij_rech = false;

        // A*
        public static bool AStar = false;
        public static bool AStar_rech = false;

        // Execution automatique
        public static int Auto;

        // Affichage parameter
        public static int case_width;
        
        // Classe
        Matrice<int> map;

        // Constructeur

        public Labyrinthe(int w, int h, int r)
        {
            Ens v = new Ens(); // case vide (constructible)

            // init
            map = new Matrice<int>(w, h);

            map.InitValue(0);

            // Tour + Graine
            LabInit(map.l, map.h);

            Granularise(ref v, r);

            // Expention graine
            LabConstruit(ref v);

        }

        // Tests

        bool EstConstruit(int x, int y)
        {
            return map.Get(x, y) != 0;
        }

        bool EstConstructible(ref Ens v, Ens_Noeud point, bool init)
        {

            int x = point.x;
            int y = point.y;
            int w = map.GetL();
            int h = map.GetH();

            if (EstConstruit(x, y) || (!init && (x <= 1 || y <= 1 || x >= h - 2 || y >= w - 2)))
                return false;

            int res = 0;

            int[] adjcent = { 0, 0, 0, 0 }; // W , N , E , S <OK>
            int adj_count = 0;

            // Case Gauche
            if (EstConstruit(x, y - 1))
            {
                adjcent[0] = 1;
                adj_count++;
            }
            // Case En-Haut
            if (EstConstruit(x - 1, y))
            {
                adjcent[1] = 1;
                adj_count++;
            }
            // Case Droite
            if (EstConstruit(x, y + 1))
            {
                adjcent[2] = 1;
                adj_count++;
            }
            // Case En-Bas
            if (EstConstruit(x + 1, y))
            {
                adjcent[3] = 1;
                adj_count++;
            }

            if (adj_count == 0)
            {

                if (init)
                {

                    // Case Haut Gauche
                    if (EstConstruit(x - 1, y - 1))
                    {
                        res += 1;
                    }
                    // Case En-Haut Droite
                    if (EstConstruit(x - 1, y + 1))
                    {
                        res += 1;
                    }
                    // Case Bas Droite
                    if (EstConstruit(x + 1, y + 1))
                    {
                        res += 1;
                    }
                    // Case Bas Gauche
                    if (EstConstruit(x + 1, y - 1))
                    {
                        res += 1;
                    }

                    return !(res >= 1);

                }
            }
            else if (adj_count == 1)
            { // si il y a strictement un coté : Construit / Supprime

                //<OK>
                if (adjcent[0] == 1)
                { // Si a gauche
                    return (!EstConstruit(x - 1, y + 1) && !EstConstruit(x + 1, y + 1) );
                }
                else if (adjcent[1] == 1)
                { // Si en-haut
                    return (!EstConstruit(x + 1, y - 1) && !EstConstruit(x + 1, y + 1));
                }
                else if (adjcent[2] == 1)
                { // si a droite
                    return(!EstConstruit(x - 1, y - 1) && !EstConstruit(x + 1, y - 1));
                }
                else if (adjcent[3] == 1)
                { // si en bas
                    return (!EstConstruit(x - 1, y - 1) && !EstConstruit(x - 1, y + 1));
                }
            }
            else // plus d'un coté : Supprime
            {
                return false;
            }

            return false;
        }

        void verifTour(ref Ens v, Ens_Noeud point, bool init)
        {
            
            int x = point.x;
            int y = point.y;

            // Case Gauche
            if (!EstConstruit(x, y - 1))
            {
                Ens_Noeud g = new Ens_Noeud(x, y - 1);
                if (EstConstructible(ref v, g, init))
                {
                    v.Ajoute(x, y - 1);
                    if (d_graph)
                        SetPointGraphe(x, y - 1, Color.Red);
                }

                g = null;
            }
            // Case En-Haut
            if (!EstConstruit(x - 1, y))
            {
                Ens_Noeud h = new Ens_Noeud(x - 1, y);
                if (EstConstructible(ref v, h, init))
                {
                    v.Ajoute(x - 1, y);
                    if (d_graph)
                        SetPointGraphe(x - 1, y, Color.Red);
                }

                h = null;
            }
            // Case Droite
            if (!EstConstruit( x, y + 1))
            {
                Ens_Noeud d = new Ens_Noeud(x, y + 1);
                if (EstConstructible(ref v, d, init))
                {
                    v.Ajoute(x, y + 1);
                    if (d_graph)
                        SetPointGraphe(x, y + 1, Color.Red);
                }

                d = null;
            }
            // Case En-Bas
            if (!EstConstruit( x + 1, y))
            {
                Ens_Noeud b = new Ens_Noeud(x + 1, y);
                if (EstConstructible(ref v, b, init))
                {

                    v.Ajoute(x + 1, y);
                    if (d_graph)
                        SetPointGraphe(x + 1, y, Color.Red);
                }

                b = null;
            }

            point = null;
        }


        // Init matice
        void LabInit(int w, int h)
        {

            int i;

            for (i = 0; i < w; i++)
            {
                map.Set(0, i, 1);

                if (v_graph)
                    SetPointGraphe(0, i, Color.Black);
            }

            for (i = 1; i < h - 1; i++)
            {
                map.Set(i, w - 1, 1);

                if (v_graph)
                    SetPointGraphe(i, w - 1, Color.Black);
            }


            for (i = w - 1; i >= 0; i--)
            {
                map.Set(h - 1, i, 1);

                if (v_graph)
                    SetPointGraphe(h - 1, i, Color.Black);
            }

            for (i = h - 2; i > 0; i--)
            {
                map.Set(i, 0, 1);

                if (v_graph)
                    SetPointGraphe(i, 0, Color.Black);
            }

        }

        void Granularise(ref Ens v, int nb)
        {

            int h = map.h;
            int l = map.l;


            Random rand = new Random();

            int gg = rand.Next((h - 10))+5;
            int gh = rand.Next((l - 10))+5;
            int gd = rand.Next((h - 10))+5;
            int gb = rand.Next((l - 10))+5;

            // Noeud gauche

            map.Set(gg, 1, 1);

            if (v_graph)
                SetPointGraphe(gg, 1, Color.Black);

            verifTour(ref v, new Ens_Noeud(gg, 1), true);

            // Noeud haut

            map.Set(1, gh, 1);

            if (v_graph)
                SetPointGraphe(1, gh, Color.Black);

            verifTour(ref v, new Ens_Noeud(1, gh), true);

            // Noeud droite

            map.Set(gd, l - 2, 1);

            if (v_graph)
                SetPointGraphe(gd, l - 2, Color.Black);

            verifTour(ref v, new Ens_Noeud(gd, l - 2), true);

            // Noeud bas

            map.Set(h - 2, gb, 1);

            if (v_graph)
                SetPointGraphe(h - 2, gb, Color.Black);

            verifTour(ref v, new Ens_Noeud(h - 2, gb), true);

            nb -= 4;

            int count = 0;
            
            while (count < nb)
            {

                Ens_Noeud tirage = new Ens_Noeud(rand.Next((h - 2) + 1), rand.Next((l - 2) + 1));
                
                if (EstConstructible(ref v, tirage, true))
                {

                    map.Set(tirage.x, tirage.y, 1);

                    if (v_graph)
                        SetPointGraphe(tirage.x, tirage.y, Color.Black);

                    verifTour(ref v, tirage, true);
                    count++;

                }
                else if (d_graph && !EstConstruit(tirage.x, tirage.y))
                {
                    SetPointGraphe(tirage.x, tirage.y, Color.Black);
                }
            }
        }

        // construit
        void LabConstruit(ref Ens v)
        {

            while (!v.EstVide())
            {
                Ens_Noeud tirage = (lineaire)? v.TirageL() : v.Tirage();

                if (EstConstructible(ref v, tirage, false))
                {
                    map.Set(tirage.x, tirage.y, 1);
                    if (v_graph)
                        SetPointGraphe(tirage.x, tirage.y, Color.Black);
                    verifTour(ref v, tirage, false);
                }
                else if (d_graph && !EstConstruit(tirage.x, tirage.y))
                {
                    SetPointGraphe(tirage.x, tirage.y, Color.White);
                    tirage = null;
                }
                else
                    tirage = null;

            }

        }

        void LabPrint()
        {

            int w = map.GetL();
            int h = map.GetH();

            int i, j;
            for (i = 0; i < w; i++)
            {
                Console.Write("%i\t: ", i);
                for (j = 0; j < h; j++)
                {
                    char c = EstConstruit(i, j) ? '0' : ' ';

                    Console.Write("%c ", c);
                }
                Console.Write("\n");
            }
        }

        void SetPointGraphe(int x, int y, Color color)
        {
            Global.graph.FillRectangle(new SolidBrush(color) ,y*case_width,x*case_width,case_width,case_width);
            for (int i = 0; i < 50000; i++) ;
        }

        public void lanceRecherche()
        {

            if (Dij)
                Thread.Sleep(Auto);

            if (Dij)
                dijkstra();

            if (v_graph && AStar)
                Thread.Sleep(Auto);

            if (AStar)
                A_Star();
            
        }

        // Recherche

        void dijkstra()
        {
            Matrice<int> dist = new Matrice<int>(map.l, map.h);
            Matrice<int> isSet = new Matrice<int>(map.l, map.h);

            // Ensemble donnant le sommet avec la distance la plus petite en premiere position
            Ens plusPetit = new Ens();

            int V = map.l * map.h;

            int i;
            for (i = 0; i < V; i++)
                dist.Set(i, Int32.MaxValue);

            dist.Set(1, 1, 0);
            if (Dij_rech)
                SetPointGraphe(1, 1, Color.Green);
            plusPetit.Ajoute(1, 1);

            int l = map.l;
            int h = map.h;



            while (!plusPetit.EstVide() && dist.Get(h - 2, l - 2) == Int32.MaxValue)
            {

                Ens_Noeud n = plusPetit.DepilePremier();

                int u = n.x * l + n.y;
                int min = dist.Get(u);

                n = null;

                isSet.Set(u, 1);

                if (isSet.Get(u + 1) == 0 && map.Get(u + 1) == 0
                                            && map.Get(u) + 1 < dist.Get(u + 1))
                {
                    dist.Set(u + 1, dist.Get(u) + 1);
                    plusPetit.Ajoute((int)(u + 1) / l, (u + 1) % l);
                    if (Dij_rech)
                        SetPointGraphe((int)(u + 1) / l, (u + 1) % l, Color.Green);
                }

                if (isSet.Get(u - 1) == 0 && map.Get(u - 1) == 0
                                            && dist.Get(u) + 1 < dist.Get(u - 1))
                {
                    dist.Set(u - 1, dist.Get(u) + 1);
                    plusPetit.Ajoute((int)(u - 1) / l, (u - 1) % l);
                    if (Dij_rech)
                        SetPointGraphe((int)(u - 1) / l, (int)(u - 1) % l, Color.Green);
                }

                if (isSet.Get(u + l) == 0 && map.Get(u + l) == 0
                                            && dist.Get(u) + 1 < dist.Get(u + l))
                {
                    dist.Set(u + l, dist.Get(u) + 1);
                    plusPetit.Ajoute((int)(u + l) / l, (u + l) % l);
                    if (Dij_rech)
                        SetPointGraphe((int)(u + l) / l, (int)(u + l) % l, Color.Green);
                }


                if (isSet.Get(u - l) == 0 && map.Get(u - l) == 0
                                            && dist.Get(u) + 1 < dist.Get(u - l))
                {
                    dist.Set(u - l, dist.Get(u) + 1);
                    plusPetit.Ajoute((int)(u - l) / l, (u - l) % l);
                    if (Dij_rech)
                        SetPointGraphe((int)(u - l) / l, (int)(u - l) % l, Color.Green);
                }


            }

            // print
            int d = dist.Get(h - 2, l - 2);
            Console.WriteLine("\nDijsktra\n longueur du chemin : " + d);
            int p = (h - 2) * l + l - 2;
            //if (v_graph)
                while (d >= 0)
                {

                    SetPointGraphe((int)(p - l) / l + 1, (int)(p - l) % l, Color.Red);

                    if (d == 0)
                    {
                        // fin
                    }
                    else if (dist.Get(p - 1) == d - 1)
                    {
                        p = p - 1;
                    }
                    else if (dist.Get(p - l) == d - 1)
                    {
                        p = p - l;
                    }
                    else if (dist.Get(p + 1) == d - 1)
                    {
                        p = p + 1;
                    }
                    else if (dist.Get(p + l) == d - 1)
                    {
                        p = p + l;
                    }
                    else if (dist.Get(p) == Int32.MaxValue)
                    {
                        Console.WriteLine("Il n'y a pas de chemin vers la sortie");
                        d = 0;
                    }
                    else
                    {
                        Console.WriteLine("Erreur\n");
                        d = 0;
                    }
                    d--;
                }
            
            dist = null;
            isSet = null;
            plusPetit = null;
            
        }

        void A_Star()
        {

            int l = map.l;
            int h = map.h;

            Heap_lab openList = new Heap_lab(h * l);
            Matrice<int> estMarque = new Matrice<int>(l, h);
            Matrice<int> closedList = new Matrice<int>(l, h);
            estMarque.InitValue(0);
            closedList.InitValue(0);


            openList.Push( new HeapData(1, 1, 0, (h - 3) * (h - 3) + (l - 3) * (l - 3)));
            estMarque.Set(1, 1, 1);

            if (AStar_rech)
                SetPointGraphe(1, 1, Color.Aqua);

            while (!openList.EstVide() && closedList.Get(h - 2, l - 2) == 0)
            {
                HeapData u = openList.Pop();
                closedList.Set(u.x, u.y, u.cout);
               
                if (map.Get(u.x, u.y - 1) != 1 && estMarque.Get(u.x, u.y - 1) != 1 && closedList.Get(u.x,u.y - 1) < 1)
                {
                    HeapData v = new HeapData(u.x, u.y - 1, u.cout + 1, u.heuristique + 1);
                    estMarque.Set(v.x, v.y, 1);
                    openList.Push(v);
                    if (AStar_rech)
                         SetPointGraphe(v.x, v.y, Color.Aqua);
                    
                }

                if (map.Get(u.x - 1, u.y) != 1 && estMarque.Get(u.x - 1, u.y) != 1 && closedList.Get(u.x - 1, u.y) < 1)
                {
                    HeapData v = new HeapData(u.x - 1, u.y, u.cout + 1, u.heuristique + 1);
                    estMarque.Set(v.x, v.y, 1);
                    openList.Push(v);
                    if (AStar_rech)
                        SetPointGraphe(v.x, v.y, Color.Aqua);
                
                }

                if( map.Get(u.x, u.y + 1) != 1 && estMarque.Get(u.x, u.y + 1) != 1 && closedList.Get(u.x, u.y + 1) < 1)
                {
                    HeapData v = new HeapData(u.x, u.y + 1, u.cout + 1, u.heuristique - 1);
                    estMarque.Set(v.x, v.y, 1);
                    openList.Push(v);
                    if (AStar_rech)
                        SetPointGraphe(v.x, v.y, Color.Aqua);
                    
                }


                if (map.Get(u.x + 1, u.y) != 1 && estMarque.Get(u.x + 1, u.y) != 1 && closedList.Get(u.x + 1 , u.y) < 1)
                {
                        HeapData v = new HeapData(u.x + 1, u.y, u.cout + 1, u.heuristique - 1);
                        estMarque.Set(v.x, v.y, 1);
                        openList.Push(v);
                        if (AStar_rech)
                            SetPointGraphe(v.x, v.y, Color.Aqua);
                    
                }

                u = null;
                
            }

            // print
            int d = closedList.Get(h - 2, l - 2);
            Console.WriteLine("\nA*\n longueur du chemin: " + d);
            int p = (h - 2) * l + l - 2;

            while (d > 0)
            {
                SetPointGraphe((int)(p - l) / l + 1, (int)(p - l) % l, Color.Purple);

                if ((d - 1) == 0)
                {
                    SetPointGraphe(1, 1, Color.Aqua);
                    // fin
                }
                else if (closedList.Get(p - 1) == d - 1)
                {
                    p = p - 1;
                }
                else if (closedList.Get(p - l) == d - 1)
                {
                    p = p - l;
                }
                else if (closedList.Get(p + 1) == d - 1)
                {
                    p = p + 1;
                }
                else if (closedList.Get(p + l) == d - 1)
                {
                    p = p + l;
                }
                else if (closedList.Get(p) == 0)
                {
                    Console.Write("Il n'y a pas de chemin vers la sortie\n");
                    d = 0;
                }
                else
                {
                    Console.Write("Erreur\n");
                    d = 0;
                }
                d--;
            }

            estMarque = null;
            closedList = null;
            openList = null;

        }
    }
}
