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
        public void OnNewDay() {
            DidHit = false;
            UsesPerRound = 1;
        }

        public void OnNewBattle() {
            DidHit = false;
            UsesPerRound = 1;
        }

        public void OnNewRound() {
            DidHit = false;
            UsesPerRound = 1;
        }

        public int OnAttack(params IDamageTypeData[] aDamageTypes) {
            DidHit = false;
            return 0;
        }

        public int OnDamage(params IDamageTypeData[] aDamageTypes) {
            DidHit = true;
            return 0;
        }

        public IDiceTypeData? OverrideDiceType(params IDamageTypeData[] aDamageTypes) {
            throw new NotImplementedException();
        }

        public int GetExtraAttack(params IDamageTypeData[] aDamageTypes) {
            if (UsesPerRound > 0) {
                UsesPerRound--;

                if (base.CheckDamageType(Api.General.DamageType.Singleton.Get(nameof(Data.General.DamageType.RangedCombat)), aDamageTypes)) {
                    return DidHit ? 1 : 0;
                } else {
                    return 0;
                }
            } else {
                return 0;
            }
        }
        #endregion
    }
}