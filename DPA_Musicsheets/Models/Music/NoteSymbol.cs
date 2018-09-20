using System.Collections.Generic;
using DPA_Musicsheets.Models.Music.Enum;
using PSAMControlLibrary;

namespace DPA_Musicsheets.Models.Music
{
    class NoteSymbol : Symbol
    {
        public string Step { get; set; }
        public int Modifier { get; set; }
        public int Dots { get; set; }
        public int Octave { get; set; }
        public SymbolDuration Duration { get; set; }
        public TieType TieType { get; set; }
        public StemDirection StemDirection { get; set; }

        public override MusicalSymbol GetMusicalSymbol()
        {
            return new Note(Step,
                            Modifier, 
                            Octave, 
                            (MusicalSymbolDuration)Duration,
                            (NoteStemDirection)StemDirection,
                            (NoteTieType)TieType, 
                            new List<NoteBeamType> {NoteBeamType.Single});
        }
    }
}
