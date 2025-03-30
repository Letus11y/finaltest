using Microsoft.Maui.Controls;
using ShowMens.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShowMens.Models;

namespace ShowMens.Pages
{
    public partial class OtherPage : ContentPage
    {
        private readonly ApiService _apiService = new();

        public OtherPage()
        {
            InitializeComponent();
            LoadUsers();
        }

        private async void LoadUsers()
        {
            List<UserModel> users = await _apiService.GetMaleUsersAsync();
            UsersListView.ItemsSource = users;
        }
    }
}
