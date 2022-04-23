﻿using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Rogue : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Rogue()
            : base(nameof(Rogue), 300, 300) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schurke");
            Name.Set(Util.LanguageEnum.English, "Rogue");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}