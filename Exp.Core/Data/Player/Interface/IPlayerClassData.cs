namespace Exp.Data.Player {
    public interface IPlayerClassData : IDataBase {
        string CharacterName { get; init; }
        public IList<Misc.IAptitudeData> AptitudeList { get; }
    }
}