using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiBotController
{
    class InterfaceR
    {
        private Rover robyOneKenobi;
        private bool etatConnexion;
        private string messages;

        public InterfaceR(string x, string y) { }

        public void avancer() { }

        public void reculer() { }

        public void stopper() { }

        public void tournerD() { }

        public void tournerG() { }

        public string getMessage() { return "message"; }

        public void messageVocal(string mess) { }

        public bool getConnexion() { return true; }
    }
}