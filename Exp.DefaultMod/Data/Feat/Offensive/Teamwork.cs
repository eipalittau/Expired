﻿namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Teamwork : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Teamwork()
            : base(nameof(Teamwork), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null, Api.Feat.Offensive.Singleton.Get(nameof(Teamplayer))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamwork");
            Name.Set(Util.LanguageEnum.English, "Teamwork");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Teamwork());
        }
        #endregion
    }
}