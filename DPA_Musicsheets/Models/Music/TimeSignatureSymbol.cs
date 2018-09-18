using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSAMControlLibrary;

namespace DPA_Musicsheets.Models.Music
{
    class TimeSignatureSymbol : Symbol
    {
        public int Beats { get; set; }
        public int type { get; set; }
        public override MusicalSymbol GetMusicalSymbol()
        {
            throw new  NotImplementedException();
        }
    }
}
