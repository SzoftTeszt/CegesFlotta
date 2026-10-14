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
    }
}
