using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using Windows.UI.Xaml;

namespace WifiBotController
{
    class Rover
    {
        private StreamSocket socketClient;
        private HostName serveur;
        private DataWriter writer;
        private DispatcherTimer minuterie;
        private Byte[] commandeAEnvoyer;
        private string adresseServeur;
        private string port;
        private string messInfo;
        private bool connexionOK;

        public Rover(string host, string port)
        {
            // Instancier SocketClient

            // Initialiser connexionOk à false

            // Initialiser les attributs adresseServeur et port avec les paramètres reçus

            // Initialiser l’attribut commandeAEnvoyer à [0,0]
        }

        public void connexion() { }

        public void deconnexion() { }

        public bool getConnexion() { return true; }

        public void setCommande(Byte[] commande) { }

        private void minuterie_Tick(object sender, EventArgs e) { }
    }
}
