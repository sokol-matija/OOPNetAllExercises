using Common;

namespace Task03
{
    public partial class Form1 : Form
    {
        private PlayersService service = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            try
            {
                List<Player> players = service.GetPlayers();
                foreach (Player p in players)
                {
                    clbPlayers.Items.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            clbPlayers.Items.Clear();
            LoadPlayers();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            List<Player> selectedPlayers = new();

            foreach (Player p in clbPlayers.CheckedItems)
            {
                selectedPlayers.Add(p);
            }

            selectedPlayers.ForEach(p => clbPlayers.Items.Remove(p));
        }
    }
}