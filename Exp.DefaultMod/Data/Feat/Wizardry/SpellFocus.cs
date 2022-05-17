using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class SpellFocus : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private SpellFocus()
            : base(nameof(SpellFocus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
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