using System.Collections.Generic;
using DPA_Musicsheets.Managers.SymbolBuilder;
using DPA_Musicsheets.Models.Music;

namespace DPA_Musicsheets.Managers
{
    public class LilyLoader : Loader
    {
        public override string Extension => ".ly";

        private LilySymbolBuilderFactory _builderFactory = new LilySymbolBuilderFactory();
        public override void LoadFile(string path)
        {

        }

        public override List<Symbol> GetSymbols()
        {
            throw new System.NotImplementedException();
        }
    }
}