namespace Exp.DefaultMod.Profession.Smithing {
    public sealed class CreateBoots : Data.Profession.SmithingDataBase, Data.Profession.ISmithingData {
        #region Konstruktor
        private CreateBoots()
            : base(nameof(CreateBoots), 500,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Boots))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schiefel schmieden");
            Name.Set(Util.LanguageEnum.English, "Create boots");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
            EffektDescription.Set(Util.LanguageEnum.Deutsch, "");
            EffektDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new CreateBoots());
        }
        #endregion
    }
}