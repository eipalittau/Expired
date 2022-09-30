using Exp.Data.Feat.Wonder;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Wonder
{
    public sealed class MagicWeapon : WonderDataBase, IWonderData {
        #region Konstruktor
        private MagicWeapon()
            : base(nameof(MagicWeapon), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Magische Waffe");
            Name.Set(LanguageEnum.English, "Magic weapon");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new MagicWeapon());
        }
        #endregion
    }
}