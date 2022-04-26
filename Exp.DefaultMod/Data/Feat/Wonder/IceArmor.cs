using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class IceArmor : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal IceArmor()
            : base(nameof(IceArmor), 100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eisrüstung");
            Name.Set(Util.LanguageEnum.English, "Ice armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}