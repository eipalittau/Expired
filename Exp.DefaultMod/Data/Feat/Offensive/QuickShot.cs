using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class QuickShot : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private QuickShot()
            : base(nameof(QuickShot), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Schnellschuss");
            Name.Set(LanguageEnum.English, "quick shot");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new QuickShot());
        }
        #endregion
    }
}