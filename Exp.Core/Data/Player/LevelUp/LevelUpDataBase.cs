using Exp.Data;

namespace Exp.Data.Player.LevelUp {
    public abstract class LevelUpDataBase : DataBase {
        #region Properties / Felder
        public Api.General.TargetEffectEnum Changer { get; init; }
        public Api.Helper.ModifierData Base { get; init; }
        #endregion

        #region Konstruktor
        protected LevelUpDataBase(Api.General.TargetEffectEnum aChanger, Api.Helper.ModifierData aBase)
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