using Common;

namespace Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            PlayersService service = new();

            try
            {
                List<Player> players = service.GetPlayers();
                foreach (Player p in players)
                {
                    ddlPlayers.Items.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Player? selectedPlayer = ddlPlayers.SelectedItem as Player;
            if (selectedPlayer is null)
            {
                return;
            }

            txtPlayers.AppendText($"[{DateTime.Now:HH:mm:ss}] {selectedPlayer}{Environment.NewLine}");

            ddlPlayers.Items.Remove(selectedPlayer);
        }
    }
}