using System.Diagnostics;

namespace RtD.Components.EventArgs {
    public sealed class MessageEventArgs {
        #region Properties / Felder
        public long ID { get; private set; }
        public Enumerations.PriorityEnum Priority { get; private set; }
        public string Text { get; private set; }
        public PositionData Position { get; private set; }
        #endregion

        #region Konstruktor
        public MessageEventArgs(long aID, Enumerations.PriorityEnum aPriority) {
            ID = aID;
            Priority = aPriority;
            Position = new PositionData(new StackTrace(true).GetFrame(3));
            Text = Localisation.GetMessageText(aID);
        }

        public MessageEventArgs(long aID, Enumerations.PriorityEnum aPriority, params string[] aArguments) {
            ID = aID;
            Priority = aPriority;
            Position = new PositionData(new StackTrace(true).GetFrame(3));
            Text = Localisation.GetMessageText(aID, aArguments);
        }
        #endregion
    }
}
