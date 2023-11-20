using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozziUfoApp
{
    class Avvistamento
    {
        public string ID { get; set; }
        public string Date_time { get; set; }
        public string date_documented { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Hour { get; set; }
        public string Season { get; set; }
        public string Country_Code { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Locale { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string UFO_shape { get; set; }
        public float length_of_encounter_seconds { get; set; }
        public string Encounter_Duration { get; set; }
        public string Description { get; set; }

        public Avvistamento(string riga, char separatore)
        {
            // NB salto le righe che potrebbero mandare in errore
            // la conversione
            // TODO gestire i campi di testo circondati da "
            if (riga.IndexOf('"') != -1) return;

            string[] valore = riga.Split(separatore);

            try
            {
                //      copiare i singoli valori nei campi dell'oggetto
                ID = valore[0];
                Date_time = valore[1];
                date_documented = valore[2];
                Year = int.Parse(valore[3]);
                Month = int.Parse(valore[4]);
                Hour = int.Parse(valore[5]);
                Season = valore[6];
                Country_Code = valore[7];
                Country = valore[8];
                Region = valore[9];
                Locale = valore[10];
                latitude = float.Parse(valore[11]);
                longitude = float.Parse(valore[12]);
                UFO_shape = valore[13];
                length_of_encounter_seconds = float.Parse(valore[14]);
                Encounter_Duration = valore[15];
                Description = valore[16];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + riga);
            }

        }
    }
}
