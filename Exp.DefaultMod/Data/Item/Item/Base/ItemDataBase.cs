using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal abstract class ItemDataBase : DataBase, IItemQualityDataBase {
        #region Properties / Felder
        public IItemQualityDataBase? Downgrade { get; set; }
        public IItemQualityDataBase? Upgrade { get; set; }
        public bool CanBeDestroyed { get; set; }
        public bool IsDefault { get; set; }
        public IList<IEffectData> EffectList {
            get {
                return _EffectList.AsReadOnly();
            }
        }

        private List<IEffectData> _EffectList;
        #endregion

        #region Konstruktor
        private protected ItemQualityDataBase(string aID, int aSortWeight, bool aCanBeDestroyed, bool aIsDefault, params float[] aEffectValues)
            : base(aID, aSortWeight) {
            CanBeDestroyed = aCanBeDestroyed;
            IsDefault = aIsDefault;
            _EffectList = new List<IEffectData>() {
                Api.Item.Effect.Singleton.Get(nameof(Effect.Primary)),
                Api.Item.Effect.Singleton.Get(nameof(Effect.Secondary))
            };

            if (_EffectList.Count > aEffectValues.Length) {
                Array.Resize(ref aEffectValues, EffectList.Count);
            }

            for (int lI = 0; lI < EffectList.Count; lI++) {
                EffectList[lI].Value = aEffectValues[lI];
            }
        }
        #endregion
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.DefaultMod.Data.Item.Item.Base {
    internal class ItemDataBase {
    }
}
