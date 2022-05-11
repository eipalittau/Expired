namespace Exp.DefaultMod.Feat.Hidden {
    public sealed class LoseAction : Exp.Data.Feat.HiddenDataBase, Exp.Data.Feat.IHiddenData {
        #region Konstruktor
        private LoseAction()
            : base(nameof(LoseAction), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Free))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schrei der Banshee");
            Name.Set(Util.LanguageEnum.English, "Scream of the Banshee");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new LoseAction());
        }
        #endregion

        // Patrik: prettify this class pls kthxbye :x
        private int duration = 1;
        // Patrik: nachfolgende properties in separate Klasse (Analog SheetBase)
        private int usesRemaining = 0;
        private int usesRemainingMax = 0;
        private Data.Misc.ModifierData modifier = new Data.Misc.ModifierData(2, 1);
        public IList<ITargetEffect> Execute()
        {
            if (usesRemaining > 0)
            {
                // Patrik: implement me pls BANSHEEEEE!!!!!!
                usesRemaining--;
            }
        }

        public void LevelUp(int newLevel, int newWizardryLevel)
        {
            usesRemainingMax = modifier.Value * ((int)Math.Floor((double)newLevel / modifier.Intervall) + 1);
        }

        public void OnNewDay()
        {
            usesRemaining = usesRemainingMax;
        }
    }
}