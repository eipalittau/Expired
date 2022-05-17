using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class SpellFocus2 : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private SpellFocus2()
            : base(nameof(SpellFocus2), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Wizardry.Singleton.Get(nameof(SpellFocus))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberfokus++");
            Name.Set(Util.LanguageEnum.English, "Spell focus++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SpellFocus2());
        }
        #endregion
    }
}