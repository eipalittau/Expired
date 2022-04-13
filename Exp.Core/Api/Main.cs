namespace Exp.Api {
    public class Main {
        #region Properties / Felder
        public General.DiceType DiceTypeList { get; } = new General.DiceType();
        public Enemy.EnemyClass EnemyClassList { get; } = new Enemy.EnemyClass();
        #endregion

        #region Konstruktor
        public Main() { }
        #endregion
    }
}