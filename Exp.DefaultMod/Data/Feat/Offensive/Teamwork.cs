using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Teamwork : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Teamwork()
            : base(nameof(Teamwork), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Offensive.Singleton.Get(nameof(Teamplayer))) {
            Name.Set(LanguageEnum.Deutsch, "Teamwork");
            Name.Set(LanguageEnum.English, "Teamwork");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Teamwork());
        }
        #endregion
    }
}