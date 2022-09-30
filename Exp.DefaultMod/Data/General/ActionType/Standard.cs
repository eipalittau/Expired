using Exp.Data.General.ActionType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.ActionType
{
    public sealed class Standard : ActionTypeBase, IActionTypeData {
        #region Konstruktor
        private Standard()
            : base(nameof(Standard), 3, 1.5) {
            Name.Set(LanguageEnum.Deutsch, "Standard Aktion");
            Name.Set(LanguageEnum.English, "Standard action");
            LoreDescription.Set(LanguageEnum.Deutsch, "Offensive Aktion.");
            LoreDescription.Set(LanguageEnum.English, "Offensive action.");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Standard());
        }
        #endregion
    }
}