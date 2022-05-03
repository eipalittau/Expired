using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class BattleHardened : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        internal BattleHardened()
            : base(nameof(BattleHardened), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampferprobt");
            Name.Set(Util.LanguageEnum.English, "Battle hardened");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Immer Mitten in die Fresse rein...");
            LoreDescription.Set(Util.LanguageEnum.English, "Always right in the face...");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "+1 Angriff, +1 Schaden");
            EffektDescription.Set(Util.LanguageEnum.English, "+1 Angriff, +1 Schaden");
        }
        #endregion
        
        #region Methoden
        public int OnAttack(params Data.General.IDamageTypeData[] aDamageTypes) {
            return 1;
        }


        public int OnDamage(params Data.General.IDamageTypeData[] aDamageTypes) {
            return 1;
        }


        public Data.General.IDiceTypeData? OverrideDiceType(params Data.General.IDamageTypeData[] aDamageTypes) {
            return null;
        }
        #endregion
    }
}
