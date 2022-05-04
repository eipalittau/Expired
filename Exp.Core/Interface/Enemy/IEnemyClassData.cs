namespace Exp.Data.Enemy {
    public interface IEnemyClassData : IDataBase {
        int Initiative { get; set; }
        
        void Add();
    }
}
