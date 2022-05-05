namespace Exp.DefaultMod.Item.ItemQuality {
    public sealed class Masterwork : Exp.Data.Item.ItemQualityDataBase, Exp.Data.Item.IItemQualityData {
        #region Konstruktor
        private Masterwork()
            : base(nameof(Masterwork), 500, false, false, GetEffects()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Meisterarbeit");
            Name.Set(Util.LanguageEnum.English, "Masterwork");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Masterwork());
        }

        private static Exp.Data.Item.IEffectData[] GetEffects() {
            List<Exp.Data.Item.IEffectData> lEffectList = Exp.Api.Item.Effect.Singleton.List().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = 1;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = 1;

            return lEffectList.ToArray();
        }
        #endregion
    }
}