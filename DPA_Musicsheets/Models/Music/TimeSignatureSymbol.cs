using PSAMControlLibrary;

namespace DPA_Musicsheets.Models.Music
{
    class TimeSignatureSymbol : Symbol
    {
        public int Beats { get; set; }
        public int BeatType { get; set; }
        public override MusicalSymbol GetMusicalSymbol()
        {
            return new TimeSignature(TimeSignatureType.Numbers, (uint)Beats, (uint)BeatType);
        }
    }
}
