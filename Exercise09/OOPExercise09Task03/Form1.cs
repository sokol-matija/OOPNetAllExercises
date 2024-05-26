using Model;
using Newtonsoft.Json;
using RestSharp;
using static System.Net.WebRequestMethods;

namespace OOPExercise09Task03
{
    public partial class Form1 : Form
    {
        private const string ENDPOINT = "https://reqres.in/api/users";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataAsync();
        }

        private async void FillDataAsync()
        {
            try
            {
                RestResponse<UserData> restResponse = await GetData();
                UserData? userData = DeserializeContent(restResponse.Content);

                if (userData == null)
                {
                    lblInfo.Text = "No data";
                    return;
                }

                foreach (User user in userData.Users)
                {
                    ddlUsers.Items.Add(user);
                }
                ddlUsers.SelectedIndex = 0;
                lblInfo.Text = "Successfully fetched data";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private UserData? DeserializeContent(string? content)
        {
            if (content == null)
            {
                throw new Exception("Content is null");
            }
            return JsonConvert.DeserializeObject<UserData>(content);
        }

        private Task<RestResponse<UserData>> GetData()
        {
            RestClient client = new RestClient();
            return client.ExecuteAsync<UserData>(new RestRequest(ENDPOINT));
        }
    }
}
