using Exp.Data.Item.Effect;
using Exp.Data.Item.ItemQuality;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemQuality
{
    public sealed class Rusty : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        private Rusty()
            : base(nameof(Rusty), 100, true, false, GetEffects()) {
            Name.Set(LanguageEnum.Deutsch, "Rostig");
            Name.Set(LanguageEnum.English, "Rusty");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Rusty());
        }

        private static IEffectData[] GetEffects() {
            List<IEffectData> lEffectList = Api.Item.Effect.Singleton.Enumerate().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = -1;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = -1;

            return lEffectList.ToArray();
        }
        #endregion
    }
}