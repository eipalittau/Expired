namespace RtD.CharacterSheetTest {
    public partial class frmMain : Form {
        private Data.Main mData = new Data.Main();

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            mData.LoadData(@"D:\Projekte\RtD\RtD.Data\bin\Debug\net6.0", Enumerations.LanguageEnum.Deutsch);
        }
    }
}