using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class MagicPower : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private MagicPower()
            : base(nameof(MagicPower), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Zaubermacht");
            Name.Set(LanguageEnum.English, "Magic power");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicPower());
        }
        #endregion
    }
}