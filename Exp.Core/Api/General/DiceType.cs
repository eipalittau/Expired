﻿using Exp.Data.General;
using Exp.Util;

namespace Exp.Api.General {
    public sealed class DiceType : ApiBase<Data.General.IDiceTypeData> {
        #region Properties / Felder
        public static DiceType Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private DiceType() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IDiceTypeData> Enumerate() {
            return base.Enumerate();
        }

        public new IDiceTypeData Get(string aID) {
            return base.Get(aID);
        }

        public IDiceTypeData Get(int aFaces) {
            IDiceTypeData? lItem = Singleton.Enumerate()
                .Where(x => x.Faces == aFaces)
                .FirstOrDefault();

            if (lItem == null) {
                throw new Exception.DiceNotFoundException(aFaces);
            } else {
                return lItem;
            }

        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IDiceTypeData aItem) {
            if (aItem.Faces <= 1) {
                ExceptionHandler.Add(new Exception.BadArgumentException(nameof(aItem.Faces), aItem.Faces));
            } else {
                base.Add(aItem);
            }
        }
        #endregion
    }
}