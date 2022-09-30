using Exp.Data.Player.LevelUp;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.LevelUp
{
    public sealed class Armor : LevelUpDataBase, ILevelUpData {
        #region Konstruktor
        private Armor()
            : base(Api.General.TargetEffectEnum.NaturalArmor, new Api.Helper.ModifierData(0, 0, 10)) {
            Name.Set(LanguageEnum.Deutsch, "Natürliche Rüstung");
            Name.Set(LanguageEnum.English, "Natural armor");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Armor());
        }
        #endregion
    }
}