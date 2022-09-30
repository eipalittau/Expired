using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class Tartaros : WonderDataBase, IWonderData {
        #region Konstruktor
        private Tartaros()
            : base(nameof(Tartaros), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Tartaros");
            Name.Set(LanguageEnum.English, "Tartaros");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Tartaros());
        }
        #endregion
    }
}