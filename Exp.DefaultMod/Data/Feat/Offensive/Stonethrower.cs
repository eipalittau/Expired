using Exp.Data.Feat.Offensive;
using Exp.Data.General.DamageType;
using Exp.Data.General.DiceType;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Stonethrower : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Stonethrower()
            : base(nameof(Stonethrower), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinwerfer");
            Name.Set(Util.LanguageEnum.English, "Stone thrower");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, @"{\rtf1Komm her und kämpfe wie ein richtiger Mann!}");
            LoreDescription.Set(Util.LanguageEnum.English, @"{\rtf1Come here and fight like a real man!}");
            EffectDescription.Set(Util.LanguageEnum.Deutsch, @"{\rtf1Fernkampf: +1 Angriff, +1 Schaden\lineFernkampfangriff: 1W4 Schaden}");
            EffectDescription.Set(Util.LanguageEnum.English, @"{\rtf1Fernkampf: +1 Angriff, +1 Schaden\lineFernkampfangriff: 1W4 Schaden}");
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

        public new IDiceTypeData? OverrideDiceType(params IDamageTypeData[] aDamageTypes) {
            if (base.CheckDamageType(Api.General.DamageType.Singleton.Get(nameof(General.DamageType.RangedCombat)), aDamageTypes)) {
                return Api.General.DiceType.Singleton.Get(nameof(General.DiceType.D4));
            } else {
                return null;
            }
        }
        #endregion
    }
}