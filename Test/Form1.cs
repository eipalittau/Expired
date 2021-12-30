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
                throw new RtD.Exceptions.MissingDataException();
            } catch(System.Exception aEx) {
                aEx = aEx;
            }
        }
    }
}