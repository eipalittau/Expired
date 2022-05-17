using Exp.Data.Item.Effect;
using Exp.Data.Item.ItemQuality;

namespace Exp.DefaultMod.Item.ItemQuality {
    public sealed class Hardened : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        private Hardened()
            : base(nameof(Hardened), 400, true, false, GetEffects()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gehärtet");
            Name.Set(Util.LanguageEnum.English, "Hardened");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hardened());
        }

        private static IEffectData[] GetEffects() {
            List<IEffectData> lEffectList = Api.Item.Effect.Singleton.Enumerate().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = 1;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = 0;

            return lEffectList.ToArray();
        }
        #endregion
    }
}