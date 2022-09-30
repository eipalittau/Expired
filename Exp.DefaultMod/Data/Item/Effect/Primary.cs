using Exp.Data.Item.Effect;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.Effect
{
    public sealed class Primary : EffectDataBase, IEffectData {
        #region Konstruktor
        private Primary()
            : base(nameof(Primary), 100) {
            Name.Set(LanguageEnum.Deutsch, "Primär");
            Name.Set(LanguageEnum.English, "Primary");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Primary());
        }
        #endregion
    }
}