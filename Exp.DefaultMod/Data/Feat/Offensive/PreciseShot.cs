using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class PreciseShot : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private PreciseShot()
            : base(nameof(PreciseShot), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Präziser Schuss");
            Name.Set(LanguageEnum.English, "Precise shot");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new PreciseShot());
        }
        #endregion
    }
}