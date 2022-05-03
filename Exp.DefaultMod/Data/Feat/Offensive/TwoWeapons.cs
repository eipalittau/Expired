using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class TwoWeapons : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        internal TwoWeapons()
            : base(nameof(TwoWeapons), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampf mit zwei Waffen");
            Name.Set(Util.LanguageEnum.English, "Fight with two weapons");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}