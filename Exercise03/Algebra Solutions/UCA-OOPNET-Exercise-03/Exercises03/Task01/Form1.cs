using Common;
using System.Collections;

namespace Task01
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
                    lbPlayersBanch.Items.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInGameAll_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersBanch, lbPlayersPlaying, lbPlayersBanch.Items);
        }

        private void BtnToBanchAll_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersPlaying, lbPlayersBanch, lbPlayersPlaying.Items);
        }

        private void BtnInGameOne_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersBanch, lbPlayersPlaying, lbPlayersBanch.SelectedItems);
        }

        private void BtnToBanchOne_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersPlaying, lbPlayersBanch, lbPlayersPlaying.SelectedItems);
        }

        private void MovePlayers(ListBox fromList, ListBox toList, IEnumerable selectedItems)
        {
            List<Player> players = new();

            foreach (Player p in selectedItems)
            {
                players.Add(p);
            }

            // Not working when loading data using DataSource
            foreach (Player p in players)
            {
                toList.Items.Add(p);
                fromList.Items.Remove(p);
            }
        }

        private void CbSort_CheckedChanged(object sender, EventArgs e)
        {
            lbPlayersBanch.Sorted = lbPlayersPlaying.Sorted = true;
        }
    }
}