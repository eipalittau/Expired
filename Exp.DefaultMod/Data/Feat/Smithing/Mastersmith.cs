﻿namespace Exp.DefaultMod.Feat.Smithing {
    public sealed class Mastersmith : Exp.Data.Feat.SmithingDataBase, Exp.Data.Feat.ISmithingData {
        #region Konstruktor
        private Mastersmith()
            : base(nameof(Mastersmith), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Meisterschmied");
            Name.Set(Util.LanguageEnum.English, "Mastersmith");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mastersmith());
        }
        #endregion
    }
}