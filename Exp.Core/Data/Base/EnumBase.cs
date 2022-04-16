namespace Exp.Data {
  public abstract class EnumBase {
    public int ID { get; init; }
    public string Name { get; init; }
    
    protected EnumBase(int aID, string aName)
      => (ID, Name) = (aID, aName);      
  }
}
