using Exp.Data.Enemy.EnemyClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Enemy.EnemyClass {
    public sealed class Cleric : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        private Cleric()
            : base(nameof(Cleric), 200, 200) {
            Name.Set(LanguageEnum.Deutsch, "Kleriker");
            Name.Set(LanguageEnum.English, "Cleric");
            LoreDescription.Set(LanguageEnum.Deutsch, "Der natürliche Feind eines jeden Untoten.");
            LoreDescription.Set(LanguageEnum.English, "The natural Enemy of any undead");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Cleric());
        }
        #endregion
    }
}