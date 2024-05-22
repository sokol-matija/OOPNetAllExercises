using DAL;
using Model;

namespace OOPExercise03Task03
{
    public partial class Form1 : Form
    {
        private PlayerService playerService = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            try
            {
                List<Player> players = playerService.GetPlayers();
                foreach (Player player in players)
                {
                    clbPlayers.Items.Add(player);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnLoadAllPlayers_Click(object sender, EventArgs e)
        {
            clbPlayers.Items.Clear();
            LoadPlayers();
        }

        private void btnRemoveSelectedPlayers_Click(object sender, EventArgs e)
        {
            List<Player> selectedPlayers = new();

            foreach (Player player in clbPlayers.CheckedItems)
            {
                selectedPlayers.Add(player);
            }

            selectedPlayers.ForEach(p => clbPlayers.Items.Remove(p));
        }
 
    }
}
