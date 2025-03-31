using ShowMens.ViewModels;

namespace ShowMens.Pages
{
    public partial class OtherPage : ContentPage
    {
        public OtherPage(OtherPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
