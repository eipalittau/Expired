using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Normal : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Normal()
            : base(nameof(Normal), 300, true, true, GetEffects()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Normal");
            Name.Set(Util.LanguageEnum.English, "Normal");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        private static Exp.Data.Item.IEffectData[] GetEffects() {
            List<IEffectData> lEffectList = Exp.Api.Item.Effect.Singleton.List().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = 0;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = 0;

            return lEffectList.ToArray();
        }
        #endregion
    }
}