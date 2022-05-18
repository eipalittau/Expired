using Exp.Data.Feat.Aura;
using Exp.Util;
using Exp.Util.Extension;

namespace Exp.Test {
    public partial class frmFeatList : Form {
        public frmFeatList() {
            InitializeComponent();
        }

        private void frmFeatList_Load(object sender, EventArgs e) {
        }

        public void AuraList(IList<IAuraData> aDataList) {
            aDataList.ToList().ForEach(x => checkedListBox1.Items.Add(x.Name.Get(Localisation.Language), false));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (sender is CheckedListBox aObject) {
                textBox1.Text = Api.Feat.Aura.Singleton.Get(aObject.SelectedItem.Null2String()).GetFullDescription();
            } else {
                textBox1.Text = string.Empty;
            }
            //Exp.Api.Feat.Aura.Singleton.Get(sender.)
        }
    }
}
