using Exp.Data.General.DamageType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DamageType
{
    public sealed class RangedCombat : DamageTypeBase, IDamageTypeData {
        #region Konstruktor
        private RangedCombat()
            : base(nameof(RangedCombat), 2) {
            Name.Set(LanguageEnum.Deutsch, "Fernkampf");
            Name.Set(LanguageEnum.English, "Ranged combat");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RangedCombat());
        }
        #endregion
    }
}