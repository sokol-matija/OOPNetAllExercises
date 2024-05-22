using Zadatak03.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Zadatak03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private async void FillData()
        {
            lblInfo.Text = "Fetching data...";
            var responseData = await GetData();
            UsersData data = DeserializeData(responseData);
            lblInfo.Text = string.Empty;

            foreach (var user in data.Users)
            {
                ddlPersons.Items.Add(user);
            }
            ddlPersons.SelectedIndex = 0;
        }

        private Task<RestResponse<UsersData>> GetData()
        {
            var apiKlijent = new RestClient("https://reqres.in/api/users");
            return apiKlijent.ExecuteAsync<UsersData>(new RestRequest());
        }

        private static T DeserializeData<T>(RestResponse<T> responseData)
        {
            return JsonConvert.DeserializeObject<T>(responseData.Content);
        }
    }
}
