namespace Exp.Data.Feat {
    public interface IOffensiveData : IFeatDataBase<IOffensiveData> {
        int OnAttack(params General.IDamageTypeData[] aDamageTypes);
        int OnDamage(params General.IDamageTypeData[] aDamageTypes);
        void OnNewBattle();
        void OnNewRound();

        General.IDiceTypeData? OverrideDiceType(params General.IDamageTypeData[] aDamageTypes);
        int GetExtraAttack(params General.IDamageTypeData[] aDamageTypes);
    }
}
