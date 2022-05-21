using Exp.Core;

namespace Exp.Test {
    public partial class frmFeatList : Form {
        public CharacterSheet Sheet { get; init; }

        public frmFeatList(CharacterSheet aSheet) {
            InitializeComponent();

            Sheet = aSheet;
        }

        private void frmFeatList_Load(object sender, EventArgs e) {
            Sheet.Feat.Aura.EnumerateUnused().ToList().ForEach(x => checkedListBox1.Items.Add(x.GetName(), false));
            Sheet.Feat.Defensive.EnumerateUnused().ToList().ForEach(x => checkedListBox2.Items.Add(x.GetName(), false));
            //Zu verteilende Punkte...
            //Sheet.Feat.AvailableFeatPoints
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (sender is CheckedListBox aObject) {
                textBox1.Text = Api.Feat.Aura.Singleton.Get(aObject.SelectedIndex).GetFullDescription();
            } else {
                textBox1.Text = string.Empty;
            }
            //Exp.Api.Feat.Aura.Singleton.Get(sender.)
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e) {
            if (sender is CheckedListBox aObject) {
                textBox2.Text = Api.Feat.Defensive.Singleton.Get(aObject.SelectedIndex).GetFullDescription();
            } else {
                textBox2.Text = string.Empty;
            }
            //Exp.Api.Feat.Aura.Singleton.Get(sender.)
        }
    }
}