﻿namespace Exp.DefaultMod.Enemy.EnemyClass {
    public sealed class Rogue : Exp.Data.Enemy.EnemyClassBase, Exp.Data.Enemy.IEnemyClassData {
        #region Konstruktor
        private Rogue()
            : base(nameof(Rogue), 300, 300) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schurke");
            Name.Set(Util.LanguageEnum.English, "Rogue");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Rogue());
        }
        #endregion
    }
}