using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AsiDrvClass;
using System.Diagnostics;

namespace Chaine_De_Tri
{
    class CCapteur
    {   
        private CAsi Asi= new CAsi();
        private int m_EtatCapteur;
        int m_BitCapteur;
        private byte m_AdresseEsclave;
         
        public CCapteur(byte esclave, int AdresseBinaireDuCapteur) //Récupère l'adresse de l'esclave et l'adresse binaire en "int"
        {
            m_AdresseEsclave = esclave;
            m_BitCapteur = AdresseBinaireDuCapteur;
        }

        //Capteur allumé
        public bool On()
        {
            //[0] = première ligne du tableau pour lire les adresses binaires
            m_EtatCapteur = Asi.Lecture(BitConverter.GetBytes(m_EtatCapteur), m_AdresseEsclave); //récupère la valeur binaire du capteur grâce au numéro de l'esclave
           // Debug.Print(Convert.ToString("Etat Capteur = " + m_EtatCapteur));
            m_EtatCapteur &= m_BitCapteur; //masque pour additionner les adresses binaires des capteurs
            return Convert.ToBoolean(m_EtatCapteur); //converti en booléen la valeur binaire
        }
    }
}
