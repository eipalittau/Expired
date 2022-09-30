using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class MagicPower2 : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private MagicPower2()
            : base(nameof(MagicPower2), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Wizardry.Singleton.Get(nameof(MagicPower))) {
            Name.Set(LanguageEnum.Deutsch, "Zaubermacht++");
            Name.Set(LanguageEnum.English, "Magic power++");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicPower2());
        }
        #endregion
    }
}