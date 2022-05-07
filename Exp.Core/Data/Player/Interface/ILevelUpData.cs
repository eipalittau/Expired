namespace Exp.Data.Player {
    public interface ILevelUpData : IDataBase {
        Api.General.CharacterChangerEnum Changer { get; init; }
        Misc.ModifierData Base { get; init; }
    }
}