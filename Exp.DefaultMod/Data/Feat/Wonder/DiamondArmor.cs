using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class DiamondArmor : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal DiamondArmor()
            : base(nameof(DiamondArmor), 900, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Diamantrüstung");
            Name.Set(Util.LanguageEnum.English, "Diamond armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}