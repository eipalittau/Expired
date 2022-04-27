namespace Exp.Exception {
    public abstract class ExceptionBase : System.Exception {
        #region Properties / Felder
        public string ID { get; init; }
        public DateTime Occurrence { get; }
        public PriorityEnum Priority { get; init; }
        #endregion
        
        #region Konstruktor
        protected ExceptionBase(string aMessageID, params string[] aArguments)
            : base(Exp.Localisation.GeText(aMessageID, aArguments)) {
            => (ID, Occurrence, Priority) = (aMessageID, DateTime.Now, PriorityEnum.Error);
        }

        protected ExceptionBase(System.Exception aEx)
            : base(Exp.Localisation.GeText(aEx)) {
            => (ID, Occurrence, Priority) = (aMessageID, DateTime.Now, PriorityEnum.Error);
        }

        protected ExceptionBase(System.Exception aEx, string aMessageID)
            : base(Exp.Localisation.GeText(aEx, aMessageID)) {
            => (ID, Occurrence, Priority) = (aMessageID, DateTime.Now, PriorityEnum.Error);
        }

        protected ExceptionBase(System.Exception aEx, string aMessageID, params string[] aArguments)
            : base(Exp.Localisation.GeText(aEx, aMessageID, aArguments)) {
            => (ID, Occurrence, Priority) = (aMessageID, DateTime.Now, PriorityEnum.Error);
        }
        #endregion
    }
}
