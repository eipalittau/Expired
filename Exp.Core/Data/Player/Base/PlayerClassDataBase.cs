namespace Exp.Data.Player {
    public abstract class PlayerClassDataBase : DataBase {
        #region Properties / Felder
        public string CharacterName { get; init; }
        public IList<Misc.IAptitudeData> AptitudeList {
            get { 
                return _AptitudeList.AsReadOnly(); 
            }
        }

        private readonly List<Misc.IAptitudeData> _AptitudeList = new();
        #endregion

        #region Konstruktor
        protected PlayerClassDataBase(string aID, int aSortWeight, string aCharacterName, params Misc.IAptitudeData[] aAptitudes)
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
        #endregion
    }
}