using Exp.Data.Player.LevelUp;

namespace Exp.DefaultMod.Player.LevelUp {
    public sealed class Armor : LevelUpDataBase, ILevelUpData {
        #region Konstruktor
        private Armor()
            : base(Api.General.TargetEffectEnum.NaturalArmor, new Api.Helper.ModifierData(0, 0, 10)) {
            Name.Set(Util.LanguageEnum.Deutsch, "Natürliche Rüstung");
            Name.Set(Util.LanguageEnum.English, "Natural armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Armor());
        }
        #endregion
    }
}