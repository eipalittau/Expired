namespace Exp.Api.General {
    public class TargetEffectEnum : Util.EnumerationBase {
        #region Properties / Felder
        internal static TargetEffectEnum None = new(Public.Properties.Resources.NameDefaultObject, Public.Properties.Resources.NameDefaultObject);
        public static TargetEffectEnum Armor = new(nameof(Armor), "Verändert die Rüstungsklasse");
        public static TargetEffectEnum NaturalArmor = new(nameof(NaturalArmor), "Verändert die natürliche Rüstungsklasse");
        public static TargetEffectEnum Health = new(nameof(Health), "Verändert die maximale anzahl Lebenspunkte");
        public static TargetEffectEnum Mana = new(nameof(Mana), "Verändert die Anzahl der Manapunkte");
        public static TargetEffectEnum FeatPoints = new(nameof(FeatPoints), "Verändert die Anzahl der Attributspunkte");
        public static TargetEffectEnum SkillPoints = new(nameof(SkillPoints), "Verändert die Anzahl der Fertigkeitspunkte");
        public static TargetEffectEnum Resistence = new(nameof(Resistence), "Verändert die Resistenz");
        public static TargetEffectEnum Attack = new(nameof(Attack), "Verändert den Angriffs-Bonus/-Malus");
        public static TargetEffectEnum Damage = new(nameof(Damage), "Verändert den Schadens-Bonus/-Malus");
        public static TargetEffectEnum Sneaky = new(nameof(Sneaky), "Verändert den Angriffs-Bonus/-Malus beim Schleichen");
        public static TargetEffectEnum Movement = new(nameof(Movement), "Verändert die Bewegungsrate");
        public static TargetEffectEnum LoseAction = new(nameof(LoseAction), "Das Ziel verliert alle Aktionen");
        private static int mCounter = 0;
        #endregion

        #region Konstruktor
        private TargetEffectEnum(string aName, string aDescription)
            : base(++mCounter, aName, aDescription) { }
        #endregion

        #region Methoden
        public bool Equals(TargetEffectEnum aChanger) {
            return this.Name.Equals(aChanger.Name, StringComparison.InvariantCultureIgnoreCase);
        }
        #endregion
    }
}