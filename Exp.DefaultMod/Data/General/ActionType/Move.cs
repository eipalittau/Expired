using Exp.Data.General.ActionType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.ActionType
{
    public sealed class Move : ActionTypeBase, IActionTypeData {
        #region Konstruktor
        private Move()
            : base(nameof(Move), 2, 1) {
            Name.Set(LanguageEnum.Deutsch, "Bewegungsaktion");
            Name.Set(LanguageEnum.English, "Move action");
            LoreDescription.Set(LanguageEnum.Deutsch, "Nicht offensive Aktion");
            LoreDescription.Set(LanguageEnum.English, "Non offensive Action");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Move());
        }
        #endregion
    }
}