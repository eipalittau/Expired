namespace Exp.Core.EventArgs {
    public class AfterNewDayEventArgs {
        #region Properties / Felder
        public string Section { get; init; }
        #endregion

        #region Konstruktor
        public AfterNewDayEventArgs(string aSection)
            => Section = aSection;
        #endregion
    }
}