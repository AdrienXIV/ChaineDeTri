using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AsiDrvClass;

namespace Chaine_De_Tri
{
    
    class CVerin
    {
        private CAsi Asi = new CAsi();
        private byte m_BitVerin;
        private byte m_AdresseEsclave;

        public CVerin(byte AdresseEsclave, byte AdresseBinaireDuVerin)
        {
            m_AdresseEsclave = AdresseEsclave;
            m_BitVerin = AdresseBinaireDuVerin;
        }

        //Vérin qu'on veut allumer
        public void On()
        {
            //[0] = première ligne du tableau pour lire les adresses binaires
            Asi.Ecrire(m_AdresseEsclave, m_BitVerin);
        }

        //Vérin qu'on veut éteindre
        public void Off()
        {
            //Utilisation de la classe CAsi pour fermer les vérins
            Asi.Ecrire(m_AdresseEsclave, 0); //esclave 5, adresse binaire 0000
        }
    }
}
