using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class SpellFocus2 : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private SpellFocus2()
            : base(nameof(SpellFocus2), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Wizardry.Singleton.Get(nameof(SpellFocus))) {
            Name.Set(LanguageEnum.Deutsch, "Zauberfokus++");
            Name.Set(LanguageEnum.English, "Spell focus++");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SpellFocus2());
        }
        #endregion
    }
}