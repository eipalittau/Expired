using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiracleFocus : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiracleFocus()
            : base(nameof(MiracleFocus), 700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderfokus");
            Name.Set(Util.LanguageEnum.English, "Miracle focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}