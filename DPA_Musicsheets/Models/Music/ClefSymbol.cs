using PSAMControlLibrary;
using ClefType = DPA_Musicsheets.Models.Music.Enum.ClefType;

namespace DPA_Musicsheets.Models.Music
{
    class ClefSymbol : Symbol
    {
        //public int Pitch { get; set; }
        public int Line { get; set; }
        //public int Octave { get; set; }
        //public string Step { get; set; }
        public ClefType ClefType { get; set; }

        public override MusicalSymbol GetMusicalSymbol()
        {
            return new Clef((PSAMControlLibrary.ClefType)ClefType, Line);
        }
    }
}
