namespace Exp.Data.Player {
    public interface IPlayerClassData : IDataBase {
        string CharacterName { get; init; }
        int MovementRate { get; set; }
        public IList<Misc.IAptitudeData> AptitudeList { get; }
    }
}