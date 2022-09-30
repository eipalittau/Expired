using Exp.Data.General.ActionType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.General.ActionType
{
    public sealed class Full : ActionTypeBase, IActionTypeData {
        #region Konstruktor
        private Full()
            : base(nameof(Full), 4, 2.5) {
            Name.Set(LanguageEnum.Deutsch, "Volle Aktion");
            Name.Set(LanguageEnum.English, "Full action");
            LoreDescription.Set(LanguageEnum.Deutsch, "Verbracht eine Standard- und eine Bewegungsaktion.");
            LoreDescription.Set(LanguageEnum.English, "Uses up a Standard- and Movement Action.");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Full());
        }
        #endregion
    }
}