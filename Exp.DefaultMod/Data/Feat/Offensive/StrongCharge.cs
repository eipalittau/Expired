using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class StrongCharge : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private StrongCharge()
            : base(nameof(StrongCharge), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Full))) {
            Name.Set(LanguageEnum.Deutsch, "CHAAAARGE!!!");
            Name.Set(LanguageEnum.English, "CHAAAARGE!!!");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new StrongCharge());
        }
        #endregion
    }
}