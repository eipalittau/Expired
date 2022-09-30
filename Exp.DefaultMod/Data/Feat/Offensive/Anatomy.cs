using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Anatomy : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Anatomy()
            : base(nameof(Anatomy), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Anatomie");
            Name.Set(LanguageEnum.English, "Anatomy");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Anatomy());
        }
        #endregion
    }
}