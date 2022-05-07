namespace Exp.Data.Misc {
    public interface IAptitudeData : IDataBase {
        ModifierData Base { get; init; }
        ModifierData Modifier { get; init; }
        ModifierData Multiplicator { get; init; }
        ModifierData Divisor { get; init; }
        Api.General.CharacterChangerEnum Changer { get; init; }
    }
}