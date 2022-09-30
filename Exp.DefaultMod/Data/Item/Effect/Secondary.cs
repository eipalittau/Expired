using Exp.Data.Item.Effect;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.Effect
{
    public sealed class Secondary : EffectDataBase, IEffectData {
        #region Konstruktor
        private Secondary()
            : base(nameof(Secondary), 200) {
            Name.Set(LanguageEnum.Deutsch, "Sekundär");
            Name.Set(LanguageEnum.English, "Secondary");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Secondary());
        }
        #endregion
    }
}