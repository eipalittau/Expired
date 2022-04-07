namespace RtD.Data {
    //Achtung: Wenn Dice == null -> Modifier ist allgemein, sonst nur auf Item
    public sealed class EffectData {
        internal EffectData(Json.Item.ArmorClassJsonData aJsonData) {
            Modifier = aJsonData.Modifier;
            Effect = EffectEnum.Convert(aJsonData.Effect);
            Range = RangeEnum.Convert(aJsonData.Range);
        }

        internal EffectData(Json.Item.DamageJsonData aJsonData) {
            Effect = EffectEnum.Convert(aJsonData.Effect);
            Dice = new DiceData(aJsonData.Dice);
        }

        internal EffectData(Json.Item.AttackJsonData aJsonData) {
            Effect = EffectEnum.Convert(aJsonData.Effect);
        }

        internal EffectData(Json.Item.ManaJsonData aJsonData) {
            Modifier = aJsonData.Modifier;
            Effect = EffectEnum.Convert(aJsonData.Effect);
        }

        /// <summary>Basiswert</summary>
        public int Base { get; set; }
        public DiceData? Dice { get; set; }
        /// <summary>Wird zum Basiswert addiert</summary>
        public int Modifier { get; set; }
        public EffectEnum Effect { get; set; } = EffectEnum.None;
        public RangeEnum Range { get; set; } = RangeEnum.None;
    }
}