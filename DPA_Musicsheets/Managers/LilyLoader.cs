using System.Collections.Generic;
using DPA_Musicsheets.Models.Music;
using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets.Managers
{
    public class LilyLoader : Loader
    {
        public override string Extension => ".ly";
        public override void LoadFile(string path)
        {

        }

        public override List<Symbol> GetSymbols()
        {
            throw new System.NotImplementedException();
        }
    }
}