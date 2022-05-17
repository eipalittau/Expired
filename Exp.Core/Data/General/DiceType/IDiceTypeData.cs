namespace Exp.Data.General.DiceType {
    public interface IDiceTypeData : IDataBase {
        int Faces { get; set; }

        int Roll();
    }
}