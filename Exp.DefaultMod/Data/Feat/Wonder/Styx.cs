using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class Styx : WonderDataBase, IWonderData {
        #region Konstruktor
        private Styx()
            : base(nameof(Styx), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Styx");
            Name.Set(Util.LanguageEnum.English, "Styx");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Styx());
        }
        #endregion
    }
}