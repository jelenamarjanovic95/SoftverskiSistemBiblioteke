using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerPoslovneLogike
{
    class Repozitorijum
    {
        private static List<Bibliotekar> listaBibliotekara = new List<Bibliotekar>()
        {
            new Bibliotekar()
                {
                    Ime = "Jelena",
                    KorisnickoIme = "jeca",
                    Lozinka = "jeca",
                    Prezime = "Marjanovic"
                },
            new Bibliotekar()
            {
                Ime = "Pera",
                KorisnickoIme = "pera",
                Lozinka = "pera",
                Prezime = "Peric"
            }
        };

        public List<Bibliotekar> UlogovaniBibliotekari { get; set; }

        public static Bibliotekar NadjiBibliotekara(string korisnickoIme, string lozinka)
        {
            foreach (Bibliotekar b in ListaBibliotekara)
            {
                if (b.KorisnickoIme == korisnickoIme && b.Lozinka == lozinka)
                {
                    return b;
                }
            }
            return null;
        }

        public static List<Bibliotekar> ListaBibliotekara { get => listaBibliotekara; set => listaBibliotekara = value; }
    }
}
