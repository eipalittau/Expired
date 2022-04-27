namespace Exp.Exception {
    public abstract class ExceptionBase : System.Exception {
        #region Properties / Felder
        public string ID { get; init; }
        public DateTime Occurrence { get; }
        public PriorityEnum Priority { get; init; }
        #endregion
        
        #region Konstruktor
        protected ExceptionBase(params string[] aArguments)
            : this(null, aArguments) { }

        protected ExceptionBase(System.Exception aEx, params string[] aArguments)
            : base(Exp.Localisation.GeText(aEx, GetMessageID(), aArguments)) {
            => (ID, Occurrence, Priority) = (GetMessageID(), DateTime.Now, PriorityEnum.Error);
        }
        #endregion
        
        #region Methoden
        private static string GetMessageID() {
            Type lType = typeof(ExeptionBase);
            
            return string.concat(lType.Namespace, ".", lType.Name);
        }
        #endregion
    }
}
