using System.Diagnostics;
using System.Text;

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
            : this(aID, aPriority, Localisation.GetMessageText(aID), new PositionData(new StackTrace(true).GetFrame(Constants.SkipFrames))) { }

        public MessageEventArgs(long aID, Enumerations.PriorityEnum aPriority, params string[] aArguments)
            : this(aID, aPriority, Localisation.GetMessageText(aID, aArguments), new PositionData(new StackTrace(true).GetFrame(Constants.SkipFrames))) { }

        public MessageEventArgs(Exceptions.ExceptionBase aEx)
            : this(aEx.ID, aEx.Priority, CreateMessage(aEx), aEx.Position) { }

        public MessageEventArgs(System.Exception aEx)
            : this(-1, Enumerations.PriorityEnum.Critical, CreateMessage(aEx), new PositionData(new StackTrace(true).GetFrame(Constants.SkipFrames))) { }

        public MessageEventArgs(System.Exception aEx, Enumerations.PriorityEnum aPriority)
            : this(-1, aPriority, CreateMessage(aEx), new PositionData(new StackTrace(true).GetFrame(Constants.SkipFrames))) { }
        #endregion

        #region Methoden
        private static string CreateMessage(System.Exception? aEx) {
            if (aEx == null) {
                return string.Empty;
            }

            StringBuilder lMessage = new();

            do {
                lMessage.AppendLine(aEx.Message);
                aEx = aEx.InnerException;
            } while (aEx != null);

            return lMessage.ToString();
        }
        #endregion

        private class Constants {
            internal const int SkipFrames = 3;
        }
    }
}