using System.Collections.Generic;
using System.IO;
using System.Text;
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
            StringBuilder sb = new StringBuilder();
            foreach (var line in File.ReadAllLines(path))
            {
                sb.AppendLine(line);
            }

            var lilly = sb.ToString();

            var stringList = lilly.Split(' ');





        }

        public override List<Symbol> GetSymbols()
        {
            throw new System.NotImplementedException();
        }
    }
}