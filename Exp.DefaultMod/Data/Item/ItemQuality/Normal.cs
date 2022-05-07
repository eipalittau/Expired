namespace Exp.DefaultMod.Item.ItemQuality {
    public sealed class Normal : Exp.Data.Item.ItemQualityDataBase, Exp.Data.Item.IItemQualityData {
        #region Konstruktor
        private Normal()
            : base(nameof(Normal), 300, true, true, GetEffects()) {
            Name.Set(Util.LanguageEnum.Deutsch, "Normal");
            Name.Set(Util.LanguageEnum.English, "Normal");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Normal());
        }

        private static Exp.Data.Item.IEffectData[] GetEffects() {
            List<Exp.Data.Item.IEffectData> lEffectList = Api.Item.Effect.Singleton.Enumerate().Where(x => x != null).ToList();

            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Primary))).First().Value = 0;
            lEffectList.Where(x => x.ID.Equals(nameof(Effect.Secondary))).First().Value = 0;

            return lEffectList.ToArray();
        }
        #endregion
    }
}