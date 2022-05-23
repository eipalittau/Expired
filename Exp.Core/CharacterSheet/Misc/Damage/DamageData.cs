using Exp.Api.General;
using Exp.Data.General.DamageType;

namespace Exp.Core.Sheet {
    public sealed class DamageData {
        #region Properties / Felder
        private List<DamageItemData> mDataList = new();
        #endregion

        #region Konstruktor
        internal DamageData(CharacterSheet aMain) {
            DamageType.Singleton.Enumerate().ToList().ForEach(x => {
                mDataList.Add(new DamageItemData(aMain, x));
            });
        }
        #endregion

        #region Methoden
        internal int Count() {
            return mDataList.Count;
        }

        internal DamageItemData Get(IDamageTypeData aDamageType) {
            return mDataList.Where(x => x.DamageType == aDamageType).First();
        }

        internal IList<DamageItemData> Enumerate() {
            return mDataList.AsReadOnly();
        }

        internal void LevelUp() {
            mDataList.ForEach(x => x.LevelUp());
        }
        #endregion
    }
}