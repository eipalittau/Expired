using Exp.Api.General;
using Exp.Data.Misc.Aptitude;

namespace Exp.Data.Player.PlayerClass {
    public interface IPlayerClassData : IDataBase {
        string CharacterName { get; init; }
        IList<IAptitudeData> AptitudeList { get; }

        IAptitudeData? GetAptitude(TargetEffectEnum aEffect);
    }
}