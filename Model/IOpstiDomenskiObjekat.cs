﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IOpstiDomenskiObjekat
    {
        string VratiImeTabele();
        string VratiKljucIUslov();
        string VratiVrednostiZaInsert();
        List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac);
    }
}
