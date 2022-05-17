using Exp.Data.Feat.Offensive;
using Exp.Data.General.DamageType;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Charge : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Charge()
            : base(nameof(Charge), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Full))) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHARGE!");
            Name.Set(Util.LanguageEnum.English, "CHARGE!");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Charge());
        }

        public new int OnAttackPassiv(params IDamageTypeData[] aDamageTypes) {
            return 2;
        }
        #endregion
    }
}