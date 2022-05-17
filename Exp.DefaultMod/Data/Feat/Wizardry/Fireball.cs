using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class Fireball : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Fireball()
            : base(nameof(Fireball), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Feuerball");
            Name.Set(Util.LanguageEnum.English, "Fireball");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fireball());
        }
        #endregion
    }
}