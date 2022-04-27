using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Charge : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Charge()
            : base(nameof(Charge), 600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Full))) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHARGE!");
            Name.Set(Util.LanguageEnum.English, "CHARGE!");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }

        public void OnNewDay() { }

        public void OnNewBattle() { }

        public void OnNewRound() { }

        public int OnAttack(params IDamageTypeData[] aDamageTypes) {
            return 2;
        }

        public int OnDamage(params IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public IDiceTypeData? OverrideDiceType(params IDamageTypeData[] aDamageTypes) {
            return null;
        }

        public int GetExtraAttack(params IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public CharacterSheet GetExtraBoni(CharaterSheet aCharacterSheet) {

        }
        #endregion
    }
}