namespace RtD.Data {
    // TODO: Wenn Dice == null -> Modifier ist allgemein, sonst nur auf Item
    public sealed class EffectData {
        internal EffectData(Json.ArmorClassJsonData aJsonData) {
            Modifier = aJsonData.Modifier;
            Effect = EffectEnum.Convert(aJsonData.Effect);
            Range = RangeEnum.Convert(aJsonData.Range);
        }

        internal EffectData(Json.DamageJsonData aJsonData) {
            Effect = EffectEnum.Convert(aJsonData.Effect);
            Dice = new DiceData(aJsonData.Dice);
        }

        internal EffectData(Json.AttackJsonData aJsonData) {
            Effect = EffectEnum.Convert(aJsonData.Effect);
        }

        internal EffectData(Json.ManaJsonData aJsonData) {
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
}//TODO: !!!Wie Meldungen. Nur Nr oder auch Text?