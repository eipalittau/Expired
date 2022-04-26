using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MagicWeapon : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MagicWeapon()
            : base(nameof(MagicWeapon), 200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magische Waffe");
            Name.Set(Util.LanguageEnum.English, "Magic weapon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}