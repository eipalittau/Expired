namespace Exp.Core.EventArgs {
    public class OnLevelUpEventArgs {
        #region Properties / Felder
        public bool Successfull { get; init; }
        #endregion

        #region Konstruktor
        public OnLevelUpEventArgs(bool aSuccessfull)
            => Successfull = aSuccessfull;
        #endregion
    }
}