namespace Exp.Data.Feat {
    public interface IOffensiveData : IFeatDataBase<IOffensiveData> {
        void OnNewDay();
        void OnNewBattle();
        void OnNewRound();
        int OnAttackPassiv(params General.IDamageTypeData[] aDamageTypes);
        int OnDamagePassiv(params General.IDamageTypeData[] aDamageTypes);
        int OnAttackActive();
        int OnDamageActive();

        General.IDiceTypeData? OverrideDiceType(params General.IDamageTypeData[] aDamageTypes);
        CharacterSheet GetExtraBoni(CharaterSheet aCharacterSheet);
    }
}
