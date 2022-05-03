using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Masterwork : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Masterwork()
            : base(nameof(Masterwork), 500, false, false, GetEffects()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Meisterarbeit");
            Name.Set(Util.LanguageEnum.English, "Masterwork");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        private static Exp.Data.Item.IEffectData[] GetEffects() {
            List<IEffectData> lEffectList = Exp.Api.Item.Effect.Singleton.List().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = 1;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = 1;

            return lEffectList.ToArray();
        }
        #endregion
    }
}