namespace Exp.Data {
  public sealed class EffectEnum {
    #region Properties / Folder
    internal static EffectEnum None = new(0, nameof(None));
    public static EffectEnum Primary = new(1, nameof(Primary));
    public static EffectEnum Secondary = new(2, nameof(Secondary));
    public static EffectEnum Tertiary = new(3, nameof(Tertiary));
    
    public int ID { get; init; }
    public string Name { get; init; }
    #endregion
    
    #region Konstruktor
    private EffectEnum(int aID, string aName)
      => (ID, Name) = (aID, aName);
    #endregion
  }
}
