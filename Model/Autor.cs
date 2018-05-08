using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Autor
    {
        private int autorID;
        private string imePrezime;
        private int godinaRodjenja;
        private string biografija;

        [Browsable(false)]
        public int AutorID { get => autorID; set => autorID = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public int GodinaRodjenja { get => godinaRodjenja; set => godinaRodjenja = value; }
        [Browsable(false)]
        public string Biografija { get => biografija; set => biografija = value; }

        public override string ToString()
        {
            return imePrezime;
        }
    }
}
