
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;



namespace ShowMens.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            
        }
      
        [RelayCommand]
        public void Next()
        {
             Shell.Current.GoToAsync("OtherPage", true);
        }

       
    }
}
