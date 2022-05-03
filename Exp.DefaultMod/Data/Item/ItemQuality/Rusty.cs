using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class Rusty : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        internal Rusty()
            : base(nameof(Rusty), 100, true, false, GetEffects()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rostig");
            Name.Set(Util.LanguageEnum.English, "Rusty");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        private static Exp.Data.Item.IEffectData[] GetEffects() {
            List<IEffectData> lEffectList = Exp.Api.Item.Effect.Singleton.List().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = -1;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = -1;

            return lEffectList.ToArray();
        }
        #endregion
    }
}