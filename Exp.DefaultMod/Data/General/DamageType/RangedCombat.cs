using Exp.Data.General.DamageType;

namespace Exp.DefaultMod.General.DamageType {
    public sealed class RangedCombat : DamageTypeBase, IDamageTypeData {
        #region Konstruktor
        private RangedCombat()
            : base(nameof(RangedCombat), 2) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fernkampf");
            Name.Set(Util.LanguageEnum.English, "Ranged combat");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RangedCombat());
        }
        #endregion
    }
}