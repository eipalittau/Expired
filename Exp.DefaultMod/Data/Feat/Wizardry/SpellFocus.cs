using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class SpellFocus : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private SpellFocus()
            : base(nameof(SpellFocus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Zauberfokus");
            Name.Set(LanguageEnum.English, "Spell focus");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SpellFocus());
        }
        #endregion
    }
}