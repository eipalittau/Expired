using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Charge : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        internal Charge()
            : base(nameof(Charge), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Full))) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHARGE!");
            Name.Set(Util.LanguageEnum.English, "CHARGE!");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }

        public new int OnAttackActive() {
            return 2;
        }

        public int GetExtraAttack(params IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public CharacterSheet GetExtraBoni(CharaterSheet aCharacterSheet) {

        }
        #endregion
    }
}