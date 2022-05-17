using Exp.Data.Feat.Wizardry;

namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class MagicPower : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private MagicPower()
            : base(nameof(MagicPower), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zaubermacht");
            Name.Set(Util.LanguageEnum.English, "Magic power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicPower());
        }
        #endregion
    }
}