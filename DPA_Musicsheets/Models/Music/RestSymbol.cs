﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSAMControlLibrary;
using MusicalSymbolDuration = DPA_Musicsheets.Models.Music.Enum.MusicalSymbolDuration;

namespace DPA_Musicsheets.Models.Music
{
    class RestSymbol : Symbol
    {
        public int Tempo { get; set; }
        public int Dots { get; set; }
        public MusicalSymbolDuration Duration { get; set; }

        public override MusicalSymbol GetMusicalSymbol()
        {
            throw new NotImplementedException();
        }
    }
}
