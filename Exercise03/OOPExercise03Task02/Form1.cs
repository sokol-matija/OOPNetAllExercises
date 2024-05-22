using DAL;
using Model;

namespace OOPExercise03Task02
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
                List<Player> list = new List<Player>();
                foreach (Player player in playerService.GetPlayers())
                {
                    ddlPlayers.Items.Add(player);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Player? player = ddlPlayers.SelectedItem as Player;
            if (player is null)
            {
                return;
            }

            txtPlayers.AppendText($"[{DateTime.Now:HH:mm:ss}] {player} {Environment.NewLine}");

            ddlPlayers.Items.Remove(player);
        }
    }
}
