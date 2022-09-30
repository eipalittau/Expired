using Exp.Data.Player.PlayerClass;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.PlayerClass
{
    public sealed class Skeleton : PlayerClassDataBase, IPlayerClassData {
        #region Konstruktor
        private Skeleton()
            : base(nameof(Skeleton), 100, "Kevin", new Aptitude.ArmorClass()) {
            Name.Set(LanguageEnum.Deutsch, "Skelett");
            Name.Set(LanguageEnum.English, "Skeleton");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Skeleton());
        }
        #endregion
    }
}