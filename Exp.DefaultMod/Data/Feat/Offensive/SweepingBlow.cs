using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class SweepingBlow : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Properties / Felder
        private bool DidHit { get; set; }
        private int UsesPerRound { get; set; }
        #endregion

        #region Konstruktor
        internal SweepingBlow()
            : base(nameof(SweepingBlow), 500, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rundumschlag");
            Name.Set(Util.LanguageEnum.English, "Sweeping blow");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public void OnNewDay() { }

        public void OnNewBattle() { }

        public void OnNewRound() {
            DidHit = false;
            UsesPerRound = 1;
        }

        public int OnAttackPassiv(params IDamageTypeData[] aDamageTypes) {
            DidHit = false;
            return 0;
        }

        public int OnDamagePassiv(params IDamageTypeData[] aDamageTypes) {
            DidHit = true;
            return 0;
        }

        public int OnAttackActive() {
            DidHit = false;
            return 0;
        }

        public int OnDamageActive() {
            DidHit = true;
            return 0;
        }

        public IDiceTypeData? OverrideDiceType(params IDamageTypeData[] aDamageTypes) {
            throw new NotImplementedException();
        }

        public int GetExtraAttack(params IDamageTypeData[] aDamageTypes) {
            if (DidHit &&
                UsesPerRound > 0 &&
                base.CheckDamageType(Api.General.DamageType.Singleton.Get(nameof(Data.General.DamageType.Melee)), aDamageTypes)) {
                UsesPerRound--;

                return 1;
            } else {
                return 0;
            }
        }
        #endregion
    }
}