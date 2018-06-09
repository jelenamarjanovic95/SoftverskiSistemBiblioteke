using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Bibliotekar
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        [Browsable(false)]
        public string Lozinka { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
