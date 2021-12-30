using System.Diagnostics;
using System.Text;

namespace RtD.Exceptions {
    public abstract class ExceptionBase : System.Exception {
        #region Properties
        public long ID { get; set; }
        public DateTime Timestamp { get; set; }
        public Enumerations.PriorityEnum Priority { get; set; }
        public Components.PositionData Position { get; set; }
        #endregion

        #region Konstruktor
        private ExceptionBase(long aID, string aMessage)
            : base(aMessage) {
            ID = aID;
            Timestamp = DateTime.Now;
            Priority = Enumerations.PriorityEnum.Critical;
            Position = new Components.PositionData(new StackTrace(true).GetFrame(3));
        }

        public ExceptionBase(long aID)
            : this(aID, CreateMessage(aID)) { }

        public ExceptionBase(long aID, params string[] aArguments)
            : this(aID, CreateMessage(aID, aArguments)) { }

        public ExceptionBase(long aID, System.Exception aEx)
            : this(aID, CreateMessage(aID, aEx)) { }

        public ExceptionBase(long aID, System.Exception aEx, params string[] aArguments)
            : this(aID, CreateMessage(aID, aEx, aArguments)) { }
        #endregion


        #region Methoden
        private static string CreateMessage(long aID, params string[] aArguments) {
            return CreateMessage(aID, null, aArguments);
        }

        private static string CreateMessage(long aID, System.Exception? aEx, params string[] aArguments) {
            StringBuilder lMessage = new();
            string lMessagePart;

            if (aID <= 0) {
                return string.Empty;
            }

            lMessagePart = Components.Localisation.GetMessageText(aID, aArguments);

            if (!string.IsNullOrWhiteSpace(lMessagePart)) {
                lMessage.AppendLine(Components.Localisation.GetMessageText(aID, aArguments));
            }

            if (aEx != null) {
                do {
                    lMessage.AppendLine(aEx.Message);
                    aEx = aEx.InnerException;
                } while (aEx != null);
            }

            return lMessage.ToString();
        }
        #endregion
    }
}