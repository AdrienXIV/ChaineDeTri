using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AsiDrvClass;
using System.IO.Ports;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.IO.Pipes;
using System.IO;


//Adresse des esclaves
//public byte AdresseEsclaveVerin = 5;
//public byte AdresseEsclaveCapteur = 3;
//

//IDI ==> In, IDI[0] = première case du tableau qui correspond aux adresses binaires
//byte[] IDI = { 0x00 };
//

//ODI ==> Out, ODI[0] = première case du tableau qui correspond aux adresses binaires
//byte[] ODI = { 0x00 };
//

//AsiDrvClass.MAASi Asi;

namespace Chaine_De_Tri
{
    public partial class Chaine_De_Tri : Form
    {
        //Objet
        MAASi MAsi = new MAASi();
        CAsi Asi;
        CCodeBarre codebarreObjet;
        CVerin verin1, verin2, verin3; //création d'objet pour les différents vérins
        CCapteur capteur1, capteur2, capteur3, capteur4; //création d'objet pour les différents capteurs
        CTapis TapisMarche, TapisArret;

        //Thread
        Thread threadCapteur1, threadCapteur2, threadCapteur3, threadCapteur4, threadCodeVide, boulanger;

        //Liste
        List<int> Code = new List<int>(); //création d'une liste pour stocker les variables détectées par le lecteur Codebarre de la classe CCodeBarre (0, 1 ou 2)
        List<String> tableau = new List<String>();
        List<int> historiqueObjet = new List<int>(); //stocker les blocs dans une liste
        List<String> historiqueHeure = new List<String>(); //stocker l'heure du passage des blocs dans une liste

        //String
        private String str = "", heure = "";
        private String historique = "";

        //Short
        private short compteurVerin1 = 0, compteurVerin2 = 0, compteurVerin3 = 0; //envoyer les messages par le timer 
        private short connexion = 0; //ordre du bouton connexion, lancer, arrêter

        //Int
        private int CodeBarre; //variable qui récupère les nombres des codes barres

        //Bool
        private bool m_etatCapteur1, m_etatCapteur2, m_etatCapteur3, m_etatCapteur4;
        private bool arretthread = true; //arrêter les Threads 
        private bool capt2 = true; //pour éviter de lancer le thread du capteur 2 une nouvelle fois quand on appuie sur le boutton lancer


        public Chaine_De_Tri()
        {
            InitializeComponent();
            Asi = new CAsi();
            codebarreObjet = new CCodeBarre();

            verin1 = new CVerin(5, 1); //0001
            verin2 = new CVerin(5, 2); //0010
            verin3 = new CVerin(5, 4); //0011

            capteur1 = new CCapteur(3, 8); //1000
            capteur2 = new CCapteur(3, 1); //0001
            capteur3 = new CCapteur(3, 2); //0010
            capteur4 = new CCapteur(3, 4); //0100

            TapisMarche = new CTapis(4); //esclave 4
            TapisArret = new CTapis(4); //esclave 4

            //Initialisation des états des bouttons et boîtes de dialogue
            buttonArret.Enabled = false;

            buttonRecuperer.Enabled = false;

            buttonOnVerin1.Enabled = false;
            buttonOnVerin2.Enabled = false;
            buttonOnVerin3.Enabled = false;

            buttonOffVerin1.Enabled = false;
            buttonOffVerin2.Enabled = false;
            buttonOffVerin3.Enabled = false;

            buttonMarche.Enabled = false;

            textBoxEtatCapteur.Enabled = false;
            textBoxEtatChaineDeTri.Enabled = false;

            buttonTapisArret.Enabled = false;
            buttonTapisLancer.Enabled = false;

            textBoxDetection.Enabled = false;
            //
        }


        public void SetSerialPort(SerialPort p_serialPort)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBoxCapteurEtat_Enter(object sender, EventArgs e)
        {
        }

        //==================================================================================================================================================================
        //                                                                      BOUTON CONNEXION / QUITTER
        //==================================================================================================================================================================

        // Bouton connexion
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            verin1.Off();
            verin2.Off();
            verin3.Off();

            //Changement d'état des boutons et boîtes de dialogue
            buttonArret.Enabled = true;

            buttonOnVerin1.Enabled = true;
            buttonOnVerin2.Enabled = true;
            buttonOnVerin3.Enabled = true;

            buttonOffVerin1.Enabled = true;
            buttonOffVerin2.Enabled = true;
            buttonOffVerin3.Enabled = true;

            buttonMarche.Enabled = true;

            buttonConnexion.Enabled = false;

            textBoxEtatCapteur.Enabled = true;
            textBoxEtatChaineDeTri.Enabled = true;

            buttonTapisArret.Enabled = true;
            buttonTapisLancer.Enabled = true;

            textBoxDetection.Enabled = true;
            //

            textBoxEtatChaineDeTri.Text += "===========================================\r\n\r\n";
            textBoxEtatChaineDeTri.Text += "    Appuyer sur <Lancer> pour lancer le système\r\n\r\n";
            textBoxEtatChaineDeTri.Text += "    Appuyer sur <Arrêter> pour arrêter le tapis\r\n\r\n";
            textBoxEtatChaineDeTri.Text += "===========================================\r\n\r\n";

            timerEtat.Enabled = true; //lancement de l'horloge
            timerMessage.Enabled = true; //lancement de l'horloge
            serialPort1.Open(); //ouverture du port série en COM2

            connexion = 1;
            threadCapteur2 = new Thread(ThreadCapteur2);
            boulanger = new Thread(ThreadBoulanger);
            Thread.Sleep(1);

            threadCapteur2.Start();
            boulanger.Start();
            //threadCodeVide.Start();
        }

        // Bouton pour quitter l'application
        private void buttonArret_Click(object sender, EventArgs e)
        {
            TapisArret.Off();

            arretthread = false;
            textBoxEtatChaineDeTri.Text += "[Tapis] : Arrêt\r\n";
            capt2 = false;

            buttonMarche.Enabled = true;

            buttonRecuperer.Enabled = true;

            buttonOnVerin1.Enabled = true;
            buttonOnVerin2.Enabled = true;
            buttonOnVerin3.Enabled = true;

            buttonOffVerin1.Enabled = true;
            buttonOffVerin2.Enabled = true;
            buttonOffVerin3.Enabled = true;

            connexion = 2;
        }


        private void textBoxConnexion_TextChanged(object sender, EventArgs e)
        {
        }


        //==================================================================================================================================================================
        //                                                                      THREAD CAPTEURS
        //==================================================================================================================================================================


        //Thread pour enlever les incrémentations spontanées
        private void ThreadBoulanger()
        {
            int a = -1;
            int aback = -1;
            int b;

            while (true)
            {
                Thread.Sleep(1);
                aback = a;
                a = Code.Count;
                if (a != aback)
                {
                    Thread.Sleep(550);
                    b = Code.Count;
                    if (b > a)
                    {
                        Code.RemoveAt(a - 1);
                        historiqueHeure.RemoveAt(a - 1);
                        historiqueObjet.RemoveAt(a - 1);
                    }
                }
            }
        }

        // Thread Capteur 1
        private void ThreadCapteur1()
        {
            while (arretthread == true)

            {
                Thread.Sleep(2000);
                bool CompteurCapteur1 = false;
                if (m_etatCapteur1 == true && CompteurCapteur1 == false)
                {
                    verin1.On();
                    compteurVerin1 = 1;
                    CompteurCapteur1 = true;
                    Thread.Sleep(555);
                    if (CompteurCapteur1 == true)
                    {
                        verin1.Off();
                        compteurVerin1 = 2;
                        CompteurCapteur1 = false;
                        Thread.Sleep(555);
                    }
                }
                Thread.Sleep(1000);
            }
        }


        // Thread Capteur 2
        private void ThreadCapteur2()
        {
            while (arretthread == true)
            {
                if (m_etatCapteur2 == true)
                {
                    try
                    {
                        CodeBarre = codebarreObjet.Lecture(Convert.ToInt32(serialPort1.ReadLine())); //récupère la valeur du code barre dans un "int" pour l'envoyer dans la classe CCodeBarre, et utiliser la méthode Lecture()
                    }
                    catch
                    {
                    }

                    Debug.Print(Convert.ToString("Code Barre : " + CodeBarre));
                    Code.Add(CodeBarre); //ajoute la valeur récupérée par le lecteur Codebarre dans la liste "Code"
                    historiqueObjet.Add(CodeBarre);
                    historiqueHeure.Add(DateTime.Now.ToString("HH : mm : ss tt " + DateTime.Now.ToString("MM-dd-yyyy\r\n")));
                }
                Thread.Sleep(10);
            }
        }


        // Thread Capteur 3
        private void ThreadCapteur3()
        {
            while (arretthread == true)
            {

                if (Code.Count > 0)
                {
                    if (m_etatCapteur3 == true && Code[0] == 1)
                    {
                        Thread.Sleep(475);
                        verin2.On();
                        Code.RemoveAt(0);
                        compteurVerin2 = 1;

                        Thread.Sleep(150);
                        verin2.Off();
                        compteurVerin2 = 2;
                    }
                    Thread.Sleep(1);
                }
                Thread.Sleep(1);
            }

        }

        // Thread Capteur 4
        private void ThreadCapteur4()
        {
            while (arretthread == true)
            {
                if (Code.Count > 0)
                {
                    if (m_etatCapteur4 == true && Code[0] == 2)
                    {
                        Thread.Sleep(700);
                        verin3.On();
                        Code.RemoveAt(0);
                        compteurVerin3 = 1;

                        Thread.Sleep(150);

                        verin3.Off();
                        compteurVerin3 = 2;
                    }
                    Thread.Sleep(1);
                    if (m_etatCapteur4 == true && Code[0] == 0)
                    {
                        Thread.Sleep(1200);
                        Code.RemoveAt(0);
                    }
                }
                Thread.Sleep(1);
            }
        }


        //Thread pour détecter les blocs sans codebarres
        private void ThreadCodeVideDetection()
        {
            while (true)
            {
                if (m_etatCapteur2 == true)
                {
                    int a = Code.Count;
                    Thread.Sleep(700);
                    int b = Code.Count;
                    if (a == b)
                    {
                        Code.Add(0);
                        historiqueObjet.Add(0);
                        historiqueHeure.Add(DateTime.Now.ToString("HH : mm : ss tt " + DateTime.Now.ToString("MM-dd-yyyy\r\n")));
                    }
                    Thread.Sleep(1);
                }
            }
        }


        //==================================================================================================================================================================
        //                                                                      BOUTON RECUPERER HISTORIQUE
        //==================================================================================================================================================================

        private void buttonRecuperer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(historique, caption: "Historique", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

        }


        //==================================================================================================================================================================
        //                                                                      TIMER
        //==================================================================================================================================================================

        // Timer
        private void timerEtat_Tick(object sender, EventArgs e)
        {
            labelHeure.Text = DateTime.Now.ToString("HH:mm:ss tt");
            labelDate.Text = DateTime.Now.ToString("MM-dd-yyyy");
            textBoxEtatCapteur.Clear();

            if (capteur1.On() == true)
            {
                textBoxEtatCapteur.Text += "Capteur 1 : " + capteur1.On() + "\r\n";
                m_etatCapteur1 = true;
            }
            else
            {
                textBoxEtatCapteur.Text += "Capteur 1 : " + capteur1.On() + "\r\n";
                m_etatCapteur1 = false;
            }


            if (capteur2.On() == true)
            {
                textBoxEtatCapteur.Text += "Capteur 2 : " + capteur2.On() + "\r\n";
                m_etatCapteur2 = true;
            }
            else
            {
                textBoxEtatCapteur.Text += "Capteur 2 : " + capteur2.On() + "\r\n";
                m_etatCapteur2 = false;
            }


            if (capteur3.On() == true)
            {
                textBoxEtatCapteur.Text += "Capteur 3 : " + capteur3.On() + "\r\n";
                m_etatCapteur3 = true;
            }
            else
            {
                textBoxEtatCapteur.Text += "Capteur 3 : " + capteur3.On() + "\r\n";
                m_etatCapteur3 = false;
            }


            if (capteur4.On() == true)
            {
                textBoxEtatCapteur.Text += "Capteur 4 : " + capteur4.On() + "\r\n";
                m_etatCapteur4 = true;
            }
            else
            {
                textBoxEtatCapteur.Text += "Capteur 4 : " + capteur4.On() + "\r\n";
                m_etatCapteur4 = false;
            }
        }

        //Timer pour les messages
        private void timerMessage_Tick(object sender, EventArgs e)
        {
            if (compteurVerin1 == 1)
            {
                textBoxEtatChaineDeTri.Text += "[Vérin 1] : 1\r\n";
                compteurVerin1 = 0;
            }
            if (compteurVerin1 == 2)
            {
                textBoxEtatChaineDeTri.Text += "[Vérin 1] : 0\r\n";
                compteurVerin1 = 0;
            }

            if (compteurVerin2 == 1)
            {
                textBoxEtatChaineDeTri.Text += "[Vérin 2] : 1\r\n";
                compteurVerin2 = 0;
            }
            if (compteurVerin2 == 2)
            {
                textBoxEtatChaineDeTri.Text += "[Vérin 2] : 0\r\n";
                compteurVerin2 = 0;
            }

            if (compteurVerin3 == 1)
            {
                textBoxEtatChaineDeTri.Text += "[Vérin 3] : 1\r\n";
                compteurVerin3 = 0;
            }
            if (compteurVerin3 == 2)
            {
                textBoxEtatChaineDeTri.Text += "[Vérin 3] : 0\r\n";
                compteurVerin3 = 0;
            }

            //Stocke les valeurs 0,1,2 pour chaques types dans un tableau
            str = ""; //réinitialiser la variable pour éviter d'avoir trop d'affichage
            heure = "";
            try
            {
                foreach (var item in Code)
                {
                    if (item == 2)
                    {
                        heure = DateTime.Now.ToString("HH : mm : ss tt " + DateTime.Now.ToString("MM-dd-yyyy\r\n"));
                        str += "BOIS \r\n";
                    }
                    if (item == 1)
                    {
                        heure = DateTime.Now.ToString("HH : mm : ss tt " + DateTime.Now.ToString("MM-dd-yyyy\r\n"));
                        str += "POLYSTYRENE \r\n";
                    }
                    if (item == 0)
                    {
                        heure = DateTime.Now.ToString("HH : mm : ss tt " + DateTime.Now.ToString("MM-dd-yyyy\r\n"));
                        str += "SANS-CODEBARRE \r\n";
                    }

                    Debug.Print("Historique : " + historique);
                    Debug.Print("Heure : " + heure);
                }
            }
            catch { }

            textBoxDetection.Text = str; //afficher le bloc (bois, sans-codebarre, polystyrene) dans ma boîte de dialogue

            //stocker dans la variable "historique" l'historique des affichage avec l'heure
            //réinitialisation à 0 de "historique" et "str"
            historique = "";
            str = "";
            for (int i = 0; i < historiqueObjet.Count; i++)
            {
                int item = historiqueObjet[i];
                if (item == 2)
                {
                    str += "BOIS " + historiqueHeure[i] + "\r\n";
                }
                if (item == 1)
                {
                    str += "POLYSTYRENE " + historiqueHeure[i] + "\r\n";
                }
                if (item == 0)
                {
                    str += "SANS-CODEBARRE " + historiqueHeure[i] + "\r\n";
                }
            }
            historique = str;
        }


        //==================================================================================================================================================================
        //                                                                      BOUTON MARCHE / ARRET
        //==================================================================================================================================================================

        // Bouton Marche
        private void buttonMarche_Click(object sender, EventArgs e)
        {
            historiqueObjet.Clear();
            historiqueHeure.Clear();

            if (connexion == 1)
            {
                arretthread = true;
                TapisMarche.On();
                textBoxEtatChaineDeTri.Text += "[Tapis] : Marche\r\n";

                buttonRecuperer.Enabled = false;

                buttonOnVerin1.Enabled = false;
                buttonOnVerin2.Enabled = false;
                buttonOnVerin3.Enabled = false;

                buttonOffVerin1.Enabled = false;
                buttonOffVerin2.Enabled = false;
                buttonOffVerin3.Enabled = false;

                buttonMarche.Enabled = false;
            }
            if (connexion == 2)
            {
                arretthread = true;
                TapisMarche.On();
                textBoxEtatChaineDeTri.Text += "[Tapis] : Marche\r\n";

                buttonOnVerin1.Enabled = false;
                buttonOnVerin2.Enabled = false;
                buttonOnVerin3.Enabled = false;

                buttonOffVerin1.Enabled = false;
                buttonOffVerin2.Enabled = false;
                buttonOffVerin3.Enabled = false;

                Thread.Sleep(100);
                buttonMarche.Enabled = false;
            }

            threadCapteur1 = new Thread(ThreadCapteur1);
            threadCapteur3 = new Thread(ThreadCapteur3);
            threadCapteur4 = new Thread(ThreadCapteur4);
            threadCodeVide = new Thread(ThreadCodeVideDetection);

            threadCapteur1.Start();
            threadCapteur3.Start();
            threadCapteur4.Start();
            threadCodeVide.Start();
            if (capt2 == false)
            {
                threadCapteur2 = new Thread(ThreadCapteur2);
                boulanger = new Thread(ThreadBoulanger);
                threadCapteur2.Start();
                boulanger.Start();
            }
        }

        // Bouton Quitter
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            TapisArret.Off(); //arrête le tapis
            Asi.stop(); //arrête la DLL
            timerEtat.Stop(); //arrête l'horloge 
            timerMessage.Stop(); //arrête l'horloge 
            serialPort1.Close(); //arrête le port série
            Application.Exit(); // quitte l'application
            Process.GetCurrentProcess().Kill(); //force l'arrêt
        }


        //==================================================================================================================================================================
        //                                                                      BOITE DE DIALOGUE CHAINE DE TRI
        //==================================================================================================================================================================
        private void textBoxEtatChaineDeTri_TextChanged(object sender, EventArgs e)
        {
            textBoxEtatChaineDeTri.SelectionStart = textBoxEtatChaineDeTri.Text.Length;
            textBoxEtatChaineDeTri.ScrollToCaret();
        }

        //==================================================================================================================================================================
        //                                                                      BOITE DE DIALOGUE ETAT DES CAPTEURS
        //==================================================================================================================================================================
        private void textBoxEtatCapteur_TextChanged(object sender, EventArgs e)
        {
            textBoxEtatCapteur.SelectionStart = textBoxEtatCapteur.Text.Length;
            textBoxEtatCapteur.ScrollToCaret();
        }


        //==================================================================================================================================================================
        //                                                                      VERIN
        //==================================================================================================================================================================

        // Bouton allumer vérin 1
        private void buttonOnVerin1_Click(object sender, EventArgs e)
        {
            verin1.On();
            textBoxEtatChaineDeTri.Text += "[Vérin 1] : 1\r\n";
        }

        // Bouton éteindre vérin 1
        private void buttonOffVerin1_Click(object sender, EventArgs e)
        {
            verin1.Off();
            textBoxEtatChaineDeTri.Text += "[Vérin 1] : 0\r\n";
        }

        // Bouton éteindre vérin 2
        private void buttonOffVerin2_Click(object sender, EventArgs e)
        {
            verin2.Off();
            textBoxEtatChaineDeTri.Text += "[Vérin 2] : 0\r\n";
        }

        // Bouton allumer vérin 3
        private void buttonOnVerin3_Click(object sender, EventArgs e)
        {
            verin3.On();
            textBoxEtatChaineDeTri.Text += "[Vérin 3] : 1\r\n";
        }

        // Bouton éteindre vérin 3
        private void buttonOffVerin3_Click(object sender, EventArgs e)
        {
            verin3.Off();
            textBoxEtatChaineDeTri.Text += "[Vérin 3] : 0\r\n";
        }

        // Bouton allumer vérin 2
        private void buttonOnVerin2_Click(object sender, EventArgs e)
        {
            verin2.On();
            textBoxEtatChaineDeTri.Text += "[Vérin 2] : 1\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxDetection.SelectionStart = textBoxDetection.Text.Length;
            textBoxDetection.ScrollToCaret();
        }





        //==================================================================================================================================================================
        //                                                                      LABEL
        //==================================================================================================================================================================
        private void label6_Click(object sender, EventArgs e)
        {

        }


        //==================================================================================================================================================================
        //                                                                      TAPIS ESSAI UNITAIRE
        //==================================================================================================================================================================
        private void buttonTapisLancer_Click(object sender, EventArgs e)
        {
            TapisMarche.On();
            textBoxEtatChaineDeTri.Text += "[Tapis] : Marche \r\n";
        }

        private void buttonTapisArret_Click(object sender, EventArgs e)
        {
            TapisArret.Off();
            textBoxEtatChaineDeTri.Text += "[Tapis] : Arrêt \r\n";
        }
    }
}
