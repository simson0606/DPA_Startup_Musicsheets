using System.Collections.Generic;
using DPA_Musicsheets.Models.Music;
using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets.Managers
{
    public class MidiLoader : Loader
    {
        public override string Extension => ".mid";
        public override void LoadFile(string path)
        {
            var sequence = new Sequence(path);
        }

        public override List<Symbol> GetSymbols()
        {
            return null;
        }
    }
}