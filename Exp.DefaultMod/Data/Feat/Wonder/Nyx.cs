using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class Nyx : WonderDataBase, IWonderData {
        #region Konstruktor
        private Nyx()
            : base(nameof(Nyx), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Nyx");
            Name.Set(LanguageEnum.English, "Nyx");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Nyx());
        }
        #endregion
    }
}