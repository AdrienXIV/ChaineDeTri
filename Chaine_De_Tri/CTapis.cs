using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chaine_De_Tri
{
    class CTapis
    {
        private CAsi Asi = new CAsi();
        private byte m_AdresseEsclave;


        public CTapis(byte AdresseEsclave)
        {
            m_AdresseEsclave = AdresseEsclave; 
        }

        public void On()
        {
            //Utilisation de la classe CAsi pour lancer le tapis
            Asi.Ecrire(m_AdresseEsclave, 15); //esclave 5, adresse binaire 1111
        }

        //Vérin qu'on veut éteindre
        public void Off()
        {
            //Utilisation de la classe CAsi pour arrêter le tapis
            Asi.Ecrire(m_AdresseEsclave, 14); //esclave 5, adresse binaire 1110
        }
    }
}
