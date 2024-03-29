﻿namespace Exp.Data.General.DiceType {
    public abstract class DiceTypeBase : DataBase {
        #region Properties / Felder
        public int Faces { get; set; }
        #endregion

        #region Konstruktor
        protected DiceTypeBase(string aID, int aSortWeight, int aFaces)
            : base(aID, aSortWeight)
            => Faces = aFaces;
        #endregion

        #region Methoden
        public int Roll() {
            return new Random().Next(1, Faces);
        }

        protected static void AddInstance(IDiceTypeData aInstance) {
            Api.General.DiceType.Singleton.Add(aInstance);
        }
        #endregion
    }
}