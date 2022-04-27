namespace Exp.Data.Feat {
    public interface IOffensiveData : IFeatDataBase<IOffensiveData> {
        public int OnAttack(params General.IDamageTypeData[] aDamageTypes);
        public int OnDamage(params General.IDamageTypeData[] aDamageTypes);
        public General.IDiceTypeData? OverrideDiceType(params General.IDamageTypeData[] aDamageTypes);
    }
}
