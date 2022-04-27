﻿using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class BattleHardened : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal BattleHardened()
            : base(nameof(BattleHardened), 100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampferprobt");
            Name.Set(Util.LanguageEnum.English, "Battle hardened");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Habe viel auf die Fresse bekommen. +1 Angriff, +1 Schaden");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "+1 Angriff, +1 Schaden");
            EffektDescription.Set(Util.LanguageEnum.English, "+1 Angriff, +1 Schaden");
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
