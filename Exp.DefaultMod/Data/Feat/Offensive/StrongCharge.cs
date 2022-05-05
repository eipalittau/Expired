namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class StrongCharge : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private StrongCharge()
            : base(nameof(StrongCharge), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Full))) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHAAAARGE!!!");
            Name.Set(Util.LanguageEnum.English, "CHAAAARGE!!!");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new StrongCharge());
        }
        #endregion
    }
}