using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShowMens.Models;
using ShowMens.Services;

namespace ShowMens.ViewModels
{
    public partial class OtherPageViewModel : ObservableObject
    {
        private readonly ApiService _apiService;

        [ObservableProperty]
        private ObservableCollection<UserModel> users;

        public OtherPageViewModel()
        {
            _apiService = new ApiService();
            Users = new ObservableCollection<UserModel>();
            LoadUsers();
        }

        public IAsyncRelayCommand LoadUsersCommand { get; }

        private async Task LoadUsers()
        {
            var userList = await _apiService.GetMaleUsersAsync();
            Users = new ObservableCollection<UserModel>(userList);
        }
    }
}
