using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Stonethrower : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Stonethrower()
            : base(nameof(Stonethrower), 200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinwerfer");
            Name.Set(Util.LanguageEnum.English, "Stone thrower");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "{\rtf1Fernkampf: +1 Angriff, +1 Schaden\lineFernkampfangriff: 1W4 Schaden}");
            EffektDescription.Set(Util.LanguageEnum.English, "{\rtf1Fernkampf: +1 Angriff, +1 Schaden\lineFernkampfangriff: 1W4 Schaden}");        }
        #endregion
        
        #region Methoden
        public int OnAttack(params Exp.Interface.General.IDamageTypeData[] aDamageTypes) {
            if (base.CheckDamageType(aDamageTypes)) {
                return 1;
            } else {
                return 0;
            }
        }
        
        public int OnDamage(params Exp.Interface.General.IDamageTypeData[] aDamageTypes) {
            if (base.CheckDamageType(aDamageTypes)) {
                return 1;
            } else {
                return 0;
            }
        }
        
        public IDiceTypeData? OverrideDiceType(params Exp.Interface.General.IDamageTypeData[] aDamageTypes) {
            if (base.CheckDamageType(aDamageTypes)) {
                return Exp.Api.General.DiceType.Singleton.Get(nameof(Exp.DefaultMod.General.D4));
            } else {
                return null;
            }
        }
        #endregion
    }
}
