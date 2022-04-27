namespace Exp.Data.Feat {
    public interface IOffensiveData : IFeatDataBase<IOffensiveData> {
        void OnNewDay();
        void OnNewBattle();
        void OnNewRound();
        int OnAttack(params General.IDamageTypeData[] aDamageTypes);
        int OnDamage(params General.IDamageTypeData[] aDamageTypes);

        General.IDiceTypeData? OverrideDiceType(params General.IDamageTypeData[] aDamageTypes);
        int GetExtraAttack(params General.IDamageTypeData[] aDamageTypes);
    }
}
