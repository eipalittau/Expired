﻿namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class ThornSkin : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private ThornSkin()
            : base(nameof(ThornSkin), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dornenhaut");
            Name.Set(Util.LanguageEnum.English, "Thorn skin");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ThornSkin());
        }
        #endregion
    }
}