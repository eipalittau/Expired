using Exp.Data.Profession.Smithing;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Profession.Smithing
{
    public sealed class WitchSmithy : SmithingDataBase, ISmithingData {
        #region Konstruktor
        private WitchSmithy()
            : base(nameof(WitchSmithy), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Hexenschmiede");
            Name.Set(LanguageEnum.English, "Witch smithy");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
            EffektDescription.Set(LanguageEnum.Deutsch, "");
            EffektDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new WitchSmithy());
        }
        #endregion
    }
}