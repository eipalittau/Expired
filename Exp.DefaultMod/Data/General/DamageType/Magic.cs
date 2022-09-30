using Exp.Data.General.DamageType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.DamageType
{
    public sealed class Magic : DamageTypeBase, IDamageTypeData {
        #region Konstruktor
        private Magic()
            : base(nameof(Magic), 3) {
            Name.Set(LanguageEnum.Deutsch, "Magie");
            Name.Set(LanguageEnum.English, "Magic");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Magic());
        }
        #endregion
    }
}