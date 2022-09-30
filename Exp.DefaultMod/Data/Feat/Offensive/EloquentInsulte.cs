using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class EloquentInsulte : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private EloquentInsulte()
            : base(nameof(EloquentInsulte), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Eloquent beleidigen");
            Name.Set(LanguageEnum.English, "Eloquent insulte");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new EloquentInsulte());
        }
        #endregion
    }
}