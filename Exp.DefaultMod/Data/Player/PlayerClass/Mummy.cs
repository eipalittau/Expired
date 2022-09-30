using Exp.Data.Player.PlayerClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass
{
    public sealed class Mummy : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Mummy()
            : base(nameof(Mummy), 300, "Justin", new Aptitude.Skill()) {
            Name.Set(LanguageEnum.Deutsch, "Mumie");
            Name.Set(LanguageEnum.English, "Mummy");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Mummy());
        }
        #endregion
    }
}