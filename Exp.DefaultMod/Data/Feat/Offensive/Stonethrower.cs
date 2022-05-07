namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Stonethrower : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Stonethrower()
            : base(nameof(Stonethrower), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinwerfer");
            Name.Set(Util.LanguageEnum.English, "Stone thrower");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, @"{\rtf1Komm her und kämpfe wie ein richtiger Mann!}");
            LoreDescription.Set(Util.LanguageEnum.English, @"{\rtf1Come here and fight like a real man!}");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, @"{\rtf1Fernkampf: +1 Angriff, +1 Schaden\lineFernkampfangriff: 1W4 Schaden}");
            EffektDescription.Set(Util.LanguageEnum.English, @"{\rtf1Fernkampf: +1 Angriff, +1 Schaden\lineFernkampfangriff: 1W4 Schaden}");
        }
        #endregion
        
        #region Methoden
        public static void Add() {
            AddInstance(new Stonethrower());
        }

        public new int OnAttackActive() {
            return 1;
        }

        public new int OnDamageActive() {
            return 1;
        }

        public new Exp.Data.General.IDiceTypeData? OverrideDiceType(params Exp.Data.General.IDamageTypeData[] aDamageTypes) {
            if (base.CheckDamageType(Api.General.DamageType.Singleton.Get(nameof(General.DamageType.RangedCombat)), aDamageTypes)) {
                return Api.General.DiceType.Singleton.Get(nameof(General.DiceType.D4));
            } else {
                return null;
            }
        }
        #endregion
    }
}