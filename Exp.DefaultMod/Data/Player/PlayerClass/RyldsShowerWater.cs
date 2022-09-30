using Exp.Data.Player.PlayerClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass
{
    public sealed class RyldsShowerWater : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private RyldsShowerWater()
            : base(nameof(RyldsShowerWater), 700, "*Würg*") {
            Name.Set(LanguageEnum.Deutsch, "Ryld's Duschwasser");
            Name.Set(LanguageEnum.English, "Ryld's shower water");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RyldsShowerWater());
        }
        #endregion
    }
}