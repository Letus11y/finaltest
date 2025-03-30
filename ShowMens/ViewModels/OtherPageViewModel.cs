using System;
using CommunityToolkit.Mvvm.ComponentModel;
using ShowMens.Services.Interfaces;



namespace ShowMens.ViewModels
{
     public class OtherPageViewModel : ObservableObject
     {     
        private  IApiServicesRepository _apiService;

        public OtherPageViewModel(IApiServicesRepository apiService)
        {
            _apiService  = apiService;
        }

    
    public  void GetMales()
        {
             _apiService.GetMens(); 
        }
    }


}

