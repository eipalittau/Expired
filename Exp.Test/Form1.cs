namespace Exp.Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Api.Main.Singleton.Initialize(3, true, Util.LanguageEnum.Deutsch);
            Api.Main.Singleton.CreateCharacter();
        }
    }
}