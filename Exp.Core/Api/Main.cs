namespace Exp.Api {
    internal class Main : IMain {
        public void Initialize() {
            General.ActionType.Singleton.Add(new Data.General.ActionType.Free());
            General.ActionType.Singleton.Add(new Data.General.ActionType.Standard());
            General.ActionType.Singleton.Add(new Data.General.ActionType.Move());
            General.ActionType.Singleton.Add(new Data.General.ActionType.Full());

            General.Tier.Singleton.Add(new Data.General.Tier.One());
            General.Tier.Singleton.Add(new Data.General.Tier.Two());
            General.Tier.Singleton.Add(new Data.General.Tier.Three());
        }
    }
}