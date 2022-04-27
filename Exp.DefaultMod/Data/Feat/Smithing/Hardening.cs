using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Smithing {
    internal sealed class Hardening : FeatDataBase<ISmithingData>, ISmithingData {
        #region Konstruktor
        internal Hardening()
            : base(nameof(Hardening), 200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.Equipment.ItemType.Singleton.Get(nameof(DefaultMod.Equipment.ItemType.OneHandedWeapon))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Härten");
            Name.Set(Util.LanguageEnum.English, "Hardening");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}