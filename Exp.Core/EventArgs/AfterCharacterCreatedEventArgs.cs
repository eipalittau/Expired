using Exp.Data.Player.PlayerClass;

namespace Exp.Core.EventArgs {
    public class AfterCharacterCreatedEventArgs {
        #region Properties / Felder
        public IPlayerClassData PlayerClass { get; init; }
        #endregion

        #region Konstruktor
        public AfterCharacterCreatedEventArgs(IPlayerClassData aPlayerClass)
            => PlayerClass = aPlayerClass;
        #endregion
    }
}