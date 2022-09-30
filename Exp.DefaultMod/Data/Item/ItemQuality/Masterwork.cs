using Exp.Data.Item.Effect;
using Exp.Data.Item.ItemQuality;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemQuality
{
    public sealed class Masterwork : ItemQualityDataBase, IItemQualityData {
        #region Konstruktor
        private Masterwork()
            : base(nameof(Masterwork), 500, false, false, GetEffects()) {
            Name.Set(LanguageEnum.Deutsch, "Meisterarbeit");
            Name.Set(LanguageEnum.English, "Masterwork");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Masterwork());
        }

        private static IEffectData[] GetEffects() {
            List<IEffectData> lEffectList = Api.Item.Effect.Singleton.Enumerate().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = 1;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = 1;

            return lEffectList.ToArray();
        }
        #endregion
    }
}