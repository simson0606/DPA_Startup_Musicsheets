using System;
using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets.Managers.SymbolBuilder.Midi
{
    public class MidiMetaSymbolFactory
    {
        public static SymbolBuilder GetBuilder(MidiEvent midiEvent)
        {
            var metaMessage = midiEvent.MidiMessage as MetaMessage;
            switch (metaMessage?.MetaType)
            {
                case MetaType.TimeSignature:
                    return new TimeSignatureBuilder();
                case MetaType.Tempo:
                    //not supported
                    return null;
                case MetaType.EndOfTrack:
                    //if (previousNoteAbsoluteTicks > 0)
                    //{
                    //    // Finish the last notelength.
                    //    double percentageOfBar;
                    //    lilypondContent.Append(MidiToLilyHelper.GetLilypondNoteLength(previousNoteAbsoluteTicks, midiEvent.AbsoluteTicks, division, _beatNote, _beatsPerBar, out percentageOfBar));
                    //    lilypondContent.Append(" ");

                    //    percentageOfBarReached += percentageOfBar;
                    //    if (percentageOfBarReached >= 1)
                    //    {
                    //        lilypondContent.AppendLine("|");
                    //        percentageOfBar = percentageOfBar - 1;
                    //    }
                    //}
                    return null;
                default:
                    return null;
            }
        }
    }
}