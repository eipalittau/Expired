namespace Exp.Data.Enemy {
    public interface IEnemyClassDataBase : IDataBase {
        /// <summary>Definiert die Reihenfolge im Kampf. Je höher dieser Wert ist, desto später kann der Charakter agieren.</summary>
        int Initiative { get; set; }
    }
}
