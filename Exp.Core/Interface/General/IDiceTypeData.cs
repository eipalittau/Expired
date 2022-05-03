namespace Exp.Data.General {
    public interface IDiceTypeData : IDataBase {
        int Faces { get; set; }

        int Roll();
    }
}