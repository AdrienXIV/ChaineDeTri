using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AsiDrvClass;
using Microsoft.VisualC;
using System.Diagnostics;

namespace Chaine_De_Tri
{
    class CAsi
    {
        private static AsiDrvClass.MAASi MAASi1;
        private byte[] ODI = { 0x00 }; //adresse binaire
        private byte[] IDI = { 0x00 }; //adresse binaire
        private short m_LogErreur = 0;

        //Constructeur
        public CAsi()  //connexion
        {
            MAASi1 = new AsiDrvClass.MAASi();
            MAASi1.MAASiInit(""); //Initialise la DLL
            ODI[0] = 0; //les vérins sont éteints    
        }

        //envoyer des informations à la chaîne de tri pour ouvrir ou fermer les vérins
        //AdresseEsclave -> numéro de l'esclave 
        //ValeurBinaire -> conversion de "0000" en base 10

        public void Ecrire(byte AdresseEsclave, byte ValeurBinaire)
        {
            ODI[0] = ValeurBinaire; //ODI[0] (out) = première case du tableau qui correspond à la valeur binaire
            try
            {
                MAASi1.MAASiWriteODI(ODI, AdresseEsclave, 1); //envoie de la valeur binaire et l'adresse de l'esclave en écriture
            }
            catch
            {
                try
                {
                    MAASi1.MAASiWriteODI(ODI, AdresseEsclave, 1); //envoie de la valeur binaire et l'adresse de l'esclave en écriture
                }
                catch
                {

                }
            }
        }


        //envoyer des informations à la chaîne de tri pour lire
        //AdresseEsclave -> numéro de l'esclave 
        //LogErreur -> si y'a des erreurs
        public int Lecture(byte[] AdresseBinaireDuCapteur, byte AdresseEsclave)
        {
            try
            {
                MAASi1.MAASiReadIDI(out IDI, AdresseEsclave, 1, out m_LogErreur); //IDI -> IN
                //Debug.Print(Convert.ToString("IDI[0] = " + IDI[0]));
            }
            catch
            {
                try
                {
                    MAASi1.MAASiReadIDI(out IDI, AdresseEsclave, 1, out m_LogErreur); //IDI -> IN
                }
                catch
                {

                }

            }

            return Convert.ToInt32(IDI[0]);
        }

        public void stop()
        {
            MAASi1.MAASiExit();
        }
    }
}
