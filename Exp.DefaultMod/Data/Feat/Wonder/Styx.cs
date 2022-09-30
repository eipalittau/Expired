using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class Styx : WonderDataBase, IWonderData {
        #region Konstruktor
        private Styx()
            : base(nameof(Styx), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Styx");
            Name.Set(LanguageEnum.English, "Styx");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Styx());
        }
        #endregion
    }
}