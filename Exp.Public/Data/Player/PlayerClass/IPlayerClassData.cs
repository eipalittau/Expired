using Exp.Data.Misc.Aptitude;

namespace Exp.Data.Player.PlayerClass {
    public interface IPlayerClassData : IDataBase {
        string CharacterName { get; init; }
        public IList<IAptitudeData> AptitudeList { get; }
    }
}