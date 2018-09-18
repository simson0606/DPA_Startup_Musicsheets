using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_Musicsheets.Models.Music.Enum;
using PSAMControlLibrary;
using MusicalSymbolDuration = DPA_Musicsheets.Models.Music.Enum.MusicalSymbolDuration;

namespace DPA_Musicsheets.Models.Music
{
    class NoteSymbol : Symbol
    {
        public int Modifier { get; set; }
        
        public int Dots { get; set; }
        public int Octave { get; set; }
        public MusicalSymbolDuration Duration { get; set; }
        public TieType TieType { get; set; }
        public StemDirection StemDirection { get; set; }

        public override MusicalSymbol GetMusicalSymbol()
        {
            throw new NotImplementedException();
        }
    }
}
