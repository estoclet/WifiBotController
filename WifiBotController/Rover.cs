using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
            TcpClient SocketClient = new TcpClient();
            NetworkStream Netstream;

            // Initialiser connexionOk à false
            connexionOK = false;

            // Initialiser les attributs adresseServeur et port avec les paramètres reçus
            adresseServeur = host;
            this.port = port;

            // Initialiser l’attribut commandeAEnvoyer à [0,0]
            commandeAEnvoyer = [ 0, 0 ];
        }

        public void connexion()
        {
            // Connexion
            try
            {
                socketClient.Connect(host, port);
                Netstream = SocketClient.GetStream();

            }
            catch (SocketException e)
            {
                string msgErreur = "Erreur à la connexion : " + e;
            }
        }

        public void deconnexion() { }

        public bool getConnexion() { return true; }

        public void setCommande(Byte[] commande) { }

        private void minuterie_Tick(object sender, EventArgs e) { }
    }
}
