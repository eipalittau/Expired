namespace Exp.Data {
    public sealed class EffectEnum : EnumBase {
        #region Properties / Folder
        private static int mCurrentID = 0;
        internal static EffectEnum None = new(nameof(None));
        public static EffectEnum Primary = new(nameof(Primary));
        public static EffectEnum Secondary = new(nameof(Secondary));
        public static EffectEnum Tertiary = new(nameof(Tertiary));
        #endregion
    
        #region Konstruktor
        private EffectEnum(string aName) : base(mCurrentID++, aName) { }
        #endregion
      
        #region Methoden
        public static IList<EffectEnum> Enumerate(DirectionEnum aDirection = DirectionEnum.None) {
            return base.Enumerate<EffectEnum>(aDirection)
        }
        
        public static void Add(string aName) {
            
        }
        #endregion
    }
}
