namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int Progress = 10;
                int Tier1Count = 5;
                int Tier2Count = 4;
                int Tier3Count = 1;
                int Attack, Damage;
                if (Progress <= Tier1Count) {
                    Attack = Damage = Progress;
                } else if (Progress <= Tier1Count + Tier2Count) {
                    Attack = Damage = Tier1Count + (Progress - Tier1Count) * 2;
                } else {
                    Attack = Damage = Tier1Count + Tier2Count * 2 + (Progress - Tier1Count - Tier2Count) * 3;
                }
            } catch(System.Exception aEx) {
                aEx = aEx;
            }
        }
    }
}