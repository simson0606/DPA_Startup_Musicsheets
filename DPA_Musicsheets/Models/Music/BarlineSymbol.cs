using PSAMControlLibrary;
using RepeatSignType = DPA_Musicsheets.Models.Music.Enum.RepeatSignType;

namespace DPA_Musicsheets.Models.Music
{
    class BarlineSymbol:Symbol
    {
        public int RepeatGroup { get; set; }
        public RepeatSignType RepeatSignType { get; set; }


        public override MusicalSymbol GetMusicalSymbol()
        {
            return new Barline {RepeatSign = (PSAMControlLibrary.RepeatSignType)RepeatSignType};
        }
    }
}
