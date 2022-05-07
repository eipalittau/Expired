namespace Exp.Data.Misc {
    public abstract class AptitudeDataBase : DataBase {
        #region Properties / Felder
        public ModifierData Base { get; init; } = new(0, 0);
        public ModifierData Modifier { get; init; } = new(0, 0);
        public ModifierData Multiplicator { get; init; } = new(1, 1);
        public ModifierData Divisor { get; init; } = new(1, 1);
        public Api.General.CharacterChangerEnum Changer { get; init; }
        #endregion

        #region Konstruktor
        protected AptitudeDataBase(string aID, Api.General.CharacterChangerEnum aChanger)
            : base(aID, 0) 
            => Changer = aChanger;
        #endregion

        #region Methoden
        protected static void AddInstance(IAptitudeData aInstance) {
            Api.Misc.Aptitude.Singleton.Add(aInstance);
        }
        #endregion
    }
}