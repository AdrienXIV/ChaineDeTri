using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chaine_De_Tri
{
    class CCodeBarre
    {
        private short[] MousseCodeBarre = new short[] { 30, 39, 42, 45, 46, 47, 50, 52, 59, 61, 62, 63, 67, 68 };
        private short[] BoisCodeBarre = new short[] { 31, 33, 34, 35, 40, 44, 48, 51, 53, 54, 56, 57 };


        public short Lecture(int CodeBarre) //Lecture du code barre
        {
            int detection = CodeBarre;
            
            foreach (short val in MousseCodeBarre) //analyse toutes les cases du tableau
            {
                if (val == detection)
                {
                    Debug.Print(Convert.ToString(detection));
                    return 1; //Mousse = 1
                }
            }

            foreach (short valbis in BoisCodeBarre)
            {
                if(valbis == detection)
                {
                    Debug.Print(Convert.ToString(detection));
                    return 2; //Bois = 2
                }
            }

            return 123; //Aucun code barre = 0
        }
    }
}
