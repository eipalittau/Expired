namespace Exp.Api.General {
    public class CharacterChangerEnum : Util.EnumerationBase {
        #region Properties / Felder
        #region Static
        public static CharacterChangerEnum Armor = new(nameof(Armor), "Verändert die Rüstungsklasse");
        public static CharacterChangerEnum Health = new(nameof(Health), "Verändert die maximale anzahl Lebenspunkte");
        public static CharacterChangerEnum Mana = new(nameof(Mana), "Verändert die Anzahl der Manapunkte");
        public static CharacterChangerEnum FeatPoints = new(nameof(FeatPoints), "Verändert die Anzahl der Attributspunkte");
        public static CharacterChangerEnum Feat = new(nameof(Feat), "Verändert spezielle Fähigkeiten");
        public static CharacterChangerEnum SkillPoints = new(nameof(SkillPoints), "Verändert die Anzahl der Fertigkeitspunkte");
        public static CharacterChangerEnum Resistence = new(nameof(Resistence), "Verändert die Resistenz");
        public static CharacterChangerEnum Attack = new(nameof(Attack), "Verändert den Angriffs-Bonus/-Malus");
        public static CharacterChangerEnum Damage = new(nameof(Damage), "Verändert den Schadens-Bonus/-Malus");
        public static CharacterChangerEnum Sneaky = new(nameof(Sneaky), "Verändert den Angriffs-Bonus/-Malus beim Schleichen");
        public static CharacterChangerEnum Movement = new(nameof(Movement), "Verändert die Bewegungsrate");

        private static int mCounter = 0;
        #endregion

        #region Instance
        #endregion
        #endregion

        #region Konstruktor
        private CharacterChangerEnum(string aName, string aDescription) 
            : base(++mCounter, aName, aDescription) { }
        #endregion

        #region Methoden
        public bool Equals(CharacterChangerEnum aChanger) {
            return this.Name.Equals(aChanger.Name, StringComparison.InvariantCultureIgnoreCase);
        }
        #endregion
    }
}