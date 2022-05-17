using Exp.Data.Feat.Offensive;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class QuickMouth : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private QuickMouth()
            : base(nameof(QuickMouth), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Move)), Api.Feat.Offensive.Singleton.Get(nameof(EloquentInsulte))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schnelles Mundwerk");
            Name.Set(Util.LanguageEnum.English, "Quick mouth");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new QuickMouth());
        }
        #endregion
    }
}