using System.Collections.Generic;
using DPA_Musicsheets.Models.Music;

namespace DPA_Musicsheets.Managers
{
    public abstract class Loader
    {
        public abstract string Extension { get; }

        public abstract void LoadFile(string path);

        public abstract List<Symbol> GetSymbols();

    }
}