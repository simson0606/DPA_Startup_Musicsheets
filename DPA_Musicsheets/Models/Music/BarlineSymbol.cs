using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSAMControlLibrary;

namespace DPA_Musicsheets.Models.Music
{
    class BarlineSymbol:Symbol
    {
        public int RepeatGroup { get; set; }
        public RepeatSignType RepeatSignType { get; set; }


        public override MusicalSymbol GetMusicalSymbol()
        {
            throw new NotImplementedException();
        }
    }
}
