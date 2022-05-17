using Exp.Data.Feat.Wonder;

namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class Nyx : WonderDataBase, IWonderData {
        #region Konstruktor
        private Nyx()
            : base(nameof(Nyx), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nyx");
            Name.Set(Util.LanguageEnum.English, "Nyx");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Nyx());
        }
        #endregion
    }
}