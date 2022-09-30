using Exp.Data.Enemy.EnemyClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Enemy.EnemyClass
{
    public sealed class Rogue :EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        private Rogue()
            : base(nameof(Rogue), 300, 300) {
            Name.Set(LanguageEnum.Deutsch, "Schurke");
            Name.Set(LanguageEnum.English, "Rogue");
            LoreDescription.Set(LanguageEnum.Deutsch, "Das spitze Ende geht in den Gegner.");
            LoreDescription.Set(LanguageEnum.English, "The pointy end goes into the enemy.");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Rogue());
        }
        #endregion
    }
}