using Exp.Data.General.ActionType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.ActionType
{
    public sealed class Free : ActionTypeBase, IActionTypeData {
        #region Konstruktor
        private Free()
            : base(nameof(Free), 1, 0) {
            Name.Set(LanguageEnum.Deutsch, "Freie Aktion");
            Name.Set(LanguageEnum.English, "Free action");
            LoreDescription.Set(LanguageEnum.Deutsch, "Jede Freie Aktion kann ein Mal pro Runde angewendet werden.");
            LoreDescription.Set(LanguageEnum.English, "Each Free Action can be taken once per turn.");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Free());
        }
        #endregion
    }
}