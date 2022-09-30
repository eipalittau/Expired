using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Teamplayer : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Teamplayer()
            : base(nameof(Teamplayer), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Teamplayer");
            Name.Set(LanguageEnum.English, "Teamplayer");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Teamplayer());
        }
        #endregion
    }
}