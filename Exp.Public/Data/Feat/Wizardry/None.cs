﻿namespace Exp.Data.Feat.Wizardry {
    public sealed class None : WizardryDataBase, IWizardryData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue, Api.General.Tier.Singleton.Get(Public.Properties.Resources.NameDefaultObject)) {
            foreach (Util.LanguageEnum lItem in Util.LanguageEnum.Enumerate()) {
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