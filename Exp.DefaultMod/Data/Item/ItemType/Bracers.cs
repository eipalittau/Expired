using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Bracers : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Bracers()
            : base(nameof(Bracers), 1700, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.WristLeft)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.WristRight))) {
            Name.Set(LanguageEnum.Deutsch, "Armschutz");
            Name.Set(LanguageEnum.English, "Bracers");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Bracers());
        }
        #endregion
    }
}