namespace RtD.Components {
    public sealed class Notification {
        #region Properties / Felder
        public long ID { get; }
        public Enumerations.PriorityEnum Priority { get; }
        public string Message { get; }
        #endregion

        #region Konstruktor
        public Notification(Enumerations.PriorityEnum aPriority, long aID)
            => (Priority, ID, Message) = (aPriority, aID, Localisation.GetMessageText(aID));

        public Notification(Enumerations.PriorityEnum aPriority, long aID, params string[] aArguments)
                        => (Priority, ID, Message) = (aPriority, aID, Localisation.GetMessageText(aID, aArguments));
        #endregion
    }
}