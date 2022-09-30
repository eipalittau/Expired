using Exp.Data.Feat.Offensive;
using Exp.Data.General.DamageType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Charge : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Charge()
            : base(nameof(Charge), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Full))) {
            Name.Set(LanguageEnum.Deutsch, "CHARGE!");
            Name.Set(LanguageEnum.English, "CHARGE!");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
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