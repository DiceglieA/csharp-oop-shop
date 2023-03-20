using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private float iva;
        public Prodotto(string nome, string descrizione, float prezzo, float iva)
        {
            this.codice = setCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }

        public void setDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }
        public string getDescrizione()
        {
            return descrizione;
        }

        public void setPrezzo(float prezzo)
        {
            this.prezzo = prezzo;
        }
        public float getPrezzo()
        {
            return prezzo;
        }

        public void setIva(float iva)
        {
            this.iva = iva;
        }
        public float getIva()
        {
            return iva;
        }
        private int setCodice()
        {
            Random random = new Random();
            return random.Next(10000);
        }
        private string completaCodice()
        {
            string result = "";

            result = codice.ToString();
            for (int i = 0; i < 8; i++)
            {
                if (result.Length < 8)
                    result = "0" + result;
            } 

            return result;
        }
        public int getCodice()
        {
            return codice;
        }

        override public string ToString()
        {
            return "Prodotto:\n" +
                    "Codice: " + completaCodice() + "\n" +
                    "Nome: '" + nome + "'\n" +
                    "Descrizione: '" + descrizione + "'\n" +
                    "Prezzo: " + prezzo + "\n" +
                    "Prezzo con Iva: " + prezzoIva() + "\n";
        }

        public float prezzoIva()
        {
            return prezzo + (prezzo * iva);
        }

        public string nomeEsteso()
        {
            return "Nome esteso:" + codice + " - " + nome + "\n";
        }

       
    }
}