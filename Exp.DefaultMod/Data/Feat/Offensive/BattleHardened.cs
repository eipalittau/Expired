using Exp.Data.Feat.Offensive;
using Exp.Data.General.DamageType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class BattleHardened : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private BattleHardened()
            : base(nameof(BattleHardened), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Kampferprobt");
            Name.Set(LanguageEnum.English, "Battle hardened");
            LoreDescription.Set(LanguageEnum.Deutsch, "Immer Mitten in die Fresse rein...");
            LoreDescription.Set(LanguageEnum.English, "Always right in the face...");
            EffectDescription.Set(LanguageEnum.Deutsch, "+1 Angriff, +1 Schaden");
            EffectDescription.Set(LanguageEnum.English, "+1 Angriff, +1 Schaden");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BattleHardened());
        }

        public new int OnAttackPassiv(params IDamageTypeData[] aDamageTypes) {
            return 1;
        }

        public new int OnDamagePassiv(params IDamageTypeData[] aDamageTypes) {
            return 1;
        }
        #endregion
    }
}