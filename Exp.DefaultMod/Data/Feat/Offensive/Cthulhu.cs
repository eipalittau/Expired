using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Cthulhu : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Cthulhu()
            : base(nameof(Cthulhu), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Cthulhu");
            Name.Set(LanguageEnum.English, "Cthulhu");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Cthulhu());
        }
        #endregion
    }
}