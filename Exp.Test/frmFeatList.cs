using Exp.Util;

namespace Exp.Test {
    public partial class frmFeatList : Form {
        public frmFeatList() {
            InitializeComponent();
        }

        private void frmFeatList_Load(object sender, EventArgs e) {
            Exp.Api.Feat.Aura.Singleton.Enumerate().ToList().ForEach(x => checkedListBox1.Items.Add(x.Name.Get(Localisation.Language), false));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (sender is CheckedListBox aObject) {
                textBox1.Text = Exp.Api.Feat.Aura.Singleton.Get(aObject.SelectedItem.Null2String())
                    .GetFullDescription();
            } else {
                textBox1.Text = string.Empty;
            }
            Exp.Api.Feat.Aura.Singleton.Get(sender.)
        }
    }
}
