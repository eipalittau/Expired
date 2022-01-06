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
        private MessageEventArgs(long aID, Enumerations.PriorityEnum aPriority, string aText, PositionData aPosition)
            => (ID, Priority, Position, Text) = (aID, aPriority, aPosition, aText);

        public MessageEventArgs(long aID, Enumerations.PriorityEnum aPriority)
            : this(aID, aPriority, Localisation.GetMessageText(aID), new PositionData(new StackTrace(true).GetFrame(3))) { }

        public MessageEventArgs(long aID, Enumerations.PriorityEnum aPriority, params string[] aArguments)
            : this(aID, aPriority, Localisation.GetMessageText(aID, aArguments), new PositionData(new StackTrace(true).GetFrame(3))) { }

        public MessageEventArgs(Exceptions.ExceptionBase aEx)
            : this(aEx.ID, aEx.Priority, aEx.Message, aEx.Position) { }

        public MessageEventArgs(System.Exception aEx)
            : this(-1, Enumerations.PriorityEnum.Critical, aEx.Message, new PositionData(new StackTrace(true).GetFrame(3))) { }
        #endregion
    }
}
