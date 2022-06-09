namespace Exp.Core.EventArgs {
    public class BeforeNewDayEventArgs {
        #region Properties / Felder
        public string Section { get; init; }
        #endregion

        #region Konstruktor
        public BeforeNewDayEventArgs(string aSection)
            => Section = aSection;
        #endregion
    }
}