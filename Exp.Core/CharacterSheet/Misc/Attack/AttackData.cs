using Exp.Api.General;
using Exp.Data.General.DamageType;

namespace Exp.Core.Sheet {
    public sealed class AttackData {
        #region Properties / Felder
        private List<AttackItemData> mDataList = new();
        #endregion

        #region Konstruktor
        internal AttackData(CharacterSheet aMain) {
            DamageType.Singleton.Enumerate().ToList().ForEach(x => {
                mDataList.Add(new AttackItemData(aMain, x));
            });
        }
        #endregion

        #region Methoden
        internal int Count() {
            return mDataList.Count;
        }

        internal AttackItemData Get(IDamageTypeData aDamageType) {
            return mDataList.Where(x => x.DamageType == aDamageType).First();
        }

        internal IList<AttackItemData> Enumerate() {
            return mDataList.AsReadOnly();
        }

        internal void LevelUp() {
            mDataList.ForEach(x => x.LevelUp());
        }
        #endregion
    }
}