namespace RtD.Data {
    public sealed class HealthData {
        public int Max { get; set; }
        public int Current { get; set; }
        public int Virtual { get; set; }

        public void Heal(int aValue) {
            if (aValue > 0) {
                Current += aValue;

                if (Current > Max) {
                    Current = Max;
                }
            }
        }

        public override string ToString() {
            if (Virtual > 0) {
                return $"{Current} / {Max}";
            } else {
                return $"{Current + Virtual} / {Max}";
            }
        }
    }
}