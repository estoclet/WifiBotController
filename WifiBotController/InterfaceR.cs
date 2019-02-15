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

        public InterfaceR(string x, string y) {
            robyOneKenobi = new Rover("localhost", "1234");
        }

        public void Avancer()
        {
            robyOneKenobi.setCommande(new Byte[2] { 0x70, 0x70 });
        }

        public void reculer()
        {
            robyOneKenobi.setCommande(new Byte[2] { 0x30, 0x30 });
        }

        public void stopper()
        {
            robyOneKenobi.setCommande(new Byte[2] { 0x00, 0x00 });
        }

        public void tournerD()
        {
            robyOneKenobi.setCommande(new Byte[2] { 0x00, 0x70 });
        }

        public void tournerG()
        {
            robyOneKenobi.setCommande(new Byte[2] { 0x70, 0x00 });
        }

        public string getMessage() { return "message"; }

        public void messageVocal(string mess) { }

        public bool getConnexion() { return true; }
    }
}