using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class BattleHardened : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal BattleHardened()
            : base(nameof(BattleHardened), 100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampferprobt");
            Name.Set(Util.LanguageEnum.English, "Battle hardened");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "{\rtf1Immer Mitten in die Fresse rein...}");
            LoreDescription.Set(Util.LanguageEnum.English, "{\rtf1Always right in the face...}");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "{\rtf1+1 Angriff, +1 Schaden}");
            EffektDescription.Set(Util.LanguageEnum.English, "{\rtf1+1 Angriff, +1 Schaden}");
        }
        #endregion
        
        #region Methoden
        public int OnAttack(params Exp.Interface.General.IDamageTypeData[] aDamageTypes) {
            return 1;
        }
        
        public int OnDamage(params Exp.Interface.General.IDamageTypeData[] aDamageTypes) {
            return 1;
        }
        
        public IDiceTypeData? OverrideDiceType(params Exp.Interface.General.IDamageTypeData[] aDamageTypes) {
            return null;
        }
        #endregion
    }
}
