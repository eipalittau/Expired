namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class MovementData : Exp.Data.Player.LevelUpDataBase, Exp.Data.Player.ILevelUpData {
        #region Konstruktor
        private MovementData()
            : base(Api.General.CharacterChangerEnum.Movement, new Exp.Data.Misc.ModifierData(0, 4)) {
            Name.Set(Util.LanguageEnum.Deutsch, "bewegungsrate");
            Name.Set(Util.LanguageEnum.English, "Movement rate");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MovementData());
        }
        #endregion
    }
}