using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Operacija
    {
        Login,
        VratiSveClanove,
        VratiSveKnjige,
        VratiSveAutore,
        SacuvajIzmeneKnjiga,
        DajPrimerakID,
        UbaciKnjigu,
        PretraziKnjige,
        NadjiKnjigu,
        ObrisiKnjigu,
        SacuvajIzmeneClan,
        UbaciClana,
        PretraziClanove,
        NadjiClana,
        ObrisiClana,
        Zaduzi,
        Razduzi,
        NadjiZaduzenje,
        Kraj
    }

    [Serializable]
    public class TransferKlasa
    {
        public Operacija Operacija { get; set; }
        public object TransferObjekat { get; set; }
        public bool Signal { get; set; }
    }

    
}
