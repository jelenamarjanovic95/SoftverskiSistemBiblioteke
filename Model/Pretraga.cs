using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum KriterijumPretrage
    {
        ImePrezimeClan,
        ClanskiBroj,
        ImePrezimeAutor,
        BrojKnjige,
        NazivKnjige
    }
    [Serializable]
    public class Pretraga
    {
        public string Vrednost { get; set; }
        public KriterijumPretrage KriterijumPretrage { get; set; }
    }
}
