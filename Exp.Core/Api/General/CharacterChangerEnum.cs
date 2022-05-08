﻿namespace Exp.Api.General {
    public class CharacterChangerEnum : Util.EnumerationBase {
        #region Properties / Felder
        #region Static
        public static CharacterChangerEnum Armor = new(nameof(Armor), "Verändert die Rüstungsklasse");
        public static CharacterChangerEnum Health = new(nameof(Health), "Verändert die maximale anzahl Lebenspunkte");
        public static CharacterChangerEnum Mana = new(nameof(Mana), "Verändert die Anzahl der Manapunkte");
        public static CharacterChangerEnum FeatPoints = new(nameof(FeatPoints), "Verändert die Anzahl der Attributspunkte");
        public static CharacterChangerEnum SkillPoints = new(nameof(SkillPoints), "Verändert die Anzahl der Fertigkeitspunkte");

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