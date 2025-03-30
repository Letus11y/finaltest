using Microsoft.Maui.Controls;
using ShowMens.ViewModels;

namespace ShowMens.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
			BindingContext =vm;
        }

       
    }
}
