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
            //instanciation du socket client
            socketClient = new StreamSocket();

            //instanciation du hostname necessaire à la connexion
            serveur = new HostName(host);

            // Initialiser connexionOk à false
            connexionOK = false;

            // Initialiser les attributs adresseServeur et port avec les paramètres reçus
            adresseServeur = host;
            this.port = port;

            // Initialiser l’attribut commandeAEnvoyer à [0,0]
            commandeAEnvoyer = new byte[2] { 0, 0 };
        }

        
    // async et await permettent de ne pas bloquer l'IHM en lançant la connexion
    // elle sera ici lancée en tache de fond
        public async void connexion()
        {
            // Connexion
            try
            {
                await socketClient.ConnectAsync(serveur, port);
                connexionOK = true;
                writer = new DataWriter(socketClient.OutputStream);
                //instanciation et paramètrage du timer
                minuterie = new DispatcherTimer();
                minuterie.Tick += Minuterie_Tick;
                minuterie.Interval = new TimeSpan(0, 0, 0, 0, 200);
                minuterie.Start();
            }

            catch (SocketException e)
            {
                messInfo = "Erreur à la connexion : " + e;
            }
        }

        private async void Minuterie_Tick(object sender, object e)
        {
                writer.WriteBytes(commandeAEnvoyer);
                await writer.StoreAsync();
        }

        public void deconnexion() {
            if(connexionOK==true)
            {
                writer.DetachStream();
                writer.Dispose();
                socketClient.Dispose();
                // on oublie pas d'arrêter le timer :
                minuterie.Stop();
            }
        }

        public bool getConnexion() { return connexionOK; }

        public void setCommande(Byte[] commande) { commandeAEnvoyer = commande; }
    }
}
