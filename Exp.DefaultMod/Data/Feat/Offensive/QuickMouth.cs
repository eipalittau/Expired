using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class QuickMouth : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private QuickMouth()
            : base(nameof(QuickMouth), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Move)), Api.Feat.Offensive.Singleton.Get(nameof(EloquentInsulte))) {
            Name.Set(LanguageEnum.Deutsch, "Schnelles Mundwerk");
            Name.Set(LanguageEnum.English, "Quick mouth");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new QuickMouth());
        }
        #endregion
    }
}