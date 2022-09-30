using Exp.Data.Item.Effect;
using Exp.Data.Item.ItemQuality;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemQuality
{
    public sealed class Hardened : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        private Hardened()
            : base(nameof(Hardened), 400, true, false, GetEffects()) {
            Name.Set(LanguageEnum.Deutsch, "Gehärtet");
            Name.Set(LanguageEnum.English, "Hardened");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
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