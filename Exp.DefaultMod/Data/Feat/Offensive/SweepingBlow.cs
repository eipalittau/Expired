using Exp.Data.Feat.Offensive;
using Exp.Data.General.DamageType;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class SweepingBlow : OffensiveDataBase, IOffensiveData {
        #region Properties / Felder
        private bool DidHit { get; set; }
        private int UsesPerRound { get; set; }
        #endregion

        #region Konstruktor
        private SweepingBlow()
            : base(nameof(SweepingBlow), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rundumschlag");
            Name.Set(Util.LanguageEnum.English, "Sweeping blow");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SweepingBlow());
        }

        public new void OnNewRound() {
            DidHit = false;
            UsesPerRound = 1;
        }

        public new int OnAttackPassiv(params IDamageTypeData[] aDamageTypes) {
            DidHit = false;
            return 0;
        }

        public new int OnDamagePassiv(params IDamageTypeData[] aDamageTypes) {
            DidHit = true;
            return 0;
        }

        public int GetExtraAttack(params IDamageTypeData[] aDamageTypes) {
            if (DidHit &&
                UsesPerRound > 0 &&
                base.CheckDamageType(Api.General.DamageType.Singleton.Get(nameof(General.DamageType.Melee)), aDamageTypes)) {
                UsesPerRound--;

                return 1;
            } else {
                return 0;
            }
        }
        #endregion
    }
}