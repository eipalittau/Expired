using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Hades : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Hades()
            : base(nameof(Hades), 2000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Hades");
            Name.Set(LanguageEnum.English, "Hades");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hades());
        }
        #endregion
    }
}