using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiracleFocus2 : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiracleFocus2()
            : base(nameof(MiracleFocus2), 1400, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null, Api.Feat.Wonder.Singleton.Get(nameof(MiracleFocus))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderfokus++");
            Name.Set(Util.LanguageEnum.English, "Miracle focus++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}