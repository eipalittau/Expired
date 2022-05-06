using Exp.Data.Enemy;

namespace Exp.DefaultMod.Enemy {
    internal sealed class Mage : EnemyClassBase, IEnemyClassData {
        #region Konstruktor
        internal Mage()
            : base(nameof(Mage), 100, 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magier");
            Name.Set(Util.LanguageEnum.English, "Mage");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "Wenn du einen Zauber auswählen kannst, nimm Feuerball. Wenn du zwei Zauber auswählen kannst, nimm zwei mal Feuerball.");
            LoreDescription.Set(Util.LanguageEnum.English, "If you can pick a spell, pick Fireball. If you can pick zwo spells, pick Fireball twice.");
        }
        #endregion
    }
}