namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class SpellFocus : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private SpellFocus()
            : base(nameof(SpellFocus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberfokus");
            Name.Set(Util.LanguageEnum.English, "Spell focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SpellFocus());
        }
        #endregion
    }
}