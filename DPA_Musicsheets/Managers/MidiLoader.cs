using System.Collections.Generic;
using DPA_Musicsheets.Managers.SymbolBuilder;
using DPA_Musicsheets.Managers.SymbolBuilder.Midi;
using DPA_Musicsheets.Models.Music;
using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets.Managers
{
    public class MidiLoader : Loader
    {
        public override string Extension => ".mid";
        private MidiSymbolBuilderFactory _builderFactory = new MidiSymbolBuilderFactory();
        private List<Symbol> _symbols = new List<Symbol>();

        public override void LoadFile(string path)
        {
            var sequence = new Sequence();
            sequence.Load(path);

            foreach (var track in sequence)
            {
                foreach (var midiEvent in track.Iterator())
                {

                    var builder = _builderFactory.GetBuilder(midiEvent);

                }
            }
        }

        public override List<Symbol> GetSymbols()
        {
            return null;
        }
    }
}