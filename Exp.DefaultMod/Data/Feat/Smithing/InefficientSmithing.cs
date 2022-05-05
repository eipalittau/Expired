﻿namespace Exp.DefaultMod.Feat.Smithing {
    public sealed class InefficientSmithing : Exp.Data.Feat.SmithingDataBase, Exp.Data.Feat.ISmithingData {
        #region Konstruktor
        private InefficientSmithing()
            : base(nameof(InefficientSmithing), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ineffizientes Schmieden");
            Name.Set(Util.LanguageEnum.English, "Inefficient smithing");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new InefficientSmithing());
        }
        #endregion
    }
}