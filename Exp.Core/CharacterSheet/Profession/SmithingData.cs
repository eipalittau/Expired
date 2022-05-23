using Exp.Api.General;
using Exp.Data.Profession.Smithing;
using Exp.Util;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SmithingData {
        #region Properties / Felder
        public int Level { get; private set; }
        public int MaxLevel { get; init; }
        public int AvailableSmithingPoints { get; internal set; }
        private List<ISmithingData> ProfessionList { get; } = new List<ISmithingData>();
        #endregion

        #region Konstruktor
        internal SmithingData(int aMaxLevel)
            => MaxLevel = aMaxLevel;
        #endregion

        #region Methoden
        internal void SetSmithingPoints() {
            if (Api.Player.LevelUp.Singleton.Contains(TargetEffectEnum.SmithingPoints)) {
                AvailableSmithingPoints = Api.Player.LevelUp.Singleton.Get(TargetEffectEnum.SmithingPoints).Base.Value;
            }
        }

        internal int Count() {
            return ProfessionList.Count;
        }

        internal IList<ISmithingData> Enumerate() {
            return ProfessionList.AsReadOnly();
        }

        internal void AddTalent(ISmithingData aProfession) {
            if (ProfessionList.Contains(aProfession)) {
                ExceptionHandler.Add(new Exception.DublicateItemException(aProfession.ID));
            } else {
                ProfessionList.Add(aProfession);
            }
        }
        #endregion
    }
}