using Exp.Api.General;
using Exp.Data.Profession.Smithing;
using Exp.Util;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class SmithingData {
        #region Properties / Felder
        public int Level { get; private set; }
        public int MaxLevel { get; init; }
        public int AvailableSmithingPoints { get; internal set; }
        private List<ISmithingData> SmithingList { get; } = new List<ISmithingData>();
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

        internal void LevelUp(ISmithingData aSmithing) {
            AddTalent(aSmithing);
        }

        internal int Count() {
            return SmithingList.Count;
        }

        internal IList<ISmithingData> Enumerate() {
            return SmithingList.AsReadOnly();
        }

        internal void AddTalent(ISmithingData aProfession) {
            if (SmithingList.Contains(aProfession)) {
                ExceptionHandler.Add(new Exception.DublicateItemException(aProfession.ID));
            } else {
                SmithingList.Add(aProfession);
            }
        }

        public IList<ISmithingData> EnumerateUnused() {
            return Api.Profession.Smithing.Singleton.Enumerate().Except(Enumerate()).ToList().AsReadOnly();
        }
        #endregion
    }
}