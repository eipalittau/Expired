using Exp.Data.Feat.Aura;

namespace Exp.DefaultMod.Feat.Aura {
    public sealed class BrokenWingsGambit : AuraDataBase, IAuraData {
        #region Konstruktor
        private BrokenWingsGambit()
            : base(nameof(BrokenWingsGambit), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Free))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gambit der gebrochenen Flügel");
            Name.Set(Util.LanguageEnum.English, "Broken Wings Gambit");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BrokenWingsGambit());
        }
        #endregion
    }
}