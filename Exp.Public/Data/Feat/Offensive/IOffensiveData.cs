using Exp.Data.General.DamageType;
using Exp.Data.General.DiceType;

namespace Exp.Data.Feat.Offensive {
    public interface IOffensiveData : IFeatDataBase {
        List<IOffensiveData> PrerequisiteList { get; }

        string GetFullDescription();
        void OnNewDay();
        void OnNewBattle();
        void OnNewRound();
        int OnAttackPassiv(params IDamageTypeData[] aDamageTypes);
        int OnDamagePassiv(params IDamageTypeData[] aDamageTypes);
        int OnAttackActive();
        int OnDamageActive();

        IDiceTypeData? OverrideDiceType(params IDamageTypeData[] aDamageTypes);
        //CharacterSheet GetExtraBoni(CharaterSheet aCharacterSheet);
    }
}
