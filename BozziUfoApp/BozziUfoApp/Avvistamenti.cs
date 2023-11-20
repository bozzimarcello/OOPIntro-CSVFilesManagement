using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BozziUfoApp
{
    class Avvistamenti
    {
        public List<Avvistamento> Elenco;
        public Avvistamenti()
        {
            Elenco = new List<Avvistamento>();
        }

        public int LeggiDati(string nomeFile)
        {
            Elenco.Clear();

            // aprire il file
            using (FileStream fileStream = new FileStream(nomeFile, FileMode.Open, FileAccess.Read))
            {

                using (StreamReader streamReader = new StreamReader(fileStream))
                {

                    // ciclo di lettura finché ci sono dati
                    while (streamReader.EndOfStream == false)
                    {
                        //      per ogni riga

                        //      leggere il testo dal file
                        string riga = streamReader.ReadLine();

                        //      creare un oggetto Avvistamento
                        //      copiare i singoli valori nei campi dell'oggetto
                        Avvistamento avvistamento = new Avvistamento(riga, ',');

                        //      aggiungere l'oggetto alla lista
                        Elenco.Add(avvistamento);
                    }
                }
            }

            return Elenco.Count;
        }
    }
}
