namespace RtD.Data {
    public class SkillEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static SkillEnum None = new SkillEnum(0, nameof(None), string.Empty);
        public static SkillEnum Recollection = new SkillEnum(1, nameof(Recollection), "");
        public static SkillEnum Smithing = new SkillEnum(2, nameof(Smithing), "");
        public static SkillEnum Perception = new SkillEnum(3, nameof(Perception), "");
        public static SkillEnum Trap = new SkillEnum(4, nameof(Trap), "");
        public static SkillEnum Looting = new SkillEnum(5, nameof(Looting), "");
        public static SkillEnum Acrobatics = new SkillEnum(6, nameof(Acrobatics), "");
        public static SkillEnum Intimidate = new SkillEnum(7, nameof(Intimidate), "");
        public static SkillEnum AoOCount = new SkillEnum(8, nameof(AoOCount), "");
        public static SkillEnum Reflex = new SkillEnum(9, nameof(Reflex), "");
        public static SkillEnum Will = new SkillEnum(10, nameof(Will), "");
        public static SkillEnum AntiSafetyThrow = new SkillEnum(11, nameof(AntiSafetyThrow), "");

        public string RelevantClass { get; }
        #endregion

        #region Konstruktor
        private SkillEnum(byte aID, string aName, string aDescription)
            : base(aID, aName, aDescription) 
            => RelevantClass = $"Skill{aName}Data";
        #endregion

        #region Methoden
        public static List<SkillEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<SkillEnum>(DirectionEnum.ASC);
        }

        public static List<SkillEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<SkillEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<SkillEnum>();
        }

        public static SkillEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<SkillEnum>(aID, None);
        }

        public static SkillEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<SkillEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}