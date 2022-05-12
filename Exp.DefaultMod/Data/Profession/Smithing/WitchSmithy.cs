namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class WitchSmithy : Data.Profession.SmithingDataBase, Data.Profession.ISmithingData {
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