namespace Exp.Data.Feat {
    public interface IOffensiveData : IFeatDataBase<IOffensiveData> {
        public int OnAttack(params Exp.Interface.General.IDamageTypeData[] aDamageTypes);
        public int OnDamage(params Exp.Interface.General.IDamageTypeData[] aDamageTypes);
        public IDiceTypeData? OverrideDiceType(params Exp.Interface.General.IDamageTypeData[] aDamageTypes);
    }
}
