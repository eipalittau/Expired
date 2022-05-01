namespace Exp.DefaultMod.Player.Slot {
    internal abstract class PlayerClassDataBase : DataBase, Exp.Data.Player.IPlayerClassDataBase {
        #region Properties / Felder
        public string CharacterName { get; init; }
        #endregion

        #region Konstruktor
        private protected PlayerClassDataBase(string aID, int aSortWeight, string aCharacterName)
            : base(aID, aSortWeight)
            => (CharacterName) = (aCharacterName);
        #endregion
    }
}