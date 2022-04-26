using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class AccurateWeapon : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal AccurateWeapon()
            : base(nameof(AccurateWeapon), 1000, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zielsichere Waffe");
            Name.Set(Util.LanguageEnum.English, "Accurate weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}