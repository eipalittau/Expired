using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Riposte : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Riposte()
            : base(nameof(Riposte), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Antworten");
            Name.Set(LanguageEnum.English, "Riposte");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Riposte());
        }
        #endregion
    }
}