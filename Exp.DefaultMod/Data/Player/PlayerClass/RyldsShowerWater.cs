using Exp.Data.Player.PlayerClass;

namespace Exp.DefaultMod.Player.PlayerClass {
    public sealed class RyldsShowerWater : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private RyldsShowerWater()
            : base(nameof(RyldsShowerWater), 700, "*Würg*") {
            Name.Set(Util.LanguageEnum.Deutsch, "Ryld's Duschwasser");
            Name.Set(Util.LanguageEnum.English, "Ryld's shower water");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RyldsShowerWater());
        }
        #endregion
    }
}