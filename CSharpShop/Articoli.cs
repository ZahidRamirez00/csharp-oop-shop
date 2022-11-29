using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    internal class Articoli
    {
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private int iva;

        public int GetCodice()
        {
            return this.codice;
        }

        /*public void SetCodice(int Codice)
        {
            this.codice = Codice;
        }*/

        public string GetNome()
        {
            return this.nome;
        }
        
        public void SetNome(string Nome)
        {
            this.nome = Nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public void SetDescrizione(string Descrizione)
        {
            this.descrizione = Descrizione;
        }

        public float GetPrezzo()
        {
            return this.prezzo;
        }

        public void SetPrezzo(int Prezzo)
        {
            this.prezzo = Prezzo;
        }

        public int GetIva()
        {
            return this.iva;
        }

        public void SetIva(int Iva)
        {
            this.iva = Iva;
        }

        // Costuttore che definisco IO e che usa il concetto di OVERLOAD
        public Articoli(int Codice, string Nome, string Descrizione, float Prezzo, int Iva)
        {
            this.codice = Codice;
            this.nome = Nome;
            this.descrizione = Descrizione;
            this.prezzo = Prezzo;
            this.iva = Iva;
        }

        public float CalcoloPrezzoConIva(float prezzo, int iva)
        {
            float prezzoConIva = (prezzo * iva) / 100;
            prezzoConIva += prezzo;

            return prezzoConIva;
        }

    }
}
