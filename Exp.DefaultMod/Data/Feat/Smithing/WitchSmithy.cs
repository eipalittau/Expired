namespace Exp.DefaultMod.Feat.Smithing {
    public sealed class WitchSmithy : Exp.Data.Feat.SmithingDataBase, Exp.Data.Feat.ISmithingData {
        #region Konstruktor
        private WitchSmithy()
            : base(nameof(WitchSmithy), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hexenschmiede");
            Name.Set(Util.LanguageEnum.English, "Witch smithy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new WitchSmithy());
        }
        #endregion
    }
}