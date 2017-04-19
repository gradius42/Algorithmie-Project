using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Algorithmie_Project
{
    class Fractal_Tree
    {

        static int length = 150;

        public static void Fractal(float angle)
        {
            Global.graph.TranslateTransform(Global.P_Width / 2, Global.P_Height/2+length);
            Branch(length,angle,'d',0);
            Global.graph.ResetTransform();
        }


        public static void Draw(int x, int y, int x2, int y2)
        {
            Global.myPen.Color = Color.White;
            Global.myPen.Width = 1;

            Global.graph.DrawLine(Global.myPen, x, y, x2, y2);
        }

        // chaine

        public static void Branch2(int len,float angle)
        {
            Draw(0 , 0, 0, - len);
            Global.graph.TranslateTransform(0,-len);
            
            if (len > 1)
            {
                Global.graph.RotateTransform(angle);
                Branch2(2 * len / 3, angle);
                Global.graph.RotateTransform(-angle);
                Branch2(2 * len / 3, angle);

            }
        }

        // signe

        public static void Branch3(int len, float angle)
        {
            Draw(0, 0, 0, -len);
            Global.graph.TranslateTransform(0, -len);

            if (len > 1)
            {
                // droite
                Global.graph.RotateTransform(angle);
                Branch3(2 * len / 3, angle);

                // retour 
                Global.graph.RotateTransform(180);
                Global.graph.TranslateTransform(0, -len);

                // Gauche
                Global.graph.RotateTransform(-angle);
                Branch3(2 * len / 3, angle);

                // retour 
                Global.graph.RotateTransform(180);
                Global.graph.TranslateTransform(0, -len);

            }
        }

        // arbre

        public static void Branch4(int len, float angle, char cote)
        {
            Draw(0, 0, 0, -len);
            Global.graph.TranslateTransform(0, -len);

            if (len > 2)
            {
                // droite
                Global.graph.RotateTransform(angle);
                Branch4(2 * len / 3, angle, 'd');

                // Gauche
                Global.graph.RotateTransform(-angle);
                Branch4(2 * len / 3, angle, 'g');

            }
            // retour 
            Global.graph.TranslateTransform(0, len);
            if (cote == 'd')
                Global.graph.RotateTransform(-angle);
            else
                Global.graph.RotateTransform(angle);

        }

        public static void Branch5(int len, float angle, char cote , int h)
        {   if (h!=0)
                Draw(0, 0, 0, -len);
            Global.graph.TranslateTransform(0, -len);

            if (h < 10 && len > 1)
            {
                // droite
                Global.graph.RotateTransform(angle);
                Branch5(2 * len / 3, angle, 'd', h+1);

                // Gauche
                Global.graph.RotateTransform(-angle);
                Branch5(2 * len / 3, angle, 'g', h+1);

                if (h == 0 || h == 1 || h == 3)
                {
                    Global.graph.RotateTransform(180);

                    // droite
                    Global.graph.RotateTransform(angle);
                    Branch5(2 * len / 3, angle, 'd', h + 1);

                    // Gauche
                    Global.graph.RotateTransform(-angle);
                    Branch5(2 * len / 3, angle, 'g', h + 1);

                    Global.graph.RotateTransform(180);
                }

            }
            
            // retour 
            Global.graph.TranslateTransform(0, len);
            if (cote == 'd')
                Global.graph.RotateTransform(-angle);
            else
                Global.graph.RotateTransform(angle);

        }

        public static void Branch(int len, float angle, char cote, int h)
        {
            if (h > 3)
                Draw(0, 0, 0, -len);
            Global.graph.TranslateTransform(0, -len);

            if (h < 10 && len > 1)
            {
                // droite
                Global.graph.RotateTransform(angle);
                Branch(2 * len / 3, angle, 'd', h + 1);

                // Gauche
                Global.graph.RotateTransform(-angle);
                Branch(2 * len / 3, angle, 'g', h + 1);


                if (h == 0 )
                {
                    Global.graph.RotateTransform(180);


                    Global.graph.TranslateTransform(0, -len /3);

                    // droite
                    Global.graph.RotateTransform(angle);
                    Branch(2 * len / 3, angle, 'd', h + 1);

                    // Gauche
                    Global.graph.RotateTransform(-angle);
                    Branch(2 * len / 3, angle, 'g', h + 1);

                    Global.graph.RotateTransform(180);
                }
                /*if (h == 0 || h == 1 || h == 2)
                {
                    Global.graph.RotateTransform(180);

                    Branch(2 * len / 3, angle, 'd', h + 1);

                    Global.graph.RotateTransform(angle);

                    Global.graph.RotateTransform(180);
                }*/

            }



            // retour 
            Global.graph.TranslateTransform(0, len);
            if (cote == 'd')
                Global.graph.RotateTransform(-angle);
            else
                Global.graph.RotateTransform(angle);

        }

    }
}
