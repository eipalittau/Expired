namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class SpellFocus2 : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private SpellFocus2()
            : base(nameof(SpellFocus2), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null, Api.Feat.Wizardry.Singleton.Get(nameof(SpellFocus))) {
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