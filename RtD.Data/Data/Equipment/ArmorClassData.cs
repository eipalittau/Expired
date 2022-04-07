namespace RtD.Data {
    public sealed class ArmorClassData {
        internal ArmorClassData(Json.PlayerClass.ArmorClassJsonData aJsonData) {
            if (aJsonData.Ranged != null) {
                FightType = FightTypeEnum.Ranged;
                Modifier = aJsonData.Ranged.Modifier;
                Affects = AffectEnum.Convert(aJsonData.Ranged.Affects);
            } else if (aJsonData.Melee != null) {
                FightType = FightTypeEnum.Melee;
                Modifier = aJsonData.Melee.Modifier;
                Affects = AffectEnum.Convert(aJsonData.Melee.Affects);
            } else {
                FightType = FightTypeEnum.None;
                Modifier = 0;
                Affects = AffectEnum.None;
            }
        }

        /// <summary>Wird zum Basiswert addiert</summary>
        public int Modifier { get; set; }
        public FightTypeEnum FightType { get; set; }
        public AffectEnum Affects { get; set; }
    }
}