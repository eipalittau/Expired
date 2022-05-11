namespace Exp.Data.Player {
    public abstract class LevelUpDataBase : DataBase {
        #region Properties / Felder
        public Api.General.CharacterChangerEnum Changer { get; init; }
        public Misc.ModifierData Base { get; init; }
        #endregion

        #region Konstruktor
        protected LevelUpDataBase(Api.General.CharacterChangerEnum aChanger, Misc.ModifierData aBase)
            : base(aChanger.Name, 0)
            => (Changer, Base) = (aChanger, aBase);
        #endregion

        #region Methoden
        protected static void AddInstance(ILevelUpData aInstance) {
            Api.Player.LevelUp.Singleton.Add(aInstance);
        }
        #endregion
    }
}