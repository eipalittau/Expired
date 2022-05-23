using Exp.Api.General;
using Exp.Data.Misc.Aptitude;

namespace Exp.Data.Player.PlayerClass {
    public abstract class PlayerClassDataBase : DataBase {
        #region Properties / Felder
        public string CharacterName { get; init; }
        public IList<IAptitudeData> AptitudeList {
            get {
                return _AptitudeList.AsReadOnly();
            }
        }

        private readonly List<IAptitudeData> _AptitudeList = new();
        #endregion

        #region Konstruktor
        protected PlayerClassDataBase(string aID, int aSortWeight, string aCharacterName, params IAptitudeData[] aAptitudes)
            : base(aID, aSortWeight) {
            CharacterName = aCharacterName;
            if (aAptitudes != null && aAptitudes.Length > 0) {
                _AptitudeList = aAptitudes.ToList();
            }
        }
        #endregion

        #region Methoden
        protected static void AddInstance(IPlayerClassData aInstance) {
            Api.Player.PlayerClass.Singleton.Add(aInstance);
        }

        public IAptitudeData? GetAptitude(TargetEffectEnum aEffect) {
            return AptitudeList.Where(x => aEffect.Equals(x.Effect)).FirstOrDefault();
        }
        #endregion
    }
}