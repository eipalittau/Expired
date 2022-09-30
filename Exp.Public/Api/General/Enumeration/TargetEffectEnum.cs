using Exp.Util.Enumeration.Base;

namespace Exp.Api.General
{
    public class TargetEffectEnum : EnumerationBase {
        #region Properties / Felder
        internal readonly static TargetEffectEnum None = new(Public.Properties.Resources.NameDefaultObject, Public.Properties.Resources.NameDefaultObject);
        public readonly static TargetEffectEnum Armor = new(nameof(Armor), "Verändert die Rüstungsklasse");
        public readonly static TargetEffectEnum NaturalArmor = new(nameof(NaturalArmor), "Verändert die natürliche Rüstungsklasse");
        public readonly static TargetEffectEnum Health = new(nameof(Health), "Verändert die maximale anzahl Lebenspunkte");
        public readonly static TargetEffectEnum Mana = new(nameof(Mana), "Verändert die Anzahl der Manapunkte");
        public readonly static TargetEffectEnum FeatPoints = new(nameof(FeatPoints), "Verändert die Anzahl der Attributspunkte");
        public readonly static TargetEffectEnum SkillPoints = new(nameof(SkillPoints), "Verändert die Anzahl der Fertigkeitspunkte");
        public readonly static TargetEffectEnum SmithingPoints = new(nameof(SmithingPoints), "Verändert die Anzahl der Fertigkeitspunkte für den Beruf.");
        public readonly static TargetEffectEnum Resistence = new(nameof(Resistence), "Verändert die Resistenz");
        public readonly static TargetEffectEnum Attack = new(nameof(Attack), "Verändert den Angriffs-Bonus/-Malus");
        public readonly static TargetEffectEnum Damage = new(nameof(Damage), "Verändert den Schadens-Bonus/-Malus");
        public readonly static TargetEffectEnum Sneaky = new(nameof(Sneaky), "Verändert den Angriffs-Bonus/-Malus beim Schleichen");
        public readonly static TargetEffectEnum Movement = new(nameof(Movement), "Verändert die Bewegungsrate");
        public readonly static TargetEffectEnum LoseAction = new(nameof(LoseAction), "Das Ziel verliert alle Aktionen");
        public readonly static TargetEffectEnum Overheal = new(nameof(Overheal), "Charakter kann über das Maximum geheilt werden.");
        public readonly static TargetEffectEnum Exp4LevelUp = new(nameof(Exp4LevelUp), "Setzt die Anzahl Punkte bis zum Level-Up.");

        private static int mIndexCounter = -1;
        #endregion

        #region Konstruktor
        private TargetEffectEnum(string aName, string aDescription)
            : base(mIndexCounter++, aName, aDescription) { }
        #endregion

        #region Methoden
        public bool Equals(TargetEffectEnum aChanger) {
            return NameEquals(aChanger);
        }
        #endregion
    }
}