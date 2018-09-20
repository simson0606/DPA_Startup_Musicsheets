using DPA_Musicsheets.Models.Music.Enum;
using PSAMControlLibrary;

namespace DPA_Musicsheets.Models.Music
{
    class RestSymbol : Symbol
    {
        //public int Tempo { get; set; }
        //public int Dots { get; set; }
        public SymbolDuration Duration { get; set; }

        public override MusicalSymbol GetMusicalSymbol()
        {
            return new Rest((MusicalSymbolDuration)Duration);
        }
    }
}
