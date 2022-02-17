using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EsercitazioneVerificaTisi
{
    class ElencoMaratone
    {
        public List<Maratona> InsiemeMaratone { get; set; }

        public ElencoMaratone()
        {
            InsiemeMaratone = new List<Maratona>();
        }

        public void Aggiungi(Maratona unaMaratona)
        {
            InsiemeMaratone.Add(unaMaratona);
        }

        public int TrasformaTempo(string tempo)
        {
            int varTemp = tempo.IndexOf("h");
            int varTempo = tempo.IndexOf("m");
            int ore = int.Parse(tempo.Substring(0, varTemp));
            int minuti = int.Parse(tempo.Substring(varTemp + 1, 2));
            return ore * 60 + varTemp + minuti + varTempo;
        }

        public void LeggiDaFile()
        {
            FileStream flussoDati = new FileStream("maratone.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader readerDati = new StreamReader(flussoDati);

            while(!readerDati.EndOfStream)
            {
                string riga = readerDati.ReadLine();
                string[] campi = riga.Split("%");

                Maratona unaMaratona = new Maratona();
                unaMaratona.Atleta = campi[0];
                unaMaratona.Squadra = campi[1];
                unaMaratona.tempo = TrasformaTempo(campi[2]);
                unaMaratona.Città = campi[3];

                Aggiungi(unaMaratona);
            }
        }

        public int CercaNomeCittà(string Atleta, string Città)
        {

        }
    }
}
