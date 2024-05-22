using DAL;
using Model;
using System.Collections;

namespace OOPExercise03Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerService playerService = new PlayerService();
            try
            {
                List<Player> players = playerService.GetPlayers();
                foreach (Player player in players)
                {
                    lbPlayersBench.Items.Add(player);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToBenchOne_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersPlaying, lbPlayersBench, lbPlayersPlaying.SelectedItems);
        }

        private void btnToBenchAll_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersPlaying, lbPlayersBench, lbPlayersPlaying.Items);
        }

        private void btnToPlayOne_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersBench, lbPlayersPlaying, lbPlayersBench.SelectedItems);
        }

        private void btnToPlayAll_Click(object sender, EventArgs e)
        {
            MovePlayers(lbPlayersBench, lbPlayersPlaying, lbPlayersBench.Items);
        }

        private void cbSort_CheckedChanged(object sender, EventArgs e)
        {
            lbPlayersPlaying.Sorted = lbPlayersBench.Sorted = cbSort.Checked;
        }

        private void MovePlayers(ListBox from, ListBox to, IEnumerable selectedItems)
        {
            List<Player> playersCopy = new List<Player>();
            foreach (var item in selectedItems)
            {
                if (item is Player player)
                {
                    playersCopy.Add(player);
                }
            }

            foreach (Player player in playersCopy)
            {
                to.Items.Add(player);
                from.Items.Remove(player);
            }
        }   
    }
}
