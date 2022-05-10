namespace Exp.Data.Player {
    public abstract class PlayerClassDataBase : DataBase {
        #region Properties / Felder
        public string CharacterName { get; init; }
        public int MovementRate { get; set; }
        private readonly List<Misc.IAptitudeData> _AptitudeList = new();
        public IList<Misc.IAptitudeData> AptitudeList {
            get { 
                return _AptitudeList.AsReadOnly(); 
            }
        }
        #endregion

        #region Konstruktor
        protected PlayerClassDataBase(string aID, int aSortWeight, string aCharacterName, int aMovementRate, params Misc.IAptitudeData[] aAptitudes)
            : base(aID, aSortWeight) {
            CharacterName = aCharacterName;
            MovementRate = aMovementRate;
            if (aAptitudes != null && aAptitudes.Length > 0) {
                _AptitudeList = aAptitudes.ToList();
            }
        }

        protected PlayerClassDataBase(string aID, int aSortWeight, string aCharacterName, params Misc.IAptitudeData[] aAptitudes)
            : this(aID, aSortWeight, aCharacterName, 3, aAptitudes) { }

        protected PlayerClassDataBase(string aID, int aSortWeight, string aCharacterName)
            : this(aID, aSortWeight, aCharacterName, 3) { }
        #endregion

        #region Methoden
        protected static void AddInstance(IPlayerClassData aInstance) {
            Api.Player.PlayerClass.Singleton.Add(aInstance);
        }
        #endregion
    }
}