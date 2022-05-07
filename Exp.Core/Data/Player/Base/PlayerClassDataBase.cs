namespace Exp.Data.Player {
    public abstract class PlayerClassDataBase : DataBase {
        #region Properties / Felder
        public string CharacterName { get; init; }
        #endregion

        #region Konstruktor
        protected PlayerClassDataBase(string aID, int aSortWeight, string aCharacterName)
            : base(aID, aSortWeight)
            => (CharacterName) = (aCharacterName);
        #endregion

        #region Methoden
        protected static void AddInstance(IPlayerClassData aInstance) {
            Api.Player.PlayerClass.Singleton.Add(aInstance);
        }
        #endregion
    }
}