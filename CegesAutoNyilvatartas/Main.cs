namespace CegesAutoNyilvatartas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEmberek_Click(object sender, EventArgs e)
        {
            Emberek form = new Emberek();
            form.ShowDialog();
        }

        private void btnAutok_Click(object sender, EventArgs e)
        {
            AutokNyilv ablak = new AutokNyilv();
            ablak.ShowDialog();
        }
    }
}
