using Exp.Data.Feat.Wizardry;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wizardry
{
    public sealed class Metamagic : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private Metamagic()
            : base(nameof(Metamagic), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Metamagie");
            Name.Set(LanguageEnum.English, "Metamagic");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Metamagic());
        }
        #endregion
    }
}