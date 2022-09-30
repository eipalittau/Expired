using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Chaos : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Chaos()
            : base(nameof(Chaos), 1900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Chaos");
            Name.Set(LanguageEnum.English, "Chaos");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Chaos());
        }
        #endregion
    }
}