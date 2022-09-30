using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class ThornSkin : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private ThornSkin()
            : base(nameof(ThornSkin), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Dornenhaut");
            Name.Set(LanguageEnum.English, "Thorn skin");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ThornSkin());
        }
        #endregion
    }
}