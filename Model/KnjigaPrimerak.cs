using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class KnjigaPrimerak
    {
        private int primerakID;
        private bool raspoloziva;
        private Knjiga knjiga;

        public KnjigaPrimerak()
        {
            raspoloziva = true;
        }

        public int PrimerakID { get => primerakID; set => primerakID = value; }
        public bool Raspoloziva { get => raspoloziva; set => raspoloziva = value; }
        [Browsable(false)]
        public Knjiga Knjiga { get => knjiga; set => knjiga = value; }

        //TODO: Umesto true/false da pise raspoloziva ili zauzeta
        public override string ToString()
        {
            return $"{knjiga.Naziv}";
        }
    }
}
