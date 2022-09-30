using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class AccurateWeapon : WonderDataBase, IWonderData {
        #region Konstruktor
        private AccurateWeapon()
            : base(nameof(AccurateWeapon), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Zielsichere Waffe");
            Name.Set(LanguageEnum.English, "Accurate weapon");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new AccurateWeapon());
        }
        #endregion
    }
}