using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets.Managers.SymbolBuilder.Midi
{
    public class MidiSymbolBuilderFactory
    {
        public SymbolBuilder GetBuilder(MidiEvent midiEvent)
        {
            var midiMessage = midiEvent.MidiMessage;
            
            switch (midiMessage.MessageType)
            {
                case MessageType.Meta:
                    return MidiMetaSymbolFactory.GetBuilder(midiEvent);
                case MessageType.Channel:
                    return MidiChannelBuilderFactory.GetBuilder(midiEvent);
                default:
                    return null;
            }
        }
    }
}