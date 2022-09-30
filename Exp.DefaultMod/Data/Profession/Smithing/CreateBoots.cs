using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class CreateBoots : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private CreateBoots()
            : base(nameof(CreateBoots), 500,
                   Api.General.Tier.Singleton.Get(nameof(General.Tier.One)),
                   Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Boots))) {
            Name.Set(LanguageEnum.Deutsch, "Schiefel schmieden");
            Name.Set(LanguageEnum.English, "Create boots");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new CreateBoots());
        }
        #endregion
    }
}