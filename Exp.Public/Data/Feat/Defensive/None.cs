﻿using Exp.Util.Enumeration;

namespace Exp.Data.Feat.Defensive
{
    public sealed class None : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue, Api.General.Tier.Singleton.Get(Public.Properties.Resources.NameDefaultObject)) {
            foreach (LanguageEnum lItem in LanguageEnum.Enumerate()) {
                Name.Set(lItem, Public.Properties.Resources.NameDefaultObject);
                LoreDescription.Set(lItem, Public.Properties.Resources.NameDefaultObject);
            }
        }
        #endregion

        #region Methoden
        internal static void Add() {
            AddInstance(new None());
        }
        #endregion
    }
}