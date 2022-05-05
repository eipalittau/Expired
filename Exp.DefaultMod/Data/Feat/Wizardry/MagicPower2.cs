namespace Exp.DefaultMod.Feat.Wizardry {
    public sealed class MagicPower2 : Exp.Data.Feat.WizardryDataBase, Exp.Data.Feat.IWizardryData {
        #region Konstruktor
        private MagicPower2()
            : base(nameof(MagicPower2), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null, Api.Feat.Wizardry.Singleton.Get(nameof(MagicPower))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zaubermacht++");
            Name.Set(Util.LanguageEnum.English, "Magic power++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicPower2());
        }
        #endregion
    }
}